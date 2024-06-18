namespace Acesso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            produto1.nome = "Tablet";
            Console.WriteLine(produto1.nome);
        }
    }
}
