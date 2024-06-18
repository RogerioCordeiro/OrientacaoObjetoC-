using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioIMC
{
    internal class Pessoa
    {
        // Atributos
        public string? nome;
        public double peso,  altura;

        // Metodos
        public double calculoImc()
        {
            return Math.Round((peso / (altura * altura)), 2);
        }

        public string grauIMC(double indice)
        {
            // < 18.5 - Abaixo do peso
            // < 25 - Peso normal
            // < 30 - Acima do peso
            // < 35 -Obesidade I
            // < 40 - Obesidade II
            // >= 40 - Obesidade III

            if (indice < 18.5)
            {
                return "Abaixo do peso";
            }else if(indice < 25)
            {
                return "Peso normal";
            }else if (indice < 30)
            {
                return "Acima do peso";
            }else if (indice < 35)
            {
                return "Obesidade I";
            }else if(indice < 40)
            {
                return "Obesidade II";
            }
            else
            {
                return "Obesidade III";
            }
        }

        public void mensagem()
        {
            double massa = calculoImc();
            string nivel = grauIMC(massa);
            Console.WriteLine($"{nome} possui o IMC de {massa} com grau {nivel}!");
        }
    }
}
