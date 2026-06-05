using System;

namespace MeuProjeto.Problema5
{
    public class Program
    {
         static void Main(string[] args)
          {
            double valorFuturo= 7390.61;
            double taxaJuros= 1.25;
            int periodoMeses= 24;

            double valorPresente= valorFuturo / Math.Pow(1 + taxaJuros / 100, periodoMeses);

            Console.WriteLine($"O valor presente é: R$ {valorPresente:F2}");

            Console.ReadLine();
          }
    }
}