using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class JwtService: IJwtService
    {
        private readonly IJwtRepository jwtRepository;

        public JwtService(IJwtRepository _jwtRepository)
        {
            jwtRepository = _jwtRepository;
        }



        public string Auth(Loginul loginul)
        {
            var result = jwtRepository.Auth(loginul);


            if (result == null) return null;
            else
            {
                //generate token
                //1.token handler -->
                var TokenHandler = new JwtSecurityTokenHandler();



                //2.Token Key --> The same as key in StartUp .
                var TokenKey = Encoding.UTF8.GetBytes("SECRET USED TO SIGN AND VERIFY JWT TOKEN");

                //3.Descripor --> Payload (in result) + prop (expired date for ex)
                var TokenDescriptor = new SecurityTokenDescriptor
                {
                    //Subject 
                    Subject = new ClaimsIdentity(new Claim[]
                    { 
                        //result.username
                        //new Claim (type,vlaue)
                        new Claim(ClaimTypes.Name, result.Username),
                        //result.rolename
                        new Claim (ClaimTypes.Role, result.Role.Role_Name)
                    }),

                    //Expires
                    Expires = DateTime.UtcNow.AddHours(1),

                    //Signing Credintials  // new SigningCredentials(key,algorithm)
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(TokenKey), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = TokenHandler.CreateToken(TokenDescriptor);
                return TokenHandler.WriteToken(token);
            }
        }
    }
}
