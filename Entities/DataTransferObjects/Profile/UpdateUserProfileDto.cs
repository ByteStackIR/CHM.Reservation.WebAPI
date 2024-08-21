using Entities.Enum;
using System.ComponentModel.DataAnnotations;


namespace Entities.DataTransferObjects;
public record UpdateUserProfileDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [Required(ErrorMessage = "Username is required")]
    public string UserName { get; set; }
    public string? Email { get; set; }
    public string PhoneNumber { get; set; }


    public ICollection<string>? Roles { get; set; }
}
