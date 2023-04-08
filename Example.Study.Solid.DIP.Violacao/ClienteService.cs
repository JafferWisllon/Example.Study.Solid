using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;

namespace Example.Study.Solid.DIP.Violacao
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailService.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem vindo.", "Parabéns! Você está cadastrado.");

            return "Cliente cadastrado com sucesso!";
        }
    }
}
