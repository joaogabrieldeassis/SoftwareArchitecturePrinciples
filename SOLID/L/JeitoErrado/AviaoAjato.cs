using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L.JeitoErrado
{
    public class AviaoAjato : Aviao
    {
        public override string LevantarVoo(double quantidadeDeCombustivel)
        {
            if (quantidadeDeCombustivel > 100.90)
                return "Levantando voo";

            return "Não foi possivel levantar voo";
        }
    }
}
