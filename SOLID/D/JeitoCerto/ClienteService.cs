using SOLID.D.JeitoCerto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D.JeitoCerto
{
    public class ClienteService
    {
        //Aqui estou dependendo da abstração e não implementação 

        private readonly IEmailService _emailService;
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IEmailService emailService, IClienteRepository clienteRepository)
        {
            _emailService = emailService;
            _clienteRepository = clienteRepository;
        }

        public string AdicionarCliente(string cliente)
        {
            string emailCliente = "Algum email ai";

            if (!string.IsNullOrEmpty(cliente))
            {
                _clienteRepository.Adicionar();

                if (_emailService.ValidarEmail(emailCliente))

                    _emailService.EnviarEmail(emailCliente);

                else
                    return "Não foi possivel enviar o email";
            }                
            else
                return "Não foi possivel adicionar o cliente";

            return "Cliente adicionado com sucesso";

        }
    }
}
