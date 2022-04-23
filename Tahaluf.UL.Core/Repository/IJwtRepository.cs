using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.DTO;

namespace Tahaluf.UL.Core.Repository
{
    public interface IJwtRepository
    { 
        Loginul Auth(Loginul loginul);
        List<LateFeesEmail> SendEmailForLateFees();  
    }
} 