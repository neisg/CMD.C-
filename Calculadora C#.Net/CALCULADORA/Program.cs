

using System;

    class Program
    {
        enum Menu {Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, RaizQuadrada = 6, Sair}
        
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (escolheuSair)
        


        {
            Console.WriteLine("Seja bem-vindo a calculadora, selecione uma opção:");
            Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Potência\n6 - Raiz Quadrada\n7 - Sair");
            
            
            



            String? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int valor))
            {
                Menu opcao = (Menu)valor;
                switch (opcao)
                
                {
                    //seus cases aqui
                }
            }
            else
            {
                Console.WriteLine("Opção invalida. Tente novamente.");
            }








            /* Menu opcao = (Menu)int.TryParse(Console.ReadLine());

            switch (opcao)
            {
                case Menu.Sair:
                    escolheuSair = true;
                break;

            } */

    
           /* Console.Clear();*/



            



        }
    }

    }