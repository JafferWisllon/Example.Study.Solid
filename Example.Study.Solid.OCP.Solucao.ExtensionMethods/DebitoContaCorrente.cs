namespace Example.Study.Solid.OCP.Solucao.ExtensionMethods
{
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            // Logica de negócio para debito em conta corrente.
            return debitoConta.FormatarTransacao();
        }
    }
}
