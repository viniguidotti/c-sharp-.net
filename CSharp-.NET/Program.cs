using System;
using System.Collections.Generic;
using CSharp_.NET.Concepts;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", FirstConcept.Exec},
                {"Comentários - Fundamentos", Comments.Exec },
                {"Váriaveis e Constantes - Fundamentos", VariablesEConstants.Exec },
                {"Inferência - Fundamentos", Inferencia.Exec },
            });

            central.SelecionarEExecutar();
        }
    }
}