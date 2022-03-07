using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.DTO;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JwtController : ControllerBase
    {
        private readonly IJwtService jwtService;

        public JwtController(IJwtService _jwtService)
        {
            jwtService = _jwtService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Auth([FromBody] Loginul loginul)
        {


            var token = jwtService.Auth(loginul);
            if (token == null) return Unauthorized("UserName or password Incorrect");
            else { return Ok(token); }
        }




        [HttpPost]
        [Route("SendEmail")]
        public bool SendEmail([FromForm] Email email)
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

            BodyBuilder body = new BodyBuilder();
            body.HtmlBody = " <p> Dear Trainees, </p> " + "<h3> Final Project </h3>" + "Regards";

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

    }
}
