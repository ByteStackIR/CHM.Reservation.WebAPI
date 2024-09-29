using Entities.Enum;
using System.ComponentModel.DataAnnotations;


namespace Entities.DataTransferObjects;
public record UserForRegistrationDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FatherName { get; set; }

    public string PhoneNumber { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public GenderType Gender { get; set; } 
    public DateTime BirthDate { get; set; }
    public string? UserId { get; set; }
    public string PersonnelCode { get; set; }
    public string IdentityCode { get; set; }
    public Guid CompanyId { get; set; }
    public List<string>? Roles { get; set; }



}
