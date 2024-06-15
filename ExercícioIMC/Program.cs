using System.IO;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExercícioIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Criar uma pasta chamada 04ExercicioIMC
            // 2) Acessar a pasta via terminal: cd 04ExercicioIMC
            // 3) Criar um projeto via terminal: dotnet new console
            // 4) Criar uma classe chamada Pessoa
            // 5) Na classe pessoa adicionar os atributos: peso e altura
            // 6) Criar um método para retornar o IMC, sera um método double com o cálculo: peso / (altura * altura)
            // 7) Criar um método para retornar um string dependendo do IMC:
            // < 18.5 - Abaixo do peso
            // < 25 - Peso normal
            // < 30 - Acima do peso
            // < 35 -Obesidade I
            // < 40 - Obesidade II
            // <= 40 - Obesidade III
            // 8) Criar um método de mensagem para exibir o cálculo e a situação
            // 9) Instânciar um objeto na classe Program

            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = "Capitão América";
            pessoa1.altura = 1.90;
            pessoa1.peso = 101;
            pessoa1.mensagem();
        }
    }
}
