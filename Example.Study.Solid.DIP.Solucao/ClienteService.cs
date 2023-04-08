using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using Example.Study.Solid.DIP.Solucao.interfaces;

namespace Example.Study.Solid.DIP.Solucao
{
    public class ClienteService : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailServices _emailServices;

        public ClienteService(IClienteRepository clienteRepository, IEmailServices emailServices)
        {
            _clienteRepository = clienteRepository;
            _emailServices = emailServices;

        }
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            _clienteRepository.AdicionarCliente(cliente);

            _emailServices.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem vindo.", "Parabéns! Você está cadastrado.");

            return "Cliente cadastrado com sucesso!";
        }
    }
}
