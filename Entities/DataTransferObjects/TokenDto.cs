using Entities.Models;

namespace Shared.DataTransferObjects;

public record UserInfo(string id, string firstName, string lastName, string phoneNumber, string userName);
public record TokenDto(string AccessToken, string RefreshToken, DateTime ExpireTime, UserInfo? user);
