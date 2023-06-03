using SOLID.O.JeitoErrado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O.JeitoCorreto
{
    public class CriarFiat : FabriaCarroCerto
    {
        public override void CriarUmCarro(CarroOpen carro)
        {
            // Já sei que vai ser do tipo Fiat
        }
    }
}
