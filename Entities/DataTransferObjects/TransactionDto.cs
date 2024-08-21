using Entities.Enum;

namespace Entities.DataTransferObjects
{
    public class TransactionDto
    {
        public Guid? Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public PayServiceType ServiceType { get; set; }
        public string refId { get; set; }
        public PayStatusType Status { get; set; }
        public Decimal amount { get; set; }

    }


    public class TransactionInfoDto
    {
        public Guid? Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ServiceType { get; set; }
        public string Status { get; set; }
        public Decimal Amount { get; set; }
        public Decimal BillAmount { get; set; }

        


    }
}