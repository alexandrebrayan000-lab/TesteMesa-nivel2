using System;

class Program
{
    static void Main(string[] args)
    {
        string opcao = "";

        do
        {
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("          MENU DE EXERCÍCIOS           ");
            Console.WriteLine("======================================="); 
            Console.WriteLine("1 - Rodar o Problema 1");
            Console.WriteLine("2 - Rodar o Problema 2");
            Console.WriteLine("3 - Rodar o Problema 3");
            Console.WriteLine("4 - Rodar o Problema 4");
            Console.WriteLine("5 - Rodar o Problema 5");
            Console.WriteLine("0 - VOLTAR AO MENU PRINCIPAL");
            Console.WriteLine("=======================================");
            Console.Write("Escolha uma opção (1, 2, 3, 4 ou 5): ");

            opcao = Console.ReadLine() ?? "";
            Console.Clear(); 

            switch (opcao)
            {
                case "1":
                    problema1.Executar(); 
                    break;
                case "2":
                    problema2.Executar(); 
                    break;
                case "3":
                    problema3.Executar(); 
                    break;
                case "4":
                    problema4.Executar();
                    break;
                case "5":
                    problema5.Executar();
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente rodar o programa novamente.");
                    break;
            }

        } while (opcao != "0");    

        Console.WriteLine("\n=======================================");
        Console.WriteLine("Programa finalizado. Pressione Enter para fechar.");
        Console.ReadLine();
    }
}
