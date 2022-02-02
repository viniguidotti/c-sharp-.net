using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CSharp_.NET.Concepts
{
    class FormatandoNumero
    {
        public static void Exec() {
            double valor = 15.175;
            //arredondamento = 1 casa decimal
            Console.WriteLine(valor.ToString("F1"));
            //c = currency (moeda)
            Console.WriteLine(valor.ToString("C"));
            //p = percentual
            Console.WriteLine(valor.ToString("P"));
            //formatação casa decimal
            Console.WriteLine(valor.ToString("#.##"));
            //formatação pela cultura
            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura));
            //adição de 0 a direita
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}