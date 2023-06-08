using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D.JeitoCerto.Interfaces
{
    public interface IEmailService
    {
        public bool ValidarEmail(string email);
        public void EnviarEmail(string email);
    }
}
