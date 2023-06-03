using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I.JeitoErrado
{
    internal interface IPagamento
    {
        public void Pagar();
        public void ValidarCartao();
    }
}
