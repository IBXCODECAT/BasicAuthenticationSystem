using System;
using System.Linq;
using System.Security.Claims;
using System.Collections.Generic;
using AuthenticationService.Models;
using AuthenticationService.Managers;

namespace AuthenticationService
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            // Create JWT container with user information
            IAuth jwtAuth = GetJWT("Cool & Epic Name", "test@example.com");
            IAuthMethod jwtMethod = new JWTService(jwtAuth.SecretKey); // Initialize JWT service

            // Generate a token based on the provided container
            string token = jwtMethod.GenerateToken(jwtAuth);

            // Validate the generated token
            bool tokenValid = jwtMethod.ValidateToken(token);

            // If the token is valid, extract and display claims
            if (tokenValid)
            {
                List<Claim> claims = jwtMethod.GetTokenClaims(token).ToList();

                // Display user name and email from the claims
                Console.WriteLine(claims.FirstOrDefault(e => e.Type.Equals(ClaimTypes.Name)).Value);
                Console.WriteLine(claims.FirstOrDefault(e => e.Type.Equals(ClaimTypes.Email)).Value);
            }
            else
            {
                // Throw exception if token validation fails
                throw new UnauthorizedAccessException();
            }
        }

        // Helper method to create JWTContainer with claims
        private static JWT GetJWT(string name, string email)
        {
            return new JWT()
            {
                Claims = new Claim[]
                {
                    new Claim(ClaimTypes.Name, name),
                    new Claim(ClaimTypes.Email, email)
                }
            };
        }
    }
}
