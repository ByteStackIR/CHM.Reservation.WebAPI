using Asp.Versioning;
using Entities;
using Entities.Claims;
using Entities.Models;
using Entities.PolicyTypes;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Threading.RateLimiting;
using Entities;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Reflection;
using Contracts.IRepository;
using Repositories;
using WebAPI.Configuration;

namespace WebAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.ConfigureCors();
            services.ConfigureIISIntegration();
            services.AddControllers();
        }

        public static void Configure(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                

            }
            else
            {
                app.UseHsts();
            }
            app.UseSwagger();
            app.UseSwaggerUI();

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCors("CorsPolicy");


            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });
        }

        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });
        }
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            }
            );
        }

        public static void ConfigureVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(opt =>
            {
                opt.ReportApiVersions = true;
                opt.AssumeDefaultVersionWhenUnspecified = true;
                opt.DefaultApiVersion = new ApiVersion(1, 0);
                opt.ApiVersionReader = new HeaderApiVersionReader("api-version");

            }).AddApiExplorer(options =>
            {
                // add the versioned api explorer, which also adds IApiVersionDescriptionProvider service
                // note: the specified format code will format the version as "'v'major[.minor][-status]"
                options.GroupNameFormat = "'v'VVV";

                // note: this option is only necessary when versioning by url segment. the SubstitutionFormat
                // can also be used to control the format of the API version in route templates
                options.SubstituteApiVersionInUrl = true;
            }).AddMvc(); // Nuget Package: Asp.Versioning.Mvc.ApiExplorer;


        }

        public static void ConfigureResponseCaching(this IServiceCollection services)
        {
            services.AddResponseCaching();
        }

        public static void ConfigureOutputCaching(this IServiceCollection services)
        {
            services.AddOutputCache();
        }

        public static void ConfigureRateLimitingOptions(this IServiceCollection services)
        {
            services.AddRateLimiter((opt) =>
            {
                //[DisableRateLimiting]    - for disable limition for certain endpint


                // FOR ALL ENDPOINT (I MEAN GLOBALLY)
                opt.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>((context) =>
                {
                    return RateLimitPartition.GetFixedWindowLimiter("GlobalLimiter",
                      (partition) => new FixedWindowRateLimiterOptions
                      {
                          AutoReplenishment = true,
                          PermitLimit = 5,
                          QueueLimit = 0, // more than 5 reqs will be settle in queue , if reqs be more than limit+queue req will be rejected!
                          QueueProcessingOrder = QueueProcessingOrder.OldestFirst,
                          Window = TimeSpan.FromMinutes(1)
                      });
                });


                // CERTAIN ENPOINT
                // [EnableRateLimiting("SpecificPolicy")]  - add attribute to your endpoint
                opt.AddPolicy("SpecificPolicy", context =>
                {
                    return RateLimitPartition.GetFixedWindowLimiter("SpecificLimiter", partition =>
                    {
                        return new FixedWindowRateLimiterOptions()
                        {
                            AutoReplenishment = true,
                            PermitLimit = 3,
                            Window = TimeSpan.FromSeconds(10)
                        };
                    });
                });




                opt.RejectionStatusCode = 429;  //default = 503 Service Unavaliable!


                // instead of RejectionCode we can use it
                opt.OnRejected = async (context, token) =>
                {
                    context.HttpContext.Response.StatusCode = 429;
                    if (context.Lease.TryGetMetadata(MetadataName.RetryAfter, out var retryAfter))
                        await context.HttpContext.Response.WriteAsync($"Too many requests. Please try again after {retryAfter.TotalSeconds} second(s).", token);
                    else
                        await context.HttpContext.Response.WriteAsync("Too many requests. Please try again later.", token);
                };

            });

        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services
                  .AddIdentity<User, IdentityRole>(o =>
                  {
                      o.Password.RequireDigit = true;
                      o.Password.RequireLowercase = false;
                      o.Password.RequireUppercase = false;
                      o.Password.RequireNonAlphanumeric = false;
                      o.Password.RequiredLength = 3;
                      o.User.RequireUniqueEmail = false;
                      o.Lockout.AllowedForNewUsers = true;

                      o.Lockout.MaxFailedAccessAttempts = 10;
                      o.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);

                      o.Tokens.ProviderMap.Add(
                          "CustomSMSConfirmation",
                          new TokenProviderDescriptor(
                              typeof(CustomSMSCodeConfirmationTokenProvider)
                          )
                      );
                      o.Tokens.ChangePhoneNumberTokenProvider = "CustomSMSConfirmation";

                  })
                  .AddEntityFrameworkStores<DBContextProvider>()
                  .AddDefaultTokenProviders();

            builder.Services.AddTransient<CustomSMSCodeConfirmationTokenProvider>();

        }

        public static void ConfigureJWT(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtSettings = configuration.GetSection("JwtSettings");
            var secretKey = jwtSettings["Secret"];
            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            })
            .AddJwtBearer(options =>
            {
               // options.Authority = "https://localhost:7100";
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSettings["validIssuer"],
                    ValidAudience = jwtSettings["validAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),

                };

                options.Events = new JwtBearerEvents()
                {
                    OnTokenValidated = (ctx) =>
                    {
                        var t = ctx;
                        return Task.CompletedTask; 
                    },
                    OnChallenge = (ctx) =>
                    {
                        var t = ctx;
                        return Task.CompletedTask;
                    },
                    OnAuthenticationFailed = (ctx) =>
                    {
                        var t = ctx;
                        return Task.CompletedTask;
                    }
                };

            });
        }

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(s =>
            {
                string EntryProjectName = Assembly.GetEntryAssembly().FullName.Split(',')[0];

                s.IncludeXmlComments(Directory.GetCurrentDirectory()+Path.DirectorySeparatorChar+ EntryProjectName + ".swagger.xml", true);
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Web API",
                    Version = "v1"
                });
                s.SwaggerDoc("v2", new OpenApiInfo
                {
                    Title = "Web API",
                    Version = "v2"
                });
                s.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Place to add JWT with Bearer",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                s.AddSecurityRequirement(new OpenApiSecurityRequirement() {
                    {
                        new OpenApiSecurityScheme {
                            Reference = new OpenApiReference {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer" }, Name = "Bearer",
                        },
                        new List<string>()
                    }
                });
            });
        }


        public static void ConfigureAuthorization(this IServiceCollection services)
        {
    
            services.AddAuthorization(options =>
            {
                options.AddPolicy(PolicyTypes.Teams.Manage, policy =>
                {
                    policy.RequireClaim(CustomClaimTypes.Permission, Teams.EditManagers);
                });
                options.AddPolicy(PolicyTypes.Teams.AddRemove, policy => { policy.RequireClaim(CustomClaimTypes.Permission, Teams.AddRemove); });
                options.AddPolicy(PolicyTypes.Users.Manage, policy => { policy.RequireClaim(CustomClaimTypes.Permission, Users.Add); });
                options.AddPolicy(PolicyTypes.Users.EditRole, policy => { policy.RequireClaim(CustomClaimTypes.Permission, Users.EditRole); });
                options.AddPolicy(PolicyTypes.Users.EditRole, policy => { policy.RequireClaim(CustomClaimTypes.Permission, Users.EditRole); });

                options.InvokeHandlersAfterFailure = true;


            });

           
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
    }
}
