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

        static void mostrarPerguntas(List<PerguntaResposta> listaDePerguntas)
        {
            for (int i = 0; i < listaDePerguntas.Count; i++)
            {
                Console.WriteLine("Pergunta           : " + listaDePerguntas[i].pergunta);
                Console.WriteLine("Área               : " + listaDePerguntas[i].categoria.descricao);
                Console.WriteLine("Grau de dificuldade: " + listaDePerguntas[i].grauDificuldade);
                Console.WriteLine("---------------------------------------------------");
            }
        }

        private static String descobrirArea(int codigo, List<Area> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (codigo == lista[i].codigo)
                {
                    return lista[i].descricao;
                }
            }
            return "0"; //indica que o código pesquisado não está na lista
        }

        static void cadastrarPerguntaResposta(List<PerguntaResposta> listaDePerguntasRespostas, List<Area> listaDeAreas)
        {
            String pergunta;
            String resposta;
            String area;
            int grauDificuldade;
            int codigo;

            Console.Write("Digite a pergunta: ");
            pergunta = Console.ReadLine();
            Console.Write("Digite a resposta dessa pergunta: ");
            resposta = Console.ReadLine();
            Console.Write("Grau de dificuldade (1 a 5)");
            grauDificuldade = Int32.Parse( Console.ReadLine() );
            Console.WriteLine("Lista de áreas");
            Program.mostrarAreas(listaDeAreas);
            Console.Write("Digite o código da área que deseja associar a pergunta: ");
            codigo = Int32.Parse( Console.ReadLine() );

            area = descobrirArea(codigo, listaDeAreas);
            if (area.Equals("0"))
            {
                Console.WriteLine("Código da área está incorreto!");
                Console.WriteLine("Operação cancelada");
            } else
            {
                Area areaTmp = new Area(codigo, area);
                PerguntaResposta perguntaRespostaTmp = new PerguntaResposta(pergunta, resposta, areaTmp, grauDificuldade);
                listaDePerguntasRespostas.Add(perguntaRespostaTmp);
                Console.Write("Cadastro de pergunta Ok");
            }
        }

        private static bool jaInserida(String area, List<Area> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].descricao.ToUpper().Equals(area.ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }

        static void cadastrarArea(List<Area> listaDeAreas)
        {
            int ultimoCodigo = listaDeAreas[listaDeAreas.Count - 1].codigo;
            ultimoCodigo++;
            String area;
            Area areaTmp;
            do
            {
                Console.Write("Digite o nome da área ou categoria:");
                area = Console.ReadLine();
                if (!jaInserida(area, listaDeAreas))
                {
                    areaTmp = new Area(ultimoCodigo, area.ToUpper());
                    listaDeAreas.Add(areaTmp);
                    break;
                }
                else
                {
                    Console.WriteLine("Área já cadastrada");
                }
            } while (true);
        }

        static void menu(List<Area> listaDeAreas, List<PerguntaResposta> listaDePerguntasRespostas)
        {
            String opcao;
            char tecla;

            do
            {
                Console.Clear();
                Console.WriteLine("Jogo do MASTER: Perguntas e Respostas");
                Console.WriteLine("1 - Carregar dos arquivos: áreas e as perguntas e respostas");
                Console.WriteLine("2 - Cadastrar Pergunta-Resposta");
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
                        Console.WriteLine("Carregamento dos arquivos realizado com sucesso");
                        break;
                    case "2":
                        Console.WriteLine("Cadastrar pergunta-resposta");
                        Program.cadastrarPerguntaResposta(listaDePerguntasRespostas, listaDeAreas);
                        //Util.atualizandoArquivoPerguntasRespostas(listaDePerguntasRespostas);
                        break;
                    case "3":
                        Console.WriteLine("Cadastrar área");
                        Program.cadastrarArea(listaDeAreas);
                        Util.atualizandoArquivoAreas(listaDeAreas);
                        break;
                    case "4":
                        Console.WriteLine("Listar áreas e perguntas por área");
                        Program.mostrarAreas(listaDeAreas);
                        Program.mostrarPerguntas(listaDePerguntasRespostas);
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
