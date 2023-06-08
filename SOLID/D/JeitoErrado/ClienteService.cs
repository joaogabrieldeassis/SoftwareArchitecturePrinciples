using SOLID.D.JeitoCerto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D.JeitoErrado
{
    public class ClienteService
    {


        public ClienteService()
        {
        }

        public string AdicionarCliente(string cliente)
        {
            //Aqui estou dependendo da implementação e não abstração
            var clienteRepository = new ClienteRepository();
            var emailService = new EmailService();

            string emailCliente = "Algum email ai";

            if (!string.IsNullOrEmpty(cliente))
            {
                clienteRepository.Adicionar();

                if (emailService.ValidarEmail(emailCliente))

                    emailService.EnviarEmail(emailCliente);

                else
                    return "Não foi possivel enviar o email";
            }
            else
                return "Não foi possivel adicionar o cliente";

            return "Cliente adicionado com sucesso";

        }
    }
}
