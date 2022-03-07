using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class LoginService: ILoginService
    {
        private readonly ILoginRepository loginRepository;

        public LoginService(ILoginRepository _loginRepository)
        {
            loginRepository = _loginRepository;
        }


        public List<Loginul> GetAllLogins()
        {
            return loginRepository.GetAllLogins();
        }


        public bool CreateLogin(Loginul loginul)
        {
            return loginRepository.CreateLogin(loginul);
        }


        public bool UpdateLogin(Loginul loginul)
        {
            return loginRepository.UpdateLogin(loginul);
        }

        public string DeleteLogin(int id)
        {
            return loginRepository.DeleteLogin(id);
        }

    }
}
