using SOLID.O.JeitoErrado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O.JeitoCorreto
{
    // Essa classe está fechada para ser modificada
    // Ou seja ninguem vai modificar ela para criar um novo tipo de carro
    // Mas está aberta para ser extendida para que outras classes dos seus proprios tipos, criem um carro

    public abstract class FabriaCarroCerto
    {
        public abstract void CriarUmCarro(CarroOpen carro);
    }
}
