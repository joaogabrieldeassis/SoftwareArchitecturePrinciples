using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S.FurandoS
{
    public class FurandoOPrincipio
    {
        public string Placa { get; set; }
        public int QuantidadeDePortas { get; set; }
        public int Ano { get; set; }
        public int QuantidadeDeGasolina { get; set; }
        public double Preço { get; set; }

        public string Andar()
        {
            if (QuantidadeDeGasolina > 0)
                return "Carro Andando";
            else
                return "Não foi possivel andar carro sem gasolina";
        }
        public bool ValidaAPlaca()
        {
            if (Placa.Length >= 3 && Placa == "Região do Brasil")
                return true;
            else
                return false;
        }
        public void Vender(int valorPago)
        {
            if (Preço == valorPago)
                Console.WriteLine("Realiza a venda");

            else
                Console.WriteLine("Valor pago incorreto");

        }
    }
}
