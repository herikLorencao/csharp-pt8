using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparadores;
using System;
using System.Collections.Generic;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(164, 496979),
                new ContaCorrente(174, 920050),
                new ContaCorrente(124, 125668),
                new ContaCorrente(154, 215896),
                new ContaCorrente(114, 469709)
            };

            contas.Sort(new ComparadorContaCorrentePorAgencia());

            foreach (var conta in contas)
            {
                Console.WriteLine($"Número: {conta.Numero} | Agência: {conta.Agencia}");
            }

            Console.WriteLine("A execução do programa foi finalizada, tecle enter para finalizar ...");
            Console.ReadLine();
        }

        private static void TestaSortTipoPrimitivo()
        {
            var idades = new List<int>();
            idades.AdicionarVarios(10, 20, 12);
            idades.Sort();
            idades.Imprimir();

            var nomes = new List<string>();
            nomes.Add("Maria");
            nomes.Add("Ana");
            nomes.Sort();
            nomes.Imprimir();
        }
    }
}
