using System;

namespace MeuProjeto.Problema3
{
    public class Program
    {
        static void Main(string[] args)
        {            
            double valorPresente;
            double taxaJuros;
            double periodoAnos;
            double rendimentoTotal;

            
            Console.Write("Digite o Valor Presente: ");
            
            valorPresente = double.Parse(Console.ReadLine()!); 

            Console.Write("Digite a Taxa de Juros em %: ");
            taxaJuros = double.Parse(Console.ReadLine()!);

            Console.Write("Digite o Período em anos: ");
            periodoAnos = double.Parse(Console.ReadLine()!);
            double i = taxaJuros / 100;

            rendimentoTotal = valorPresente * Math.Pow((1 + i), periodoAnos);

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("O rendimento calculado é: R$ " + rendimentoTotal.ToString("F2"));
            Console.WriteLine("---------------------------------------------");

            Console.ReadLine();
        }
    }
}