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
        public bool SendEmail([FromBody] Email email)
        {
            return jwtService.SendEmail(email);
        }

    }
}
