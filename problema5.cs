using System;

public static class problema5
{
    public static void Executar()
    {
        Console.WriteLine(">>> EXECUTANDO O PROBLEMA 5 <<<");
          {
            double valorFuturo= 7390.61;
            double taxaJuros= 1.25;
            int periodoMeses= 24;

            double valorPresente= valorFuturo / Math.Pow(1 + taxaJuros / 100, periodoMeses);

            Console.WriteLine($"O valor futuro é: R$ {valorFuturo:F2}");
            Console.WriteLine($"A taxa de juros é: {taxaJuros:F2}%");
            Console.WriteLine($"O período em meses é: {periodoMeses} meses");
            Console.WriteLine($"Então pode se concluir que o valor presente é: R$ {valorPresente:F2}");

            Console.WriteLine();
            Console.WriteLine("Pressione 0 e ENTER para voltar ao menu principal");
            Console.ReadLine();
          }
    }
}