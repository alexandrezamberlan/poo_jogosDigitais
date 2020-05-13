using System;
using System.Collections.Generic;

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
                        Console.WriteLine("Gestão de palavras");
                        //informar nome da palavra e a categoria
                        Console.Write("1 - Carrega palavras de arquivo; 2 - Grava palavras em arquivo: ");
                        string op = Console.ReadLine();
                        if (op.Equals("1"))
                        {
                            Util.lerArquivoEmLista(listaPalavras,listaCategorias);
                        } else if (op.Equals("2"))
                        {
                            Util.escreverEmArquivo();
                            Console.WriteLine("Gravação OK das palavras no arquivo.... Próximo passo");
                            Util.lerArquivoEmLista(listaPalavras,listaCategorias);
                        } else
                        {
                            Console.WriteLine("Você não escolheu uma opção correta");
                        }
                        
                        Util.mostrarPalavras(listaPalavras);
                        Util.limparTela();
                        break;
                    case 2:
                        Console.WriteLine("Escolher categoria");
                        //Selecionar a categoria
                        if (listaCategorias.Count > 0)
                        {
                            Util.mostrarCategorias(listaCategorias);

                            int indiceCategoria;
                            do
                            {
                                Console.Write("\n\nDigite o número da categoria: ");
                                indiceCategoria = Int32.Parse(Console.ReadLine());
                            } while (indiceCategoria < 0 || indiceCategoria >= listaCategorias.Count);

                            categoriaEmJogo = listaCategorias[indiceCategoria];
                            Console.WriteLine("OK... Você selecionou a categoria: " + categoriaEmJogo);
                        } else
                        {
                            Console.WriteLine("Primeiro é preciso carregar a lista de palavras");
                        }
                        Util.limparTela();
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

        //variáveis globais de acesso a qualquer metodo

        static List<Palavra> listaPalavras = new List<Palavra>();
        static List<Jogador> listaJogadores = new List<Jogador>();
        static List<string> listaCategorias = new List<string>();
        static string categoriaEmJogo;
    }
}
