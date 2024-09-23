using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IRepository
{
    public interface IRepositoryManager
    {

        ITransactionRepository ITransactionRepository { get; }
        IDefinitionsRepository IDefinitionsRepository { get; }

        ICategoryRepository Category { get; }
        ICompanyRepository Company { get; }
        ICouponShareRepository CouponShare { get; }
        IEntityManagerRepository EntityManager { get; }
        IEntityRepository Entity { get; }
        IObjectStatesRepository ObjectStates { get; }
        IParameterRepository Parameter { get; }
        IParameterValuesRepository ParameterValues { get; }
        IPeriodRepository Period { get; }
        IRelationRepository Relation { get; }
        IRelativesRepository Relatives { get; }
        IReservationRepository Reservation { get; }
        IReservationStatesRepository ReservationStates { get; }
        ISelectedRelativesRepository SelectedRelatives { get; }
        ISlotRepository Slot { get; }
        ITx_CouponRepository Tx_Coupon { get; }
        ITx_UserRepository Tx_User { get; }
        IUserCompanyRepository UserCompany { get; }
        IAttachmentsRepository AttachmentsRepository {  get; }
        void Save();
    }
}
