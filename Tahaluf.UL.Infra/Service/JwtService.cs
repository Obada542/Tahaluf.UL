using MailKit.Net.Smtp;
using Microsoft.IdentityModel.Tokens;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.DTO;
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
        public bool SendEmailForLateFees(Email email)
        {
            var users = jwtRepository.SendEmailForLateFees();
            if (users == null)
            {
                return false;
            }
            foreach (var user in users)
            {
                MimeMessage message = new MimeMessage();

                //Sender --> From
                MailboxAddress from = new MailboxAddress("Library fees", email.EmailFrom);

                //Receiver -->To
                MailboxAddress to = new MailboxAddress("User", user.Email);

                message.From.Add(from);
                message.To.Add(to);

                //Subject
                message.Subject = "Late Payment Fee";

                BodyBuilder body = new BodyBuilder
                {
                    HtmlBody = $"<small>{DateTime.Now.ToString("dddd, dd MMMM yyyy")}</small><hr>"+ $" <h3> Dear {user.Name}, </h3> " 
                    + $"<p> We have contacted you about the <b>{user.Book_Name}</b> book you borrowed in <b>{user.Start_Date:MM/dd/yyyy}</b> and which was supposed to be returned in <b>{user.End_Date:MM/dd/yyyy}</b> and has not been returned until this moment </p>" + 
                    $"<br><p>Therefore, you were fined <b>{user.Discount}</b> JD on each day, knowing that the fines for the book until this moment are <b>{user.Fines}</b> JD.</p>" +
                    "<br><p>Please take the initiative to pay the amount you owe.</p>" +
                    "Best Regards,"
                };

                message.Body = body.ToMessageBody();

                //body.TextBody="Some plainText"

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, false); //host for emails i want to send
                    client.Authenticate(email.EmailFrom, email.Password);
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            
            return true;
        }
        public bool SendEmail(Email email)
        {
            //Message
            MimeMessage message = new MimeMessage();

            //Sender --> From
            MailboxAddress from = new MailboxAddress("Tahaluf Al-Emarat", email.EmailFrom);

            //Receiver -->To
            MailboxAddress to = new MailboxAddress("User", email.EmailTo);

            message.From.Add(from);
            message.To.Add(to);

            //Subject
            message.Subject = "Final Project Evaluation Details";

            BodyBuilder body = new BodyBuilder
            {
                HtmlBody = " <p> Dear Trainees, </p> " + "<h3> Final Project </h3>" + "Regards"
            };

            message.Body = body.ToMessageBody();

            //body.TextBody="Some plainText"

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false); //host for emails i want to send
                client.Authenticate(email.EmailFrom, email.Password);
                client.Send(message);
                client.Disconnect(true);
            }
            return true;
        }

        public string Auth(Loginul loginul)
        {
            var result = jwtRepository.Auth(loginul);
            if (result == null) return null;
            else
            {
                var TokenHandler = new JwtSecurityTokenHandler(); 
                var TokenKey = Encoding.UTF8.GetBytes("SECRET USED TO SIGN AND VERIFY JWT TOKEN");
                string role = "Accountant"; 
                if(result.Role_Id == 1)
                {
                    role = "Admin"; 
                }
                if (result.Role_Id == 2)
                {
                    role = "Student";
                }
                var TokenDescriptor = new SecurityTokenDescriptor 
                {  
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, result.Username,ClaimValueTypes.String),
                        new Claim (ClaimTypes.Role, role,ClaimValueTypes.String),
                        new Claim (ClaimTypes.SerialNumber, result.Id.ToString(),ClaimValueTypes.Sid),
                        new Claim (ClaimTypes.Email,result.Email,ClaimValueTypes.Email),
                        new Claim (ClaimTypes.MobilePhone,result.Phone,ClaimValueTypes.String),
                        new Claim (ClaimTypes.DateOfBirth,result.Birthday.ToString(),ClaimValueTypes.DateTime),
                        new Claim (ClaimTypes.Hash,result.Password,ClaimValueTypes.String)

                    }),

                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(TokenKey), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = TokenHandler.CreateToken(TokenDescriptor);
                return TokenHandler.WriteToken(token);
            }
        }
    }
}
