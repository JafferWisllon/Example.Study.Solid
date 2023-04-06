namespace Example.Study.Solid.OCP.Solucao
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Debitar Conta Corrente
            return FormatarTransacao();
        }
    }
}
