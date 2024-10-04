
namespace Entities.DataTransferObjects.Models
{
    public class Tx_CreditDto
    {
        public Guid Id { get; set; }
        public Guid? ReservationId { get; set; }
        public Guid PeriodId { get; set; }
     
        public string UserId { get; set; }
        public string CreatorUserId { get; set; }
        public string Description { get; set; }
        public Decimal Amount { get; set; }
    
        public DateTime CreatedDate { get; set; }
    }
}
