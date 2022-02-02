using System;
using System.Collections.Generic;
using CSharp_.NET.Concepts;
using CSharp_.NET.EstruturaControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", FirstConcept.Exec},
                {"Comentários - Fundamentos", Comments.Exec },
                {"Váriaveis e Constantes - Fundamentos", VariablesEConstants.Exec },
                {"Inferência - Fundamentos", Inferencia.Exec },
                {"Interpolação - Fundamentos", Interpolation.Exec },
                {"Notação Ponto - Fundamentos", NotationPoint.Exec },
                {"Lendo Dados - Fundamentos", LendoDados.Exec },
                {"Formatando Numeros - Fundamentos", FormatandoNumero.Exec },
                {"Conversões - Fundamentos", Conversoes.Exec },
                {"Operador Ternário - Fundamentos", OperadorTernario.Exec },
                {"Switch - Fundamentos", Switch.Exec },
                {"While - Fundamentos", While.Exec },

            });

            central.SelecionarEExecutar();
        }
    }
}