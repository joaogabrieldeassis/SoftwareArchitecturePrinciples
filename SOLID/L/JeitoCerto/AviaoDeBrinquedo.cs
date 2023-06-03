using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L.JeitoCerto
{
    // Aqui já estaria errado por que um avião de brinquedo Normalmente não utilza gasolina para voar 

    public class AviaoDeBrinquedo : AviaoBase
    {
        //Aqui seria um método levantarVoo mas utilizando uma bateria 

        public override string LevantarVoo(double quantidadeDeCombustivel)
        {
            throw new NotImplementedException();
        }
    }
}
