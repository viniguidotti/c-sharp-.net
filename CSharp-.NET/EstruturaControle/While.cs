using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_.NET.EstruturaControle
{
    class While
    {
        public static void Exec()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            int tentativas = 0;
            int tentativasRestantes = 5;
            bool numeroEncontrado = false;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Digite o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (palpite == numeroSecreto)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Número encontrado em {0} tentativas!", tentativas);
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto)
                {
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Menor... tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                    Console.BackgroundColor = corAnterior;
                } else
                {
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Maior... tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                    Console.BackgroundColor = corAnterior;
                }
            }
        }
    }
}
