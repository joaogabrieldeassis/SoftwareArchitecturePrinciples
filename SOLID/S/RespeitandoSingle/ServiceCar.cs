using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S.RespeitandoSingle
{
    // É Apenas um exemplo
    internal class ServiceCar
    {
        public string Andar(Carro carro)
        {
            if (carro.QuantidadeDeGasolina > 0)
                return "Carro Andando";
            else
                return "Não foi possivel andar carro sem gasolina";
        }
        public bool ValidaAPlaca(Carro carro)
        {
            if (carro.Placa.Length >= 3 && carro.Placa == "Região do Brasil")
                return true;
            else
                return false;
        }
    }
}
