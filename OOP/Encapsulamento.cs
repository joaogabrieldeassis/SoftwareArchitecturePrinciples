using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Publica
    {
        public void MetodoPublico() { }
        private void MetodoPrivado() { }
        protected void MetodoProtegido() { }
        internal void MetodoInterno() { }
        private protected void PrivadoProtegido() { }
        protected internal void PrivadoInterno() { }
    }    
    class Privada
    {
        public void MetodoPublico() { }
        private void MetodoPrivado() { }
        protected void MetodoProtegido() { }
        internal void MetodoInterno() { }
        private protected void PrivadoProtegido() { }
        protected internal void PrivadoInterno() { }
    }
    public sealed class Selada
    {
        public void MetodoPublico() { }
        private void MetodoPrivado() { }
        protected void MetodoProtegido() { }
        internal void MetodoInterno() { }
        private protected void PrivadoProtegido() { }
        protected internal void PrivadoInterno() { }
    }
    internal class Interna
    {
        public void MetodoPublico() { }
        private void MetodoPrivado() { }
        protected void MetodoProtegido() { }
        internal void MetodoInterno() { }
        private protected void PrivadoProtegido() { }
        protected internal void PrivadoInterno() { }
    }
    public class TestePublica : Publica
    {
        public void TestarPublica()
        {
            //MetodoPrivado();
            MetodoPublico();
            MetodoInterno();
            PrivadoInterno();
            MetodoProtegido();
            PrivadoProtegido();
            PrivadoInterno();
        }
    }
    public class TestePrivada
    {
        public void TestarPrivada()
        {
            var privado = new Privada();
            privado.MetodoPublico();
            privado.MetodoInterno();
            privado.PrivadoInterno();           
        }
    }
    public class TestarSelada 
    {
        public void TestarClasseSelada()
        {
            var privado = new Selada();
            privado.MetodoPublico();
            privado.MetodoInterno();
            privado.PrivadoInterno();
        }
    }
}
