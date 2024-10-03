using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Entities.DataTransferObjects.Internal;
using Entities.DataTransferObjects.Models;
using Entities.Models;
using Microsoft.AspNetCore.Http;

namespace Entities.DataTransferObjects
{
    public class Response
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
    }

    public class KeyItemsDto<T>
        where T : class
    {
        public string ItemTitle { get; set; }
        public string ItemDescription { get; set; } = string.Empty;

        public List<T> Items { get; set; }
    }

    public class FileDto
    {
        public string Key { get; set; }
        public int DisplayOrder { get; set; }
        public string? FilePath { get; set; }
        public IFormFile? File { get; set; }
    }

    public class FilesDto
    {
        public List<FileDto> Files { get; set; }
    }

    public class UserRelativesDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string CompanyTitle { get; set; }

        public KeyItemsDto<RelativeDto> Relatives { get; set; }
    }

    public class UserRelativesCreationDto
    {
        public Guid UserId { get; set; }
        public List<RelativeDto> Relatives { get; set; }
    }

    public class ReservationCreationDto
    {
        public Guid UserId { get; set; }
        public Guid SlotId { get; set; }
        public List<Guid> Relatives { get; set; }
    }

    public class TemporaryReservationBillDto
    {
        public Guid SlotId { get; set; }
        public string UserId { get; set; }
        public Decimal Amount { get; set; }
        public Decimal BillAmount { get; set; }
        public Guid? ObjectStateId { get; set; }

        public Guid CategoryId { get; set; }
        public Guid EntityId { get; set; }
        public DateTime CreatedDate { get; set; }

        public List<TemporaryShareDto> Shares { get; set; }
    }

    public class TemporaryShareDto
    {
        public RelativeDto Relative { get; set; }
        public Decimal CompanyShare { get; set; }
        public Decimal UserShare { get; set; }
    }

    public class ManiuplateRelativeDto
    {
        public Guid? UserId { get; set; }

        public List<RelativeDto> Create { get; set; }
        public List<RelativeDto> Update { get; set; }
        public List<RelativeDto> Delete { get; set; }
    }
}
