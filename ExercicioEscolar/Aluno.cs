using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEscolar
{
    internal class Aluno
    {
        // Atributos
        public string? nome;
        public double nota1, nota2;

        // Média
        public double Media()
        {
            return (nota1 + nota2) / 2;
        }
        // Situação
        public static string Situacao(double media)
        {
            return media >= 7 ? "aprovado" : "reprovado";
        }

        // Mensagem
        public void Mensagem()
        {
            // Obter a média
            double obterMedia = Media();
            // Obter a situacao
            string obterSituacao = Situacao(obterMedia);
            // Mensagem
            Console.WriteLine($"{nome} está {obterSituacao} com média {obterMedia}!");

        }
    }
}
