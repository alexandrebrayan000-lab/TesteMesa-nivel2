using System;

namespace MeuProjeto.Problema2
{
    public class Program
    {
        static void Main(string[] args)
        {
            double valorPresente = 3800.0;
            double taxaJuros = 1.25/100;
            double periodoMes = 6.0;

            double rendaAcumulada = 0.0;

            for (int loop = 1; loop <= periodoMes; loop++)
            {
                double rendimento= valorPresente* Math.Pow(1 +taxaJuros, loop);
                double rendimentoLiquido= rendimento - valorPresente;

                rendaAcumulada =rendaAcumulada + rendimentoLiquido;

                 Console.WriteLine($"---Loop a.m.: {loop} ---");
                Console.WriteLine($"Taxa de Juros: {taxaJuros*100:F2}%");
                Console.WriteLine($"Rendimento: R$ {rendimento:F2}");
                Console.WriteLine($"Renda Líquida: R$ {rendimentoLiquido:F2}");
                Console.WriteLine($"Renda Acumulada: R$ {rendaAcumulada+valorPresente:F2}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}