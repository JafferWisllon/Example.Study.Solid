namespace Example.Study.Solid.ISP.Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void EnviarEmail()
        {
            // Produto nao tem email, o que eu faço?
            throw new NotImplementedException("Esse metodo não pode ser chamado");
        }

        public void SalvarBanco()
        {
            // Insert na tabela Produto
        }

        public void Validardados()
        {
            // Validar valor
        }
    }
}
