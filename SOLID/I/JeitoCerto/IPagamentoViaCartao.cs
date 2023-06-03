using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I.JeitoCerto
{
    // É melhor haver varias interfaces especificas do que uma unica interface
    internal interface IPagamentoViaCartao
    {
        public void ValidarCartao();
    }
}
