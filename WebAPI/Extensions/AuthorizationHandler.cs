using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Extensions
{
    public class AuthorizationHandler : IAuthorizationHandler
    {
        public Task HandleAsync(AuthorizationHandlerContext context)
        {
            var t = string.Join(" ",context.FailureReasons);
            
            return Task.CompletedTask;
        }
    }
}
