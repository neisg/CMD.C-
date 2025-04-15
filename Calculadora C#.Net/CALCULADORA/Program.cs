

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
        throw new NotImplementedException();
    }

    private static void Subtracao()
    {
        throw new NotImplementedException();
    }

    private static void Divisao()
    {
        throw new NotImplementedException();
    }

    private static void Multiplicacao()
    {
        throw new NotImplementedException();
    }

    private static void Potencia()
    {
        throw new NotImplementedException();
    }

    private static void RaizQuadrada()
    {
        throw new NotImplementedException();
    }
}

// Console.WriteLine("Digite o primeiro número: ");