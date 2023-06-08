using SOLID.D.JeitoCerto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D.JeitoErrado
{
    public class EmailService : IEmailService
    {
        public void EnviarEmail(string email)
        {
           //Envia o email 
        }

        public bool ValidarEmail(string email)
        {
            if(!string.IsNullOrEmpty(email) && email.Contains('@')) return true;
            return false;
        }
    }
}
