using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.IService
{
    public interface IReservationStateService
    {
        Task<bool> GoToNextStep(Guid ReservationId);
        Task<bool> GoToPreviousStep(Guid ReservationId);
        Task<bool> CancelObject(Guid ReservationId, Guid ObjectStateId);

    }
}
