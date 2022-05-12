using System;
using System.Collections.Generic;

namespace JogoPerguntasRespostas
{
    class Program
    {
        static List<Categoria> listaCategorias = new List<Categoria>();
        static List<Nivel> listaNiveis = new List<Nivel>();

        static void menu()
        {
            string opcao = "";
            do
            {
                Console.WriteLine("1 - Carregar arquivos de categorias e níveis");
                Console.WriteLine("2 - Listar categorias");
                Console.WriteLine("3 - Listar níveis");
                Console.WriteLine("4 - Cadastrar categoria");
                Console.WriteLine("5 - Cadastrar nível");
                Console.WriteLine("8 - Encerrar sistema");
                Console.Write("Opção: ");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Menu carregar arquivos de categorias e níveis");
                        //codigo para popular as listas com os dados dos arquivos
                        break;
                    case "2":
                        Console.WriteLine("Menu listar categorias");
                        //codigo para exibir lista com os dados do arquivo de categoria
                        break;
                    case "3":
                        Console.WriteLine("Menu listar níveis");
                        //codigo para exibir lista com os dados do arquivo de nível
                        break;
                    case "4":
                        Console.WriteLine("Menu cadastrar nova categoria");
                        //codigo para cadastrar nova categoria, tanto na lista quanto no arquivo (persistir)
                        break;
                    case "5":
                        Console.WriteLine("Menu cadastrar novo nível");
                        //codigo para cadastrar novo nível, tanto na lista quanto no arquivo (persistir)
                        break;
                    case "8":
                        break;                  
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != "8");
        }

        static void Main(string[] args)
        {
            menu();
        }
    }
}

//listaNiveis.Add(new Nivel("Fácil", 1));
//listaNiveis.Add(new Nivel("Médio", 3));
//listaNiveis.Add(new Nivel("Difícil", 5));
//listaCategorias.Add(new Categoria("Games", 1));
//listaCategorias.Add(new Categoria("Esportes", 2));
//listaCategorias.Add(new Categoria("Geografia", 3));
//int posicaoCategoria;
//do
//{
//    Categoria.mostrar(listaCategorias);
//    Console.Write("Informe categoria: ");
//    string categoria = Console.ReadLine();
//    posicaoCategoria = Categoria.qualPosicao(categoria, listaCategorias);
//} while (posicaoCategoria == -27);
//int posicaoNivel;
//do
//{
//    Nivel.mostrar(listaNiveis);
//    Console.Write("Informe nível: ");
//    string nivel = Console.ReadLine();
//    posicaoNivel = Nivel.qualPosicao(nivel, listaNiveis);
//} while (posicaoNivel == -27);

//Console.Write("Digite a pergunta que deseja cadastrar: ");
//string pergunta = Console.ReadLine();

//Console.Write("Digite a resposta da pergunta cadastrada: ");
//string resposta = Console.ReadLine();

//PerguntaResposta objeto = new PerguntaResposta(pergunta, resposta, 
//    listaCategorias[posicaoCategoria], listaNiveis[posicaoNivel]);

//List<PerguntaResposta> listaPerguntasRespostas = new List<PerguntaResposta>();
//listaPerguntasRespostas.Add(objeto);


//Console.WriteLine(objeto);

////PerguntaResposta.mostrar(listaPerguntasRespostas);

