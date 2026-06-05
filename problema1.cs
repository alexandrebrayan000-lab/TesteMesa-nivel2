using System;

namespace MeuProjeto.Problema1
{
    public class Program
    {
         static void Main(string[] args)
          {
            double valorPresente= 1000.0; 
            double taxaJuros = 5.30/100;
            int periodo = 6; 

            double valorFuturo = valorPresente * Math.Pow(1 + taxaJuros, periodo);
            Console.WriteLine("Valor Presente | Taxa de Juros | Período | Valor Futuro");
            Console.WriteLine("-------------- | ------------- | ------- | ------------");
            Console.WriteLine($"R$ {valorPresente:F2} | {taxaJuros*100:F2}% | {periodo} | R$ {valorFuturo:F2}");
            Console.ReadLine();
          }
    }
}