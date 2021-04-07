using System;
using System.Collections.Generic;

namespace GestaoPersonagensArmas
{   
    class Program
    {
        static void cadastrarArma(List<Arma> listaDeArmas)
        {
            Console.WriteLine("Cadastro de Armas");
            int codigo;
            String descricao;
            String nome;
            int poderDestruicao;

            Console.Write("Digite o código da arma: ");
            codigo = Int32.Parse( Console.ReadLine() );

            Console.Write("Digite a descrição da arma: ");
            descricao = Console.ReadLine().ToUpper();

            Console.Write("Digite o nome da arma: ");
            nome = Console.ReadLine().ToUpper();

            Console.Write("Digite o poder de destruição da arma [0-10]: ");
            poderDestruicao = Int32.Parse(Console.ReadLine());

            listaDeArmas.Add(new Arma(codigo, descricao, nome, poderDestruicao));

            //rotina para gravar em arquivo

            Console.WriteLine("Cadastro realizado com sucesso!");
        }

        static void listarArmas(List<Arma> listaDeArmas)
        {
            Console.WriteLine("Lista de Armas");
            if (listaDeArmas.Count == 0)
            {
                Console.WriteLine("Nenhuma arma cadastrada");
            } else
            {
                for (int i = 0; i < listaDeArmas.Count; i++)
                {
                    Console.WriteLine("Código          : " + listaDeArmas[i].codigo);
                    Console.WriteLine("Descrição       : " + listaDeArmas[i].descricao);
                    Console.WriteLine("Nome            : " + listaDeArmas[i].nome);
                    Console.WriteLine("Poder destruição: " + listaDeArmas[i].poderDestruicao);
                    Console.WriteLine("______________________________________________");
                }
            }
        }

        static void pesquisarArmas(List<Arma> listaDeArmas)
        {
            String nomeDescricao;
            Console.WriteLine("Pesquisar por Armas");

            if (listaDeArmas.Count == 0)
            {
                Console.WriteLine("Lista de armas está vazia");
                return;
            }

            Console.Write("Nome ou descrição da arma: ");
            nomeDescricao = Console.ReadLine().ToUpper();

            bool encontrou = false; //flag

            for (int i = 0; i < listaDeArmas.Count; i++)
            {
                if (nomeDescricao.Equals(listaDeArmas[i].nome) || nomeDescricao.Equals(listaDeArmas[i].descricao))
                {
                    Console.WriteLine("Código          : " + listaDeArmas[i].codigo);
                    Console.WriteLine("Descrição       : " + listaDeArmas[i].descricao);
                    Console.WriteLine("Nome            : " + listaDeArmas[i].nome);
                    Console.WriteLine("Poder destruição: " + listaDeArmas[i].poderDestruicao);
                    Console.WriteLine("______________________________________________");

                    encontrou = true;
                }
            }

            if (!encontrou)
            {
                Console.WriteLine("Pesquisa não encontrada!");
            }
        }

        static void cadastrarPersonagem(List<Personagem> listaDePersonagens)
        {
            Console.WriteLine("Cadastro de Personagens");
            int codigo;
            String descricao;
            String nome;

            Console.Write("Digite o código do personagem: ");
            codigo = Int32.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do personagem: ");
            descricao = Console.ReadLine().ToUpper();

            Console.Write("Digite o nome do personagem: ");
            nome = Console.ReadLine().ToUpper();

            listaDePersonagens.Add(new Personagem(codigo, descricao, nome));

            //rotina para gravar em arquivo

            Console.WriteLine("Cadastro realizado com sucesso!");
        }

        static void listarPersonagens(List<Personagem> listaDePersonagens)
        {
            Console.WriteLine("Lista de Personagens");
            if (listaDePersonagens.Count == 0)
            {
                Console.WriteLine("Nenhum personagem cadastrado");
            }
            else
            {
                for (int i = 0; i < listaDePersonagens.Count; i++)
                {
                    listaDePersonagens[i].mostrarMeusDados(); //princípio da OO - tercerização
                }
            }
        }

        static void adicionarArmasPersonagem(List<Arma> listaDeArmas, List<Personagem> listaDePersonagens)
        {
            String nome;

            if (listaDeArmas.Count == 0 || listaDePersonagens.Count == 0)
            {
                Console.WriteLine("Uma das listas deve estar vazia. Operação cancelada");
                return;
            }
            Console.Write("Nome do personagem: ");
            nome = Console.ReadLine().ToUpper();

            int codigoArma;
            Arma armaEscolhida
;
            for (int i = 0; i < listaDePersonagens.Count; i++)
            {
                if (listaDePersonagens[i].nome.Equals(nome))
                {
                    //encontrado
                    Program.listarArmas(listaDeArmas);

                    Console.Write("Digite o código da arma que quer adicionar ao personagem: ");
                    codigoArma = Int32.Parse(Console.ReadLine());

                    for (int j = 0; j < listaDeArmas.Count; j++)
                    {
                        if (codigoArma == listaDeArmas[j].codigo)
                        {
                            //arma localizada
                            armaEscolhida = listaDeArmas[j];
                            if (!listaDeArmas.Contains(armaEscolhida)) {
                                listaDePersonagens[i].inventario.Add(armaEscolhida);
                            }
                            
                        }
                    }
                    return;
                }
            }

            Console.WriteLine("Personagem não encontrado!");
        }

        static void Main(string[] args)
        {
            String opcao;
            List<Arma> listaDeArmas = new List<Arma>();
            List<Personagem> listaDePersonagens = new List<Personagem>();
            //System.Diagnostics.Process.Start("CMD.exe", "clear");

            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 - cadastrar arma");
                Console.WriteLine("2 - listar armas");
                Console.WriteLine("3 - pesquisar por armas");
                Console.WriteLine("4 - cadastrar personagem");
                Console.WriteLine("5 - listar personagens");
                Console.WriteLine("6 - adicionar armas a um personagem");
                Console.WriteLine("7 - sair");
                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        //cadastrar arma
                        Program.cadastrarArma(listaDeArmas);
                        break;
                    case "2":
                        //listar armas
                        Program.listarArmas(listaDeArmas);
                        break;
                    case "3":
                        //pesquisar por armas
                        Program.pesquisarArmas(listaDeArmas);
                        break;
                    case "4":
                        //cadastrar personagem
                        Program.cadastrarPersonagem(listaDePersonagens);
                        break;
                    case "5":
                        //listar personagens
                        Program.listarPersonagens(listaDePersonagens);
                        break;
                    case "6":
                        //adicionar armas a um personagem
                        Program.adicionarArmasPersonagem(listaDeArmas, listaDePersonagens);
                        break;
                    case "7":
                        //sair
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != "7");
        }
    }
}
