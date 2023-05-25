using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class A
    {
        public abstract void Oi();
    }
    public class B : A
    {
        public override void Oi()
        {
            throw new NotImplementedException();
        }
    }
    public record Pessoa(string Name);

    public interface IRepository<T>
    {
        void Adicionar(T entity);
        void Excluir(T entity);
    }
    public interface IRepositoryPessoa<Pessoa>
    {
        void Adicionar(Pessoa entity);
    }

    public class Repository<T> : IRepository<T>
    {
        public void Adicionar(T entity)
        {
        }

        public void Excluir(T entity)
        {
        }
    }

    // Aqui eu estou implementando o repositorio
    // E também utilizando a herança que vai me gerar um forte acoplamento

    public class UtilizandoHeranca : Repository<Pessoa>, IRepositoryPessoa<Pessoa>
    {
    }

    //Utilizando a composicao que vai me gerar uma coesao muito maior
    public class UtilizandoComposicao : IRepositoryPessoa<Pessoa>
    {
        private readonly IRepository<Pessoa> _repository;

        public UtilizandoComposicao(IRepository<Pessoa> repository)
        {
            _repository = repository;
        }

        public void Adicionar(Pessoa entity)
        {
            _repository.Adicionar(entity);
        }
    }
}
