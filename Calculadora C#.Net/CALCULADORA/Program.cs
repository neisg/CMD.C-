

using System;

    class Program
    {
        enum Menu {Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, RaizQuadrada = 6, Sair}
        
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair) // Enqunato o usuario nao (!) Escolher Sair Exiba o Menu
        


        {
            Console.WriteLine("Seja bem-vindo a calculadora, selecione uma opção:");
            Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Potência\n6 - Raiz Quadrada\n7 - Sair");
            
            
        

             Menu opcao = (Menu)int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case Menu.Soma:
                    Soma();
                    break;
                case Menu.Subtracao:
                    Subtracao();    
                    break;
                case Menu.Divisao:
                    Divisao();
                    break;
                case Menu.Multiplicacao:
                    Multiplicacao();
                    break;    
                case Menu.Potencia:
                    Potencia();
                    break;
                case Menu.RaizQuadrada: 
                    RaizQuadrada();
                    break;                                            
                case Menu.Sair:
                    escolheuSair = true;
                    break;
                default:    
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }   
            

            } 

    
        Console.Clear();

        }

    private static void Soma()
    {
        Console.WriteLine("Digite o primeiro número: ");    
        Console.WriteLine("Digite o segundo número: ");
        int numero1 = int.Parse(Console.ReadLine()!);
        int numero2 = int.Parse(Console.ReadLine()!);
        int resultado = numero1 + numero2;
        Console.WriteLine($"O resultado da soma é: {resultado}");
    }

    private static void Subtracao()
    {
        Console.WriteLine("Digite o primeiro número: ");
        Console.WriteLine("Digite o segundo número: ");
        int numero1 = int.Parse(Console.ReadLine()!);
        int numero2 = int.Parse(Console.ReadLine()!);
        int resultado = numero1 - numero2;
        Console.WriteLine($"O resultado da subtração é: {resultado}");

    }

    private static void Divisao()
    {
        Console.WriteLine("Digite o primeiro número: ");
        Console.WriteLine("Digite o segundo número: ");
        int numero1 = int.Parse(Console.ReadLine()!);
        int numero2 = int.Parse(Console.ReadLine()!);
        int resultado = numero1 / numero2;
        Console.WriteLine($"O resultado da divisão é: {resultado}");
    }

    private static void Multiplicacao()
    {
        Console.WriteLine("Digite o primeiro número: ");
        Console.WriteLine("Digite o segundo número: ");
        int numero1 = int.Parse(Console.ReadLine()!);
        int numero2 = int.Parse(Console.ReadLine()!);
        int resultado = numero1 * numero2;
        Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    }

    private static void Potencia()
    {
        Console.WriteLine("Digite o primeiro número: ");
        Console.WriteLine("Digite o segundo número: ");
        int numero1 = int.Parse(Console.ReadLine()!);
        int numero2 = int.Parse(Console.ReadLine()!);
        int resultado = (int)Math.Pow(numero1, numero2);
        Console.WriteLine($"O resultado da potência é: {resultado}");
    }

    private static void RaizQuadrada()
    {
        Console.WriteLine("Digite o número: ");
        int numero1 = int.Parse(Console.ReadLine()!);
        double resultado = Math.Sqrt(numero1);
        Console.WriteLine($"O resultado da raiz quadrada é: {resultado}");
    }
}

