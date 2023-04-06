namespace Example.Study.Solid.OCP.Solucao
{
    public class DebitoContaPoupanca : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Validar Aniversario conta
            // Debita Conta Poupança
            return FormatarTransacao();
        }
    }
}
