

using System;

    class Program
    {
        enum Menu {Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, RaizQuadrada = 6, Sair}
        
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem-vindo a calculadora, selecione uma opção:");
            Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Potência\n6 - Raiz Quadrada\n7 - Sair");
            Menu opcao = (Menu)int.Parse(Console.ReadLine() ?? string.Empty);

           

            Console.WriteLine(opcao);

            Console.WriteLine();
            
            Console.Clear();



            
    Console.ReadLine();



        }
    }

