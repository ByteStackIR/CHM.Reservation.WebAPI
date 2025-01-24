using Contracts.IDapperRepository;
using Contracts.IRepository;
using Contracts.IService;
using Dapper;
using Dapper.DapperReporsitory;
using Entities;
using Entities.Claims;
using Entities.Mapper;
using LoggerService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using NLog;
using Repositories;
using Services;
using Services.Services;
using WebAPI;
using WebAPI.ActionFilters;
using WebAPI.Configuration;
using WebAPI.Extensions;
using AuthenticationService = Services.Services.AuthenticationService;
using IAuthenticationService = Contracts.IService.IAuthenticationService;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        LogManager.LoadConfiguration(
            string.Concat(Directory.GetCurrentDirectory(), "/nlog.config")
        );


        // ! PRODUCTION PUBLISH IN LIARA
        // var connectionString = builder.Configuration.GetConnectionString("productionSql");
        // builder.Services.AddDbContext<DBContextProvider>(options =>
        //     options.UseSqlServer(connectionString, b => b.MigrationsAssembly("WebAPI"))
        // );
        //Server=SQLLow04.centraldnserver.com;Database=TRIP;User Id=byte-YFDGy_sa;Password=11$Poc34w;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=False
        var connectionString = builder.Configuration.GetConnectionString("sqlConnection");
        builder.Services.AddDbContext<DBContextProvider>(options =>
            options.UseSqlServer("Server=SQLLow04.centraldnserver.com;Database=TRIP;User Id=byte-YFDGy_sa;Password=11$Poc34w;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=False", b => b.MigrationsAssembly("WebAPI"))
        );

        builder.Services.ConfigureIdentity();
        builder.Services.ConfigureJWT(builder.Configuration);
        builder.Services.ConfigureAuthorization();
        builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));

        builder.Services.ConfigureCors();
        builder.Services.ConfigureRepositoryManager();

        //builder.Services.AddControllers();
        builder.Services.ConfigureVersioning();
        builder
            .Services.AddControllers(config =>
            {
                config.RespectBrowserAcceptHeader = true;
                config.ReturnHttpNotAcceptable = true;
            })
            .AddXmlDataContractSerializerFormatters();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

        builder.Services.ConfigureSwagger();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.ConfigureResponseCaching();
        builder.Services.ConfigureOutputCaching();

        builder.Services.AddSingleton<IAuthorizationHandler, AuthorizationHandler>();

        builder.Services.DapperInstallation();

        builder.Services.AddAutoMapper(typeof(MappingProfile));
        //=====================Dependency Injection================
        builder.Services.AddScoped<ILoggerManager, LoggerManager>();
        builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
        builder.Services.AddScoped<IReservationService, ReservationService>();
        // builder.Services.AddScoped<IDapperRepositoryManager, DapperRepositoryManager>();
        // builder.Services.RegisterServices();
        builder.Services.RegisterPaymentGateway();
        builder.Services.ConfigureDenpdencyInjectionByMarker();

        //ActionFilter on level of controller and actions
        builder.Services.AddScoped<ValidationFilterAttribute>();
        //=========================================================




        var app = builder.Build();

        app.Configure(app.Environment);

        app.UseResponseCaching();
        app.UseOutputCache();
        // app.UseRateLimiter();
        app.Use(
            async (context, next) =>
            {
                next.Invoke();
            }
        );

        app.ConfigureExceptionHandler(new LoggerManager());
        //Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });




        app.Run();
    }
}
