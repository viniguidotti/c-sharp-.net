﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_.NET.EstruturaControle
{
    class Switch
    {
        public static void Exec()
        {
            Console.WriteLine("Digita a nota do atendimento: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Ótimo");
                    break;
                default:
                    Console.WriteLine("Nota inválida");
                    break;
            }

            Console.WriteLine("Obrigado por responder!");
        }
    }
}
