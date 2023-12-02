using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace AuthenticationService.Models
{
    public sealed class JWT : IAuth
    {
        public int ExpireMinutes { set; get; } = 120; //2 Hours for testing purposes
        public string SecretKey { set; get; } = "TW9zaGVFcmV6UHJpdmF0ZUtleQ=="; // This secret key should be moved to some configurations outter server.
        public string SecurityAlgorithm { set; get; } = SecurityAlgorithms.HmacSha256Signature;

        public Claim[] Claims { set; get; }
    }
}
