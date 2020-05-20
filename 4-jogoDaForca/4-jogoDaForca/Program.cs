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
                        break;
                    case 2:
                        //Selecionar a categoria
                        if (listaCategorias.Count > 0)
                        {
                            Console.WriteLine("Escolher categoria");
                            Util.mostrarCategorias(listaCategorias);

                            try
                            {
                                int indiceCategoria;
                                do
                                {
                                    Console.Write("\n\nDigite o número da categoria: ");
                                    indiceCategoria = Int32.Parse(Console.ReadLine());
                                } while (indiceCategoria < 0 || indiceCategoria >= listaCategorias.Count);

                                categoriaEmJogo = listaCategorias[indiceCategoria];
                                Console.WriteLine("OK... Você selecionou a categoria: " + categoriaEmJogo);

                            } 
                            catch (Exception ex)
                            {
                                Console.WriteLine("Fique atento, digite o código da categoria");
                            }
                        } else
                        {
                            Console.WriteLine("Primeiro é preciso carregar a lista de palavras");
                        }
                        break;
                    case 3:
                        if (categoriaEmJogo.Equals(""))
                        {
                            Console.WriteLine("Você precisa carregar o arquivo de palavras e depois escolher a categoria");
                        } else
                        {
                            //cadastrar/buscar jogador
                            Console.WriteLine("Jogo da forca para palavras da categoria: " + categoriaEmJogo);
                            string palavraSorteada = Util.sortearPalavra(listaPalavras,categoriaEmJogo);
                            int qtdErros = Util.jogar(palavraSorteada);

                            //atualizar a pontuação do jogador
                            Console.WriteLine("Sua quantidade de erros foi: " + qtdErros);
                        }
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!!");
                        break;
                }
                Util.limparTela();

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
        static string categoriaEmJogo = "";
    }
}
