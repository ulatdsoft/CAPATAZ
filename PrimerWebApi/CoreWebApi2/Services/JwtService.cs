using System;
using System.Text;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;

namespace CoreWebApi2.Services
{
    public class JwtService
    {
        private readonly string _secret;
        private readonly string _expDate;

        public JwtService(IConfiguration config)
        {
            _secret = config.GetSection("JwtConfig").GetSection("secret").Value;
            _expDate = config.GetSection("JwtConfig").GetSection("expirationInMinutes").Value;
        }

        public string GenerateSecurityToken(string email)
        {
            //// Header
            //var key = Encoding.ASCII.GetBytes(_secret);
            //var _symmetricSecurityKey = new SymmetricSecurityKey(key);
            //var _signingCredentials = new SigningCredentials(_symmetricSecurityKey
            //    , SecurityAlgorithms.HmacSha256); // SecurityAlgorithms.HmacSha256Signature
            //var _Header = new JwtHeader(_signingCredentials);

            //// Claims
            //var _Claims = new[]
            //{
            //        new Claim(ClaimTypes.Email, email),
            //};


            //// Payload
            //var _Payload = new JwtPayload(
            //        issuer: "localhost",
            //        audience: "localhost",
            //        claims: _Claims,
            //        notBefore: DateTime.UtcNow,
            //        // Exipra a la 24 horas.
            //        expires: DateTime.UtcNow.AddHours(24)
            //    );

            //// Token
            //var _Token = new JwtSecurityToken(_Header, _Payload);

            //return new JwtSecurityTokenHandler().WriteToken(_Token);


            var key = Encoding.ASCII.GetBytes(_secret);
            var symmetricKey = new SymmetricSecurityKey(key);
            var signingCredentials = new SigningCredentials(symmetricKey
                , SecurityAlgorithms.HmacSha256Signature);


            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Email, email)
                }),
                Expires = DateTime.UtcNow.AddMinutes(double.Parse(_expDate)),
                SigningCredentials = signingCredentials,
                Issuer = "localhost",
                Audience = "localhost",
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);

        }
    }
}
