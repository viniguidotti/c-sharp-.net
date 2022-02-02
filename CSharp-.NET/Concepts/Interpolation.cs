using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_.NET.Concepts
{
    class Interpolation
    {
        public static void Exec()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5900.00;

            Console.WriteLine("O " + nome + " da marca " 
                + marca + " custa " + preco + ".");

            Console.WriteLine("O {0} da marca {1} custa {2}.",
                nome, marca, preco);
            Console.WriteLine($"A marca {marca} é legal!");
            Console.WriteLine($"1 + 1 é {1 + 1}!");
        }
    }
}
