using AutoMapper;
using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Models;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ConfigureCompany(); // Model <-> Dto
            ConfigureEmplyee(); // Model <-> Dto
            ConfigureIdentity();

            CreateMap<Company, CompanyDto>().ReverseMap();
            CreateMap<Relatives,RelativeDto>().ReverseMap();
           


        }

        public void ConfigureCompany()
        {
            //CreateMap<CompanyModel, CompanyDto>()
             //   .ForMember(c => c.FullAddress,opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

          //  CreateMap<CompanyForCreationDto, CompanyModel>();//.ForMember(c=>c.Id,opt=>opt.MapFrom(val=>new Guid()));
        }

        public void ConfigureEmplyee()
        {
          //  CreateMap<EmployeeModel, EmployeeDto>().ReverseMap();
           // CreateMap<EmployeeModel,EmployeeForCreationDto>().ReverseMap();
           // CreateMap<EmployeeModel,EmployeeForUpdateDto>().ReverseMap();

        }

        public void ConfigureIdentity()
        {
            CreateMap<UserForRegistrationDto, User>();
        }

        
    }

}
