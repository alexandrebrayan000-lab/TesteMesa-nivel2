using System;

public static class problema4
{
    public static void Executar()
    {
        Console.WriteLine(">>> EXECUTANDO O PROBLEMA 4 <<<");
         {
            double valorPresente= 2000.0;
            double taxaJuros= 2.00/100;
            double periodoMes= 5.0;
            double resgate= 1000.0;
            double saldoFinal= 0.0;
            double novoValorPresente=0.0;

            for (int loop = 0; loop <= periodoMes; loop++)
            {
                double rendimento= valorPresente* Math.Pow(1 +taxaJuros, loop);
                double rendimentoLiquido= rendimento - valorPresente;
                double rendaAcumulada= valorPresente + rendimentoLiquido;
                saldoFinal = rendimento;

                if (loop == 5)
                {
                    saldoFinal = rendimento - resgate;
                    novoValorPresente = saldoFinal;
                }
                Console.WriteLine($"---Loop a.m.: {loop:F2} ---");
                Console.WriteLine($"Taxa de Juros: {taxaJuros*100:F2}%");
                Console.WriteLine($"Rendimento: R$ {rendimento:F2}");
                Console.WriteLine($"Renda Líquida: R$ {rendimentoLiquido:F2}");
                Console.WriteLine($"Renda Acumulada: R$ {rendaAcumulada:F2}");
                Console.WriteLine($"Saldo Final: R$ {saldoFinal:F2}");
                
            }
            for (int loop = 1; loop <= 2; loop++)    
            {
                double rendimento= novoValorPresente* Math.Pow(1 +taxaJuros, loop);
                double rendimentoLiquido= rendimento - novoValorPresente;
                double rendaAcumulada= novoValorPresente + rendimentoLiquido;
                double saldoFinalFase2= rendimento;
                Console.WriteLine($"---Loop a.m.: {loop:F2} (Pós-Resgate) ---");
                Console.WriteLine($"Taxa de Juros: {taxaJuros*100:F2}%");
                Console.WriteLine($"Rendimento: R$ {rendimento:F2}");
                Console.WriteLine($"Renda Líquida: R$ {rendimentoLiquido:F2}");
                Console.WriteLine($"Renda Acumulada: R$ {rendaAcumulada:F2}");
                Console.WriteLine($"Saldo Final: R$ {saldoFinalFase2:F2}");
            }
            Console.WriteLine();
            Console.WriteLine("Pressione 0 e ENTER para voltar ao menu principal");
            Console.ReadLine();
         }
    }
}