using System;

public static class problema1
{
    public static void Executar()
    {
        Console.WriteLine(">>> EXECUTANDO O PROBLEMA 1 <<<");
          {
            double valorPresente= 1000.0; 
            double taxaJuros = 5.30/100;
            int periodo = 6; 

            double valorFuturo = valorPresente * Math.Pow(1 + taxaJuros, periodo);
            Console.WriteLine("Valor Presente | Taxa de Juros | Período | Valor Futuro");
            Console.WriteLine("-------------- | ------------- | ------- | ------------");
            Console.WriteLine($"R$ {valorPresente:F2} | {taxaJuros*100:F2}% | {periodo} | R$ {valorFuturo:F2}");

            Console.WriteLine();
            Console.WriteLine("Pressione 0 e ENTER para voltar ao menu principal");
            Console.ReadLine();
          }
    }
}