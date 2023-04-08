using Example.Study.Solid.ISP.Solucao.Interfaces;

namespace Example.Study.Solid.ISP.Solucao
{
    public class CadastroCliente : ICadastroCliente
    {
        public void EnviarEmail()
        {
            // Enviar email para o cliente
        }

        public void SalvarBanco()
        {
            // Insert na tabela Cliente
        }

        public void Validardados()
        {
            // Validar CPF, Email
        }
    }
}
