using System;

namespace _4_jogoDaForca
{
    class Program
    {

        static void menu()
        {
            int opcao;
            do
            {
                Console.WriteLine("Menu de opções para o Jogo da Forca");
                Console.WriteLine("1 - carregar/cadastrar palavras");
                Console.WriteLine("2 - escolher categoria");
                Console.WriteLine("3 - jogar");
                Console.WriteLine("4 - visualizar pontuação");
                Console.WriteLine("5 - sair");


                Console.Write("Opção: ");
                opcao = Int32.Parse( Console.ReadLine() );

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Cadastro de palavras");
                        //informar nome da palavra e a categoria

                        break;
                    case 2:
                        Console.WriteLine("Escolher categoria");
                        //Selecionar a categoria

                        break;
                    default:
                        break;
                }

            } while (opcao != 5);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Jogo da Forca");
            menu();
        }
    }
}
