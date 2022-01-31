using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_.NET.Concepts
{
    class NotationPoint
    {
        public static void Exec()
        {
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine($"{saudacao}");

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
