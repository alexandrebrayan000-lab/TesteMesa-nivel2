using System;

public static class problema3
{
    public static void Executar()
    {
        Console.WriteLine(">>> EXECUTANDO O PROBLEMA 3 <<<");
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

            Console.WriteLine();
            Console.WriteLine("Pressione 0 e ENTER para voltar ao menu principal");
            Console.ReadLine();
        }
    }
}