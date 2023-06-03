using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L.JeitoCerto
{
    public abstract class AviaoBase
    {
        public double Comprimento { get; set; }
        public double Altura { get; set; }
        public double QuantidadeDeCombustivel { get; set; }
        public abstract string LevantarVoo(double quantidadeDeCombustivel);
    }
}
