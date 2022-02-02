using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_.NET.Concepts
{
    class LendoDados
    {
        public static void Exec() {
            Console.WriteLine("Qual seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu salário? ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"Seu nome {nome}, sua idade {idade} e seu salário {salario}");
        }
    }
}