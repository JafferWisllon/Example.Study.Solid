namespace Example.Study.Solid.ISP.Violacao
{
    public class CadastroCliente : ICadastro
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
