namespace Conceitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instanciar um objeto
            Pessoa pessoa1 = new Pessoa();

            pessoa1.nome = "Robson";
            pessoa1.idade = 30;
            pessoa1.mensagem();
        }
    }
}
