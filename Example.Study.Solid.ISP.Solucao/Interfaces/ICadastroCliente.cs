namespace Example.Study.Solid.ISP.Solucao.Interfaces
{
    public interface ICadastroCliente : ICadastro
    {
        void Validardados();
        void EnviarEmail();
    }
}