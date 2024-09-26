using System.ComponentModel.DataAnnotations;


namespace Entities.DataTransferObjects;

public record UserForAuthenticationDto
{
    [Required(ErrorMessage = "Phone Number is required")]
    public string? PhoneNumber { get; init; }
    public string IdentityCode { get; init; }
    public string Password { get; init; }
    public string code { get; init; }
}
