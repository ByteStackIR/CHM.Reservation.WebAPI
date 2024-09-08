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
            ConfigureBaseInfo(); // Model <-> Dto
            ConfigureRelation(); // Model <-> Dto
            ConfigureIdentity();
            ConfigurePeriod();
            ConfigureEntity();
            ConfigureSlot();
            ConfigureParameterValues();
            ConfigureCouponShare();
        }

        public void ConfigureBaseInfo()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Parameter, ParameterDto>().ReverseMap();
            //CreateMap<CompanyModel, CompanyDto>()
            //   .ForMember(c => c.FullAddress,opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

            //  CreateMap<CompanyForCreationDto, CompanyModel>();//.ForMember(c=>c.Id,opt=>opt.MapFrom(val=>new Guid()));
        }
        public void ConfigureSlot()
        {
            CreateMap<Slot, SlotDto>();
            CreateMap<Slot, SlotDto>().ReverseMap();
            //CreateMap<CompanyModel, CompanyDto>()
            //   .ForMember(c => c.FullAddress,opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

            //  CreateMap<CompanyForCreationDto, CompanyModel>();//.ForMember(c=>c.Id,opt=>opt.MapFrom(val=>new Guid()));
        }
        public void ConfigureRelation()
        {

            CreateMap<Relation, RelationDto>().ReverseMap();
            CreateMap<RelativeDto, Relatives>().ReverseMap();

            //  CreateMap<EmployeeModel, EmployeeDto>().ReverseMap();
            // CreateMap<EmployeeModel,EmployeeForCreationDto>().ReverseMap();
            // CreateMap<EmployeeModel,EmployeeForUpdateDto>().ReverseMap();

        }

        public void ConfigureIdentity()
        {
            CreateMap<UserForRegistrationDto, User>();
        }

        public void ConfigurePeriod()
        {
            CreateMap<Period, PeriodDto>().ReverseMap();
        }
        public void ConfigureCouponShare()
        {
            CreateMap<CouponShare, CouponShareDto>().ReverseMap();
        }
        public void ConfigureEntity()
        {
            CreateMap<Entity, EntityDto>();
            CreateMap<Entity, EntityDto>().ReverseMap();
        }

        public void ConfigureParameterValues()
        {
            CreateMap<ParameterValues, ParameterValuesDto>();
            CreateMap<ParameterValues, ParameterValuesDto>().ReverseMap();
        }

    }

}
