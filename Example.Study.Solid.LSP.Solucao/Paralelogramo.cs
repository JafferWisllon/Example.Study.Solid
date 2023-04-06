namespace Example.Study.Solid.LSP.Solucao
{
    public abstract class Paralelogramo
    {
        public int Altura { get; set; }
        public int Largura { get; set; }
        protected Paralelogramo(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }
        public double Area { get { return Altura * Largura;  } }
    }
}