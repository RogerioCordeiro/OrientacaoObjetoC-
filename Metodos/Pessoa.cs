using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Pessoa
    {
        // Método 01
        public void apresentar()
        {
            Console.WriteLine("Olá!!!");
        }
        // Método 02
        public void apresentar(string nome)
        {
            Console.WriteLine($"Olá {nome}!");
        }
        // Método 03
        public void apresentar(string nome, int idade)
        {
            Console.WriteLine($"Olá {nome} voê tem {idade} anos.");
        }
    }
}
