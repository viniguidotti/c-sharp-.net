using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_.NET.Concepts
{
    class Inferencia
    {
        public static void Exec()
        {
            var nome = "Vinicius";
            Console.WriteLine("Nome " + nome);

            //Na inferência, o valor deve ser atribuido desde o momento de sua inicialização;
            //var idade;
            //idade = 22;

            var idade = 22;
            Console.WriteLine("Idade " + idade);
        }
    }
}
