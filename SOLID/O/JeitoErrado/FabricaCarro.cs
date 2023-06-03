using SOLID.S.RespeitandoSingle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O.JeitoErrado
{
    // Além de ser só um exemplo esse é o jeito errado de aplicar o OPEN CLOSED PRINCIPLE

    public class FabricaCarro
    {
        public void CriarCarro(CarroOpen carro)
        {             
            if (TipoDoCarro.Citroen == carro.TipoDoCarro)
            {
                // Crie um carro com as especificações de um citroen
            }
            if (TipoDoCarro.Sandero == carro.TipoDoCarro)
            {
                // Crie um carro com as especificações de um Sandero
            }
            if (TipoDoCarro.Pejo == carro.TipoDoCarro)
            {
                // Crie um carro com as especificações de um Pejo
            }
        }
    }
    public class CarroOpen
    {
        public TipoDoCarro TipoDoCarro { get; set; }
    }
}
