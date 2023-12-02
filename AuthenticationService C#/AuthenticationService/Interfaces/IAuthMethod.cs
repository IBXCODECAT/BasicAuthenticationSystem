using System.Security.Claims;
using System.Collections.Generic;
using AuthenticationService.Models;

namespace AuthenticationService.Managers
{
    /// <summary>
    /// This interface is to be implemented for each authentication method
    /// In this example, only JWT is implemented
    /// </summary>
    public interface IAuthMethod
    {
        /// <summary>
        /// Secret key for the authentication method
        /// </summary>
        string SecretKey { get; set; }

        bool ValidateToken(string token);

        string GenerateToken(IAuth model);

        IEnumerable<Claim> GetTokenClaims(string token);
    }
}
