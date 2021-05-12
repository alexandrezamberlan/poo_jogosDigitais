using System;
using System.Collections.Generic; //importação para manipular List
using System.IO; //importação para manipular arquivos
using System.Text; //importação para manipular o Encoding de um texto
namespace _5_TrataArquivos
{
    class Util
    {
        public static void escreveNoArquivo()
        {
            try
            {
                String frase;
                String nomeArquivo;
                StreamWriter escritor;

                Console.Write("Digite o nome do arquivo que deseja gravar: ");
                nomeArquivo = Console.ReadLine();
                escritor = new StreamWriter(nomeArquivo); //abre o arquivo para escrita

                do
                {
                    Console.Write("Digite uma frase ou 'sair' para encerrar programa: ");
                    frase = Console.ReadLine();
                    frase.ToLower(); //frase.toUpper();
                    if (frase.Equals("sair"))
                    {
                        break;
                    }
                    escritor.WriteLine(frase); //literalmente escreve no arquivo
                    escritor.Flush(); //garante depois de cada frase digitada que vá para o arquivo

                } while (true);
                escritor.Close(); //fecha o objeto que representa o arquivo
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao gravar o arquivo: " + e.Message);
                Util.escreveNoArquivo(); //ponto de recursão - USAR COM CUIDADO
            }

        }

        public static void leArquivo()
        {

            try
            {
                String nomeArquivo;
                String fraseLida;

                Console.Write("Digite o nome do arquivo que deseja ler: ");
                nomeArquivo = Console.ReadLine();
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8); //abre o arquivo para leitura

                fraseLida = leitor.ReadToEnd();
                Console.WriteLine(fraseLida);

                leitor.Close(); //fecha o objeto que representa o arquivo
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
                Util.leArquivo(); //ponto de recursão - USAR COM CUIDADO
            }


        }

        public static void leArquivoEmLista0()
        {
            try
            {
                List<String> frasesLidas = new List<string>();
                String nomeArquivo;
                Console.Write("Digite o nome do arquivo que deseja ler: ");
                nomeArquivo = Console.ReadLine();
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8); //abre o arquivo para leitura

                do
                {
                    frasesLidas.Add(leitor.ReadLine());

                } while (!leitor.EndOfStream);

                leitor.Close(); //fecha o objeto que representa o arquivo

                for (int i = 0; i < frasesLidas.Count; i++)
                {

                    Console.WriteLine(frasesLidas[i]);

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
                Util.leArquivoEmLista0();
            }

        }

        public static void desafioProfessor()
        {
            /*
             * Crie um arquivo texto (direto no bloco de notas) contendo nomes de jogadores (minúsculo e maiúsculo)
             * Em seguida, faça um método que leia esse arquivo e converta todos os nomes para maiúsculo,
             * atualizando o arquivo.
             */

            /*  nomes.txt - toUpper()
                Pedro
                carla
                sofia
                betina
                bruno
            */
            try
            {
                List<String> frasesLidas = new List<string>();
                String nomeArquivo;
                Console.Write("Digite o nome do arquivo que deseja ler: ");
                nomeArquivo = Console.ReadLine();

                //abrir e ler o arquivo origem e jogar todo conteúdo numa lista ou numa variável
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8); //abre o arquivo para leitura

                //converter para maiúsculo todas as palavras lidas para a lista ou variável
                do
                {
                    frasesLidas.Add(leitor.ReadLine().ToUpper());

                } while (!leitor.EndOfStream);

                //fechar o arquivo de origem
                leitor.Close();

                //abrir novamente o arquivo de origem agora para escrever (sobreescrever)
                StreamWriter escritor = new StreamWriter(nomeArquivo); //abre o arquivo para escrita

                //depositar/escrever o conteúdo da lista ou da variável no arquivo de origem reaberto
                for (int i = 0; i < frasesLidas.Count; i++)
                {
                    escritor.WriteLine(frasesLidas[i]);
                    escritor.Flush();
                }

                //fechar o arquivo de origem
                escritor.Close();

            }
            catch (IOException e)
            {
                Console.WriteLine("Problemas na escrita ou leitura do arquivo: " + e.Message);
                Util.desafioProfessor();
            }

        }

        public static void lerArquivoAlunosEmLista()
        {
            try
            {
                List<String> frasesLidas = new List<String>();
                String nomeArquivo;
                Console.Write("Digite o nome do arquivo contendo dados de alunos que deseja ler: ");
                nomeArquivo = Console.ReadLine();
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8); //abre o arquivo para leitura

                //primeira repetição pega todas as frases do arquivo lido e jogo na lista frasesLidas
                do
                {
                    frasesLidas.Add(leitor.ReadLine());

                } while (!leitor.EndOfStream);

                leitor.Close(); //fecha o objeto que representa o arquivo

                List<Aluno> listaAlunos = new List<Aluno>();
                String[] resposta;

                //na segunda repetição, pega cada frase lida, splita pelo @ e separa nome de curso
                for (int i = 0; i < frasesLidas.Count; i++)
                {
                    //nome de um aluno@curso do aluno
                    resposta = frasesLidas[i].Split("@");
                    //resposta = ["carlos", "jogos digitais"];

                    listaAlunos.Add(new Aluno(resposta[0].ToUpper(), resposta[1].ToUpper()));
                }

                for (int i = 0; i < listaAlunos.Count; i++)
                {
                    Console.WriteLine("Nome     : " + listaAlunos[i].nome);
                    Console.WriteLine("Curso    : " + listaAlunos[i].curso);
                    Console.WriteLine("=====================");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
                lerArquivoAlunosEmLista();
            }
        }
    }
}
