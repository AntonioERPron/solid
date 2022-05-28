namespace EP.SOLID.LSP.Solucao
{
    public class Retangulo : Paralelogramo
    {
        public Retangulo(int altura, int largura) :base(altura,largura)
        {
            if(largura == altura)
                throw new ArgumentException("Os dois lados do quadrado precisam ser iguais");
        }
    }
}