using Otc.AuthorizationContext.Abstractions;

namespace TestNodeModulesProject.Models
{
    public class AuthorizationData : IAuthorizationData
    {
        public string UserId { get; set; }

        public string MyCustomAuthData { get; set; }
    }
}
