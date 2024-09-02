using Entities.Enum;
using System.ComponentModel.DataAnnotations;


namespace Entities.DataTransferObjects;
public record UserForRegistrationDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public GenderType Gender { get; set; } 
    public DateTime BrithDate { get; set; }
    public string UserId { get; set; }
    public string PersonnelCode { get; set; }
    public string IdentityCode { get; set; }
    public Guid CompanyId { get; set; }
    public string? Role { get; set; }
}
