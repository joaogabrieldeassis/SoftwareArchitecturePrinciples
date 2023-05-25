using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //Sempre devemos depender da abstração ao ives da implementação

    public class ClasseDeImplementação
    {
        public void Teste() { }
    }
    public interface IClasseDeAbstracao
    {
        public void Teste();
    }
    public class ClasseDeAbstracao : IClasseDeAbstracao
    {
        public void Teste()
        {
            //Faça algo
        }
    }
    public class QuandoEuDependoDaImplementacao
    {
        /*
         Aqui eu estou dependendo da implementacao, mas esse codigo esta fortemente acoplado, por que se crio um construtor na classe que instanciei
        esse meu codigo vai quebrar
        */
        public void Testando()
        {
            var classeDeImplementacao = new ClasseDeImplementação();
            classeDeImplementacao.Teste();
        }
    }
    public class QuandoEuDependoDaAbstracao
    {
        private readonly IClasseDeAbstracao _classeDeAbstracao;
        public QuandoEuDependoDaAbstracao(IClasseDeAbstracao classeDeAbstracao)
        {
            _classeDeAbstracao = classeDeAbstracao;
        }
        public void Testando()
        {
            _classeDeAbstracao.Teste(); 
        }
    }
}
