namespace Example.Study.Solid.LSP.Solucao
{
    public static class CalculoArea
    {
        public static void ObterAreaParalelogramo(Paralelogramo paral)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Paralelogramo");
            Console.WriteLine();
            Console.WriteLine(paral.Altura + " * " + paral.Largura);
            Console.WriteLine();
            Console.WriteLine(paral.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quad = new Quadrado(10, 5);
            var ret = new Retangulo(10, 5);

            ObterAreaParalelogramo(quad);
        }
    }
}
