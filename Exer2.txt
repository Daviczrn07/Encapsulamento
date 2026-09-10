namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            //valor positivo
            produto.Preco = 150.50;
            Console.WriteLine($"Preço positivo atribuído: {produto.Preco}");

            //valor negativo
            produto.Preco = -45.00;
            Console.WriteLine($"Preço negativo atribuído: {produto.Preco}");
        }
    }
}
