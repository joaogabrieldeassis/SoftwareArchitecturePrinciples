using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S.RespeitandoSingle
{
    // É Apenas um exemplo
    internal class VendaDoCarro
    {
        public void Vender(Carro car, int valorPago)
        {
            // É Apenas um exemplo o melhor nesse caso seria a DI
            var servicoDoCarro = new ServiceCar();

            if (servicoDoCarro.ValidaAPlaca(car))
            {
                if (car.Preço == valorPago)
                    Console.WriteLine("Realiza a venda");
                else
                    Console.WriteLine("Valor pago incorreto");
            }
        }
    }
}
