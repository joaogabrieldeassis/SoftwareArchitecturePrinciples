using SOLID.L.JeitoCerto;
using SOLID.L.JeitoErrado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public class TestarAvião
    {
        public void Teste()
        {
            var jeitoErrado = new AviaoDeBrinquedo
            {
                Altura = 20,
                Comprimento = 29,

                //Um avião de brinquedo normalmente não utiliza combustivel para voar, mas sim bateria
                // Furei o LSP um aviçao de brinquedo não é um avião
                QuantidadeDeCombustivel = 0
            };

            // Um avião ajato utiliza combustivel para levantar voo
            // Ele substitui um avião
            var jeitoCerto = new AviaoAjato
            {
                Altura = 100.00,
                Comprimento = 10,
                QuantidadeDeCombustivel = 200
            };
        }
    }
}
