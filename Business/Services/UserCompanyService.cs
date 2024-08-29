using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts.IContext;
using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IService;
using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Models;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Services.Services
{
    class UserCompanyService : ServiceBase, IUserCompanyService, IScopeMarker
    {

        private UserManager<User> _userManager;
        public UserCompanyService(
            IMapper mapper,
            UserManager<User> userManager,
            ILoggerManager logger,
            IRepositoryManager repoManger,
            IHttpContextAccessor httpContextAccessor,
            ISystemContext systemContext,
            IRelationsService relationsService
        )
            : base(repoManger, mapper, httpContextAccessor, systemContext, logger)
        {

            _userManager = userManager;
        }

        /// <summary>
        /// ایجاد ارتباط بین کاربر و شرکت
        /// 
        /// شرایط وجود همکاری قبلی و ... چک میشود
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="CompanyId"></param>
        /// <returns></returns>
        public async Task<UserCompanyDto> AddUserToCompany(string PhoneNumber, Guid CompanyId, string PersonnelCode)
        {

            var User = _userManager.Users.FirstOrDefault(x => x.PhoneNumber == PhoneNumber);

            if (User is null)
                throw new Exception("User was not found!");
            
            return await this.AddUserToCompany(Guid.Parse(User.Id),CompanyId,PersonnelCode);


        }


        /// <summary>
        /// ایجاد ارتباط بین کاربر و شرکت
        /// 
        /// شرایط وجود همکاری قبلی و ... چک میشود
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="CompanyId"></param>
        /// <returns></returns>
        public async Task<UserCompanyDto> AddUserToCompany(Guid UserId, Guid CompanyId, string PersonnelCode)
        {

         
            var oldModel = await _repositoryManager.UserCompany
                  .FindByCondition(x => x.UserId == UserId.ToString() && x.CompanyId == CompanyId, false)
                  .OrderByDescending(x => x.CreatedDate)
                  .FirstOrDefaultAsync();


            if (oldModel != null)
            {
                var activeModel = await _repositoryManager.UserCompany.FindByCondition(x => x.UserId == UserId.ToString() && x.IsActive, false).FirstOrDefaultAsync();

                if (oldModel.CompanyId == activeModel.CompanyId)
                    return _mapper.Map<UserCompanyDto>(activeModel);

                activeModel.IsActive = false;

                _repositoryManager.UserCompany.Update(activeModel);
                _repositoryManager.UserCompany.SaveChanges();



                oldModel.CreatedDate = DateTime.Now;
                oldModel.Id = Guid.NewGuid();
                oldModel.PersonnelCode = PersonnelCode;
                oldModel.IsActive = true;

                _repositoryManager.UserCompany.Create(oldModel);
                _repositoryManager.UserCompany.SaveChanges();

                return _mapper.Map<UserCompanyDto>(oldModel);
            }
            else
            {
                UserCompany newModel = new()
                {
                    CompanyId = CompanyId,
                    UserId = UserId.ToString(),
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    Id = Guid.NewGuid(),
                    PersonnelCode = PersonnelCode,
                };


                _repositoryManager.UserCompany.Create(newModel);
                _repositoryManager.UserCompany.SaveChanges();
                return _mapper.Map<UserCompanyDto>(oldModel);
            }


        }
    }
}
