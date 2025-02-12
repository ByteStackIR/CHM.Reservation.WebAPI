using Contracts.IMarker;
using Contracts.IRepository;
using Contracts.IRepository;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Repositories
{
    public sealed class RepositoryManager : IRepositoryManager, IScopeMarker
    {
        private readonly DBContextProvider _context;
        private IDbContextTransaction _ObjTransaction = null;


        private readonly Lazy<ITransactionRepository> _ITransactionRepository;
        private readonly Lazy<IDefinitionsRepository> _IDefinitionsRepository;
        private readonly Lazy<ITx_CreditRepository> _ITx_CreditRepository;

        private readonly Lazy<ICategoryRepository> _categoryRepository;
        private readonly Lazy<ICompanyRepository> _companyRepository;
        private readonly Lazy<ICouponShareRepository> _couponShareRepository;
        private readonly Lazy<IEntityManagerRepository> _entityManagerRepository;
        private readonly Lazy<IEntityRepository> _entityRepository;
        private readonly Lazy<IObjectStatesRepository> _objectStatesRepository;
        private readonly Lazy<IParameterRepository> _parameterRepository;
        private readonly Lazy<IParameterValuesRepository> _parameterValuesRepository;
        private readonly Lazy<IPeriodRepository> _periodRepository;
        private readonly Lazy<IRelationRepository> _relationRepository;
        private readonly Lazy<IRelativesRepository> _relativesRepository;
        private readonly Lazy<IReservationRepository> _reservationRepository;
        private readonly Lazy<IReservationStatesRepository> _reservationStatesRepository;
        private readonly Lazy<ISelectedRelativesRepository> _selectedRelativesRepository;
        private readonly Lazy<ISlotRepository> _slotRepository;
        private readonly Lazy<ITx_CouponRepository> _tx_CouponRepository;
        private readonly Lazy<ITx_UserRepository> _tx_UserRepository;
        private readonly Lazy<IUserCompanyRepository> _userCompanyRepository;
        private readonly Lazy<IAttachmentsRepository> _IAttachmentsRepository;

        public RepositoryManager(DBContextProvider context)
        {
            _context = context;

            _ITransactionRepository = new Lazy<ITransactionRepository>(() => new TransactionRepository(context));

            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(context));
            _companyRepository = new Lazy<ICompanyRepository>(() => new CompanyRepository(context));
            _couponShareRepository = new Lazy<ICouponShareRepository>(() => new CouponShareRepository(context));
            _entityManagerRepository = new Lazy<IEntityManagerRepository>(() => new EntityManagerRepository(context));
            _entityRepository = new Lazy<IEntityRepository>(() => new EntityRepository(context));
            _objectStatesRepository = new Lazy<IObjectStatesRepository>(() => new ObjectStatesRepository(context));
            _parameterRepository = new Lazy<IParameterRepository>(() => new ParameterRepository(context));
            _parameterValuesRepository = new Lazy<IParameterValuesRepository>(() => new ParameterValuesRepository(context));
            _periodRepository = new Lazy<IPeriodRepository>(() => new PeriodRepository(context));
            _IDefinitionsRepository = new Lazy<IDefinitionsRepository>(() => new DefinitionsRepository(context));

            _relationRepository = new Lazy<IRelationRepository>(() => new RelationRepository(context));
            _relativesRepository = new Lazy<IRelativesRepository>(() => new RelativesRepository(context));
            _reservationRepository = new Lazy<IReservationRepository>(() => new ReservationRepository(context));
            _reservationStatesRepository = new Lazy<IReservationStatesRepository>(() => new ReservationStatesRepository(context));
            _selectedRelativesRepository = new Lazy<ISelectedRelativesRepository>(() => new SelectedRelativesRepository(context));
            _slotRepository = new Lazy<ISlotRepository>(() => new SlotRepository(context));
            _tx_CouponRepository = new Lazy<ITx_CouponRepository>(() => new Tx_CouponRepository(context));
            _tx_UserRepository = new Lazy<ITx_UserRepository>(() => new Tx_UserRepository(context));
            _userCompanyRepository = new Lazy<IUserCompanyRepository>(() => new UserCompanyRepository(context));
            _IAttachmentsRepository = new Lazy<IAttachmentsRepository>(() => new AttachmentsRepository(context));
            _ITx_CreditRepository = new Lazy<ITx_CreditRepository>(() => new Tx_CreditRepository(_context));

        }

        public ITransactionRepository ITransactionRepository => _ITransactionRepository.Value;
        public IDefinitionsRepository IDefinitionsRepository => _IDefinitionsRepository.Value;

        public ICategoryRepository Category => _categoryRepository.Value;
        public ICompanyRepository Company => _companyRepository.Value;
        public ICouponShareRepository CouponShare => _couponShareRepository.Value;
        public IEntityManagerRepository EntityManager => _entityManagerRepository.Value;
        public IEntityRepository Entity => _entityRepository.Value;
        public IObjectStatesRepository ObjectStates => _objectStatesRepository.Value;
        public IParameterRepository Parameter => _parameterRepository.Value;
        public IParameterValuesRepository ParameterValues => _parameterValuesRepository.Value;
        public IPeriodRepository Period => _periodRepository.Value;
        public IRelationRepository Relation => _relationRepository.Value;
        public IRelativesRepository Relatives => _relativesRepository.Value;
        public IReservationRepository Reservation => _reservationRepository.Value;
        public IReservationStatesRepository ReservationStates => _reservationStatesRepository.Value;
        public ISelectedRelativesRepository SelectedRelatives => _selectedRelativesRepository.Value;
        public ISlotRepository Slot => _slotRepository.Value;
        public ITx_CouponRepository Tx_Coupon => _tx_CouponRepository.Value;
        public ITx_UserRepository Tx_User => _tx_UserRepository.Value;
        public IUserCompanyRepository UserCompany => _userCompanyRepository.Value;
        public IAttachmentsRepository AttachmentsRepository => _IAttachmentsRepository.Value;


        public ITx_CreditRepository Tx_Credit => _ITx_CreditRepository.Value;

        public void Save() => _context.SaveChanges();
        public void BeginTransaction()
        {
            if(_ObjTransaction is null)
                _ObjTransaction = _context.Database.BeginTransaction();


        }
        public async Task BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            if (_ObjTransaction is null)
                _ObjTransaction = await _context.Database.BeginTransactionAsync(cancellationToken);


        }

        public void Commit()
        {
            if (_ObjTransaction is not null)
                _context.Database.CommitTransaction();
            else
                throw new Exception("No Transaction");
        }
        public async Task CommitAsync(CancellationToken cancellationToken = default)
        {
            if (_ObjTransaction is not null)
                await _context.Database.CommitTransactionAsync(cancellationToken);
            else
                throw new Exception("No Transaction");
        }

        public void Rollback()
        {
            if (_ObjTransaction is not null)
                _context.Database.RollbackTransaction();
            else
                throw new Exception("No Transaction");
        }
        public async Task RollbackAsync(CancellationToken cancellationToken=default)
        {
            if (_ObjTransaction is not null)
                await _context.Database.RollbackTransactionAsync(cancellationToken);
            else
                throw new Exception("No Transaction");
        }

    }
}

