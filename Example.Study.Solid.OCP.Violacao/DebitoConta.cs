namespace Example.Study.Solid.OCP.Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if(tipoConta == TipoConta.Corrente)
            {
                // Debitar Conta Corrente
            }

            if(tipoConta == TipoConta.Poupanca) 
            { 
                // Validar Aniversario conta
                // Debita Conta Poupança
            }
        }
    }
}