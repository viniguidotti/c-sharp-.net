using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_.NET.Concepts
{
    class OperadorTernario
    {
        public static void Exec()
        {
            var nota = 7.0;
            string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
