using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWT
{
    public class JWTService
    {
        private string secret;
        private string expDate;

        public JWTService(IConfiguration config)
        {
            secret = config.GetSection("JwtConfig").GetSection("secret").Value;
            expDate = config.GetSection("JwtConfig").GetSection("expirationInMinutes").Value;
        }

        public string GenerateSecurityToken(string email)
        {
            JwtSecurityTokenHandler jwt = new();
            byte[] key = Encoding.ASCII.GetBytes(secret);
            SecurityTokenDescriptor tokenDescriptor = new();
            ClaimsIdentity identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Email, email)
            });
            tokenDescriptor.Subject = identity;
            tokenDescriptor.Expires = DateTime.UtcNow.AddMinutes(double.Parse(expDate));
            tokenDescriptor.SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);
            SecurityToken sec = jwt.CreateToken(tokenDescriptor);
            return jwt.WriteToken(sec);
        }
    }
}