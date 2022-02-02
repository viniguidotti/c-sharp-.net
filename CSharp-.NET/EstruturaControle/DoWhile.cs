using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_.NET.EstruturaControle
{
    class DoWhile
    {
        public static void Exec()
        {
            string entrada;
            do
            {
                Console.WriteLine("Digite seu nome: ");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem vindo(a) {0}", entrada);
                Console.WriteLine("Deseja continuar? (S/N)");
                entrada = Console.ReadLine();

            } while (entrada.ToLower() == "s");
        }
    }
}
