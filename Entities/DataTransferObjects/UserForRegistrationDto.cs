using Entities.Enum;
using System.ComponentModel.DataAnnotations;


namespace Entities.DataTransferObjects;
public record UserForRegistrationDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [Required(ErrorMessage = "Username is required")]
    public string UserName { get; set; }
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }
    public string? Email { get; set; }
    public string PhoneNumber { get; set; }
    public GenderType Gender { get; set; } 
    public DateTime BrithDate { get; set; }
    public string UserId { get; set; }
    public string PersonnelCode { get; set; }
    public string IdentityCode { get; set; }
    public Guid CompanyId { get; set; }
    public ICollection<string>? Roles { get; set; }
}
