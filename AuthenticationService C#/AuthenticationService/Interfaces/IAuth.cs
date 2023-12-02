using System.Security.Claims;

namespace AuthenticationService.Models
{
    public interface IAuth
    {
        string SecretKey { get; set; }
        string SecurityAlgorithm { get; set; }
        int ExpireMinutes { get; set; }

        Claim[] Claims { get; set; }
    }
}
