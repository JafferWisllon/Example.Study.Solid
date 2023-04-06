namespace Example.Study.Solid.OCP.Solucao
{
    public class ContaInvestimento : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Debito Conta Investimento
            // Isentar Taxas
            return FormatarTransacao();
        }
    }
}
