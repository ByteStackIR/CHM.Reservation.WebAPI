namespace Services.Services
{
    using AutoMapper;
    using Contracts.IContext;
    using Contracts.IMarker;
    using Contracts.IRepository;
    using Contracts.IService;
    using Entities.DataTransferObjects;
    using Entities.Models;
    using Entities.QueryExtensions;
    using Features.CustomRequest;
    using Features.RequestFeatures;
    using LoggerService;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="UsersService" />
    /// </summary>
    public class UsersService : ServiceBase, IUsersService, IScopeMarker
    {
        /// <summary>
        /// Defines the _userManager
        /// </summary>
        private UserManager<User> _userManager;

        RoleManager<IdentityRole> _roleManager;
        /// <summary>
        /// Defines the _relativesService
        /// </summary>
        private IRelativesService _relativesService;

        /// <summary>
        /// Defines the _userCompanyService
        /// </summary>
        private IUserCompanyService _userCompanyService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersService"/> class.
        /// </summary>
        /// <param name="userManager">The userManager<see cref="UserManager{User}"/></param>
        /// <param name="relativesService">The relativesService<see cref="IRelativesService"/></param>
        /// <param name="userCompanyService">The userCompanyService<see cref="IUserCompanyService"/></param>
        /// <param name="mapper">The mapper<see cref="IMapper"/></param>
        /// <param name="logger">The logger<see cref="ILoggerManager"/></param>
        /// <param name="repoManger">The repoManger<see cref="IRepositoryManager"/></param>
        /// <param name="httpContextAccessor">The httpContextAccessor<see cref="IHttpContextAccessor"/></param>
        /// <param name="systemContext">The systemContext<see cref="ISystemContext"/></param>
        public UsersService(
            UserManager<User> userManager,
            IRelativesService relativesService,
            IUserCompanyService userCompanyService,
            IMapper mapper,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext,
             RoleManager<IdentityRole> roleManager
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger)
        {
            _userManager = userManager;
            _userCompanyService = userCompanyService;
            _relativesService = relativesService;
            _roleManager = roleManager;
        }

        /// <summary>
        /// The GetAllUsersAsAdmin
        /// </summary>
        /// <param name="request">The request<see cref="AdminUsersTableRequest"/></param>
        /// <returns>The <see cref="Task{PagedData{List{UserFullDto}}}"/></returns>
        public async Task<PagedData<List<UserFullDto>>> GetAllUsersAsAdmin(
            AdminUsersTableRequest request
        )
        {
            var query = _userManager.Users;

            int count = await query.CountAsync();

            var data = await query
                .GetPage(request)
                .Include(x => x.UserCompanies.Where(x => x.IsActive))
                .Include(y => y.Relatives.Where(z => z.RelationId == Guid.Parse("10f944bb-9d33-4279-aed3-8f372907f27e"))) // دریافت کد ملی خود کاربر
                .ToListAsync();

            var result = new List<UserFullDto>();

            foreach (var item in data)
            {
                result.Add(
                    new()
                    {
                        Id = Guid.Parse(item.Id),
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                        PhoneNumber = item.PhoneNumber,
                        IdentityCode = item.Relatives.FirstOrDefault()?.IdentityCode ?? "فاقد کد ملی",
                        CompanyId = item.UserCompanies.FirstOrDefault()?.CompanyId.ToString() ?? "فاقد شرکت",
                        PersonnelCode =
                            item.UserCompanies.FirstOrDefault()?.PersonnelCode ?? "فاقد شرکت",

                    }
                );
            }

            return new(new(count, request.PageNumber, request.PageSize), result);
        }

        /// <summary>
        /// The GetAllUsersAsCompany
        /// </summary>
        /// <param name="request">The request<see cref="AdminUsersTableRequest"/></param>
        /// <returns>The <see cref="Task{PagedData{List{UserDto}}}"/></returns>
        public async Task<PagedData<List<UserDto>>> GetAllUsersAsCompany(
            AdminUsersTableRequest request
        )
        {
            var query = _userManager
                .Users.Include(x => x.UserCompanies.Where(y =>
                        y.IsActive && y.CompanyId == _systemContext.UserCompany.Id
                    ));

            int count = await query.CountAsync();

            var data = await query
                .GetPage(request)
                .Include(x => x.UserCompanies.Where(x => x.IsActive))
                .ToListAsync();

            var result = new List<UserDto>();

            foreach (var item in data)
            {
                result.Add(
                    new()
                    {
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                        PhoneNumber = item.PhoneNumber,
                        Id = Guid.Parse(item.Id),
                        PersonnelCode =
                            item.UserCompanies.FirstOrDefault()?.PersonnelCode ?? "فاقد شرکت",
                    }
                );
            }

            return new(new(count, request.PageNumber, request.PageSize), result);
        }

        /// <summary>
        /// The RegisterUser
        /// </summary>
        /// <param name="userForRegistration">The userForRegistration<see cref="UserForRegistrationDto"/></param>
        /// <returns>The <see cref="Task{IdentityResult}"/></returns>
        public async Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration)
        {
            IdentityResult result = new();

            if (_userManager.Users.Any(x => x.PhoneNumber == userForRegistration.PhoneNumber))
                return IdentityResult.Failed(
                    new IdentityError()
                    {
                        Code = "DuplicatePhoneNumber",
                        Description = "An existing user with the new PhoneNumber already exists.",
                    }
                );

            var user = _mapper.Map<User>(userForRegistration);
            try
            {
                user.UserName = "U" + user.PhoneNumber;
                result = await _userManager.CreateAsync(user, Guid.NewGuid().ToString());
                if (result.Succeeded)
                {
                    // افزودن اطلاعات کاربر با نسب خود به جدول اطرافیان
                    var selfRelatives = await _relativesService.AddSelf(userForRegistration);
                    // ارتباط با شرکت
                    await _userCompanyService.AddUserToCompany(
                        Guid.Parse(selfRelatives.UserId),
                        userForRegistration.CompanyId,
                        userForRegistration.PersonnelCode
                    );
                }
                return result;
            }
            catch (Exception ex)
            {
                return IdentityResult.Failed(
                    new IdentityError() { Code = "unexpctedError", Description = ex.Message }
                );
            }
        }

        /// <summary>
        /// The GetUserById
        /// </summary>
        /// <param name="UserId">The UserId<see cref="Guid"/></param>
        /// <returns>The <see cref="Task{UserForRegistrationDto}"/></returns>
        public async Task<UserForRegistrationDto> GetUserById(Guid UserId)
        {
            var user = await _userManager.Users
                .Include(x => x.UserCompanies.Where(x => x.IsActive))
                .Include(x => x.Relatives.Where(x => x.Relation.Type == Entities.Enum.RelationType.SELF)).ThenInclude(x => x.Relation)
                .FirstOrDefaultAsync(x => x.Id == UserId.ToString());

            var selfModel = user.Relatives.FirstOrDefault();

            return new()
            {
                BirthDate = selfModel.BirthDate,
                CompanyId = user.UserCompanies.FirstOrDefault(x => x.IsActive)?.CompanyId ?? Guid.Empty,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Gender = user.Gender,
                IdentityCode = selfModel.IdentityCode,
                PersonnelCode = user.UserCompanies.FirstOrDefault(x => x.IsActive)?.PersonnelCode ?? "",
                PhoneNumber = user.PhoneNumber,
                Roles = (await _userManager.GetRolesAsync(user)).ToList(),
                FatherName = selfModel.FatherName
            };
        }

        /// <summary>
        /// The ToggleUserLockOut
        /// </summary>
        /// <param name="UserId">The UserId<see cref="Guid"/></param>
        /// <returns>The <see cref="Task"/></returns>
        public async Task ToggleUserLockOut(Guid UserId)
        {
            var user = await _userManager.FindByIdAsync(UserId.ToString());

            if (user == null)
                throw new Exception($"User was not found by {UserId.ToString()}");

            if (await _userManager.IsLockedOutAsync(user))
            {
                await _userManager.SetLockoutEndDateAsync(user, DateTime.Now);
            }
            else
            {
                await _userManager.SetLockoutEndDateAsync(user, DateTime.Now.AddYears(25));

            }
        }

        /// <summary>
        /// The UpdateUserAsAdmin
        /// </summary>
        /// <param name="dto">The dto<see cref="UserUpdateDto"/></param>
        /// <returns>The <see cref="Task{bool}"/></returns>
        public async Task<bool> UpdateUserAsAdmin(UserUpdateDto dto)
        {
            var user = await _userManager.Users.Include(x => x.UserCompanies.Where(x => x.IsActive))
                .Include(x => x.Relatives.Where(x => x.Relation.Type == Entities.Enum.RelationType.SELF))
                .ThenInclude(x => x.Relation).FirstOrDefaultAsync(x => x.Id == dto.Id.ToString());

            if (user == null)
                throw new Exception($"User was not found by {dto.Id.ToString()}");

            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.PhoneNumber = dto.PhoneNumber;
            user.Gender = dto.Gender;
            user.UserName = "U" + dto.PhoneNumber;

            await _userManager.UpdateAsync(user);

            var currentRoles = await _userManager.GetRolesAsync(user);
            var currentRolesList = currentRoles.ToList();

            // Determine roles to remove
            var rolesToRemove = currentRolesList.Except(dto.Roles).ToList();

            // Determine roles to add
            var rolesToAdd = dto.Roles.Except(currentRolesList).ToList();

            // Remove old roles that are not in the new list
            if (rolesToRemove.Any())
            {
                await _userManager.RemoveFromRolesAsync(user, rolesToRemove);
            }

            // Add new roles that are not already assigned
            if (rolesToAdd.Any())
            {
                await _userManager.AddToRolesAsync(user, rolesToAdd);
            }




            var userCompany = user.UserCompanies.FirstOrDefault(x => x.IsActive);

            await _userCompanyService.AddUserToCompany(Guid.Parse(user.Id), dto.CompanyId, dto.PersonnelCode);

            await _relativesService.UpdateSelf(dto);
            return true;
        }

        /// <summary>
        /// The UpdateUserAsCompany
        /// </summary>
        /// <param name="dto">The dto<see cref="UserUpdateDto"/></param>
        /// <returns>The <see cref="Task{bool}"/></returns>
        public async Task<bool> UpdateUserAsCompany(UserUpdateDto dto)
        {
            var user = await _userManager.Users.Include(x => x.UserCompanies.Where(x => x.IsActive))
             .Include(x => x.Relatives.Where(x => x.Relation.Type == Entities.Enum.RelationType.SELF))
             .ThenInclude(x => x.Relation).FirstOrDefaultAsync(x => x.Id == dto.Id.ToString());

            if (user == null)
                throw new Exception($"User was not found by {dto.Id.ToString()}");

            var userCompany = user.UserCompanies.FirstOrDefault(x => x.IsActive);

            if (_systemContext.UserCompany.Id != userCompany.Id)
                throw new Exception($"You are not allowed to update this user!");

            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.PhoneNumber = dto.PhoneNumber;
            user.Gender = dto.Gender;
            user.UserName = "U" + dto.PhoneNumber;
            await _userManager.UpdateAsync(user);

            await _userCompanyService.AddUserToCompany(Guid.Parse(user.Id), dto.CompanyId, dto.PersonnelCode);

            await _relativesService.UpdateSelf(dto);

            return true;
        }

        public async Task<List<UserDto>> GetUsersByRoles(List<string> roles)
        {
            List<UserDto> Users = new();

            foreach (var role in roles)
            {
                var uInRoles = await _userManager.GetUsersInRoleAsync(role);

                foreach (var user in uInRoles)
                {
                    Users.Add(new()
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Id = Guid.Parse(user.Id),
                        PhoneNumber = user.PhoneNumber
                    });
                }

            }

            return Users;



        }
    }
}
