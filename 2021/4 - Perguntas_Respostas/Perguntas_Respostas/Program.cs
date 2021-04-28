using System;
using System.Collections.Generic;

namespace Perguntas_Respostas
{
    class Program
    {
        static void mostrarAreas(List<Area> listaDeAreas)
        {
            for (int i = 0; i < listaDeAreas.Count; i++)
            {
                Console.WriteLine("Codigo da área   : " + listaDeAreas[i].codigo);
                Console.WriteLine("Descrição da área: " + listaDeAreas[i].descricao);
                Console.WriteLine("---------------------------------------------------"); 
            }

        }

        static void menu(List<Area> listaDeAreas, List<PerguntaResposta> listaDePerguntasRespostas)
        {
            String opcao;
            char tecla;

            do
            {
                Console.Clear();
                Console.WriteLine("Jogo do MASTER: Perguntas e Respostas");
                Console.WriteLine("1 - Carregar do arquivo as perguntas e respostas");
                Console.WriteLine("2 - Cadastrar Pregunta-Resposta");
                Console.WriteLine("3 - Cadastrar área de pergunta");
                Console.WriteLine("4 - Listar perguntas e respostas por área");
                Console.WriteLine("5 - Sair");
                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Carregando arquivos");
                        Util.carregandoArquivos(listaDeAreas, listaDePerguntasRespostas);
                        Program.mostrarAreas(listaDeAreas);
                        //Program.mostrarPerguntasRespostas(listaDePerguntasRespostas);
                        break;
                    case "2":
                        Console.WriteLine("Cadastrar pergunta-resposta");

                        break;
                    case "3":
                        Console.WriteLine("Cadastrar área");
                        break;
                    case "4":
                        Console.WriteLine("Listar perguntas por área");
                        break;
                    case "5":
                        Console.WriteLine("Obrigado por usar o sistema");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!!");
                        break;
                }
                Console.Write("Tecle ENTER para continuar!");
                tecla = (char)Console.Read();

            } while (!opcao.Equals("5"));
        }

        static void Main(string[] args)
        {
            List<Area> listaDeAreas = new List<Area>();
            List<PerguntaResposta> listaDePerguntasRespostas = new List<PerguntaResposta>();

            Program.menu(listaDeAreas, listaDePerguntasRespostas);
        }
    }
}
