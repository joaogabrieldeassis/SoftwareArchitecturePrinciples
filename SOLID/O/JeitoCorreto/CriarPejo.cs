using SOLID.O.JeitoErrado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O.JeitoCorreto
{
    public class CriarPejo : FabriaCarroCerto
    {
        public override void CriarUmCarro(CarroOpen carro)
        {
            // Cria o carro por que eu já sei que ele vai ser do tipo Pejo
        }
    }
}
