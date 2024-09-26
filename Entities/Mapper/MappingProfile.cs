using AutoMapper;
using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Internal;
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
            ConfigureObjectState();
            ConfigureReservations();
            ConfigureComapnay();
            ConfigureDefinitions();
 
        }

        public void ConfigureReservations()
        {
            CreateMap<Internal_ReservationDto,ReservationDto>();
            CreateMap<ReservationDto, Internal_ReservationDto>();

            CreateMap<ReservationDto, Reservation>().ReverseMap();


            CreateMap<Internal_TransactionDto, Tx_CouponDto>();
            CreateMap<Tx_CouponDto,Internal_ReservationDto>();
            CreateMap<Tx_CouponDto, Tx_Coupon>().ReverseMap();



            CreateMap<Internal_TransactionDto, Tx_UserDto>();
            CreateMap<Tx_UserDto, Internal_ReservationDto>();
            CreateMap<Tx_UserDto, Tx_User>().ReverseMap();

        }
        public void ConfigureObjectState()
        {
            CreateMap<ObjectStateDto, ObjectStates>().ReverseMap();
           

        }
        public void ConfigureBaseInfo()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Parameter, ParameterDto>().ReverseMap();

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
            CreateMap<Relatives, RelativeOfUserDto>().ForMember(dst=>dst.RelationTitle,opt=>opt.MapFrom(src=>src.Relation.Title));
            ConfigureInternalToExternal();

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
        public void ConfigureComapnay()
        {
            CreateMap<Company, CompanyDto>().ReverseMap();
            CreateMap<UserCompany,UserCompanyDto>().ReverseMap();
        }

        public void ConfigureParameterValues()
        {
            CreateMap<ParameterValues, ParameterValuesDto>();
            CreateMap<ParameterValues, ParameterValuesDto>().ReverseMap();
        }

        public void ConfigureDefinitions()
        {
            CreateMap<Definitions, DefinitionsDto>();
            CreateMap<Definitions, DefinitionsDto>().ReverseMap();
        }


        public void ConfigureInternalToExternal()
        {
            CreateMap<Internal_ReservationDto, TemporaryReservationBillDto>();
            CreateMap<TemporaryShareDto,Internal_ShareDto>().ReverseMap();
        }
    }

}
