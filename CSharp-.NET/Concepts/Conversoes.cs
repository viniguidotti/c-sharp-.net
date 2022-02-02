using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_.NET.Concepts
{
    class Conversoes
    {
        public static void Exec()
        {
            int inteiro = 10;
            double quebrado;
            quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine(notaTruncada);

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.WriteLine("Digite um número: ");
            string palavra = Console.ReadLine();

            //int numero;
            int.TryParse(palavra, out int numero);
            Console.WriteLine("Resultado: {0}", numero);
        }
    }
}
