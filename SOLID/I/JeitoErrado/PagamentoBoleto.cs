using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I.JeitoErrado
{
    internal class PagamentoBoleto : IPagamento
    {
        public void Pagar()
        {
            throw new NotImplementedException();
        }

        // Furei o ISP
        public void ValidarCartao()
        {
            throw new NotImplementedException("Método não utilizado nesse meio de pagamento");
        }
    }
}
