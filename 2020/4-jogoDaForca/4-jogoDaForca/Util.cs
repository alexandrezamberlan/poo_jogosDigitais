using System;
using System.Collections.Generic; //importação para manipular List
using System.IO; //importação para manipular arquivos
using System.Text; //importação para manipular o Encoding de um texto

namespace _4_jogoDaForca
{
    public class Util
    {
        public static void escreverEmArquivo()
        {
            String expressao;
            String categoria;

            String nomeArquivo;
            Console.Write("Digite o nome do arquivo que deseja gravar: ");
            nomeArquivo = Console.ReadLine();


            //se o arquivo existe, adicionar as novas expressões e suas categorias
            //caso contrário, criá-lo
            StreamWriter escritor;

            if (!File.Exists(nomeArquivo))
            {
                escritor = new StreamWriter(nomeArquivo);
            }
            else
            {
                escritor = File.AppendText(nomeArquivo);
            }

            do
            {
                Console.Write("Digite uma Expressão ou a palavra sair para finalizar: ");
                expressao = Console.ReadLine();
                if (expressao.ToUpper().Equals("SAIR"))
                {
                    break;
                }

                Console.Write("Digite a Categoria da Expressão: ");
                categoria = Console.ReadLine();

                escritor.WriteLine(expressao + "@" + categoria);
                escritor.Flush();

            } while (true);

            escritor.Close();
        }

        public static void lerArquivoEmLista(List<Palavra> listaPalavras, List<string> listaCategorias)
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


                String[] resposta;

                for (int i = 0; i < frasesLidas.Count; i++)
                {
                    //Console.WriteLine(frasesLidas[i]);

                    //nova zelândia@país
                    resposta = frasesLidas[i].Split("@");
                    //resposta = ["nova zelândia", "país"];

                    listaPalavras.Add(new Palavra(resposta[0].ToUpper(), resposta[1].ToUpper()));

                    if (!listaCategorias.Contains(resposta[1].ToUpper()))
                    {
                        listaCategorias.Add(resposta[1].ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
                //leArquivoEmLista(listaPalavras);
            }

        }

        static public void mostrarPalavras(List<Palavra> lista)
        {
            Console.WriteLine("Palavras cadastradas");
            Console.WriteLine("___________________________________________");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("Palavra: " + lista[i].texto +
                    " - Categoria: " + lista[i].categoria);
            }
            Console.WriteLine("___________________________________________");
        }

        static public void mostrarCategorias(List<string> lista)
        {
            Console.WriteLine("Categorias cadastradas");
            Console.WriteLine("___________________________________________");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(i + ": " + lista[i]);
            }
            Console.WriteLine("___________________________________________");
        }

        static public string sortearPalavra(List<Palavra> lista, string categoria)
        {
            List<string> listaPalavrasParaSorteio = new List<string>();
            

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].categoria.Equals(categoria))
                {
                    listaPalavrasParaSorteio.Add(lista[i].texto);
                }
            }

            Random gerador = new Random();
            int indice = gerador.Next(listaPalavrasParaSorteio.Count);
            return listaPalavrasParaSorteio[indice];
        }

        static public void limparTela()
        {
            ////declarando uma string com o comando somente para facilitar a visualização
            //string executar = @"/C " + "clear";

            ////Executa o comando no cmd do windows e aguarda a execução do mesmo para fechá-lo
            //System.Diagnostics.Process.Start("CMD.exe",executar).WaitForExit();
            Console.Write("Pressione ENTER para continuar ");
            Console.ReadKey();
            System.Console.Clear();

        }

        static public int jogar(string palavraSorteada, List<Jogador> listaJogadores)
        {
            int qtdErros = 0;
            string letra;
            string palavra = "";
            limparTela();

            for (int i = 0; i < palavraSorteada.Length; i++)
            {
                palavra = palavra + "0";
            }
            String nomeJogador;
            Console.Write("Nome Jogador: ");
            nomeJogador = Console.ReadLine();
            Jogador jogador = new Jogador(nomeJogador);

            if (!listaJogadores.Contains(jogador))
            {
                listaJogadores.Add(jogador);
            }

            int posicao = listaJogadores.IndexOf(jogador);
            Console.WriteLine("Olá " + listaJogadores[posicao].nome + "! Você tem " +
                listaJogadores[posicao].pontuacao + " erros até o momento!");

            do
            {
                Console.WriteLine(palavraSorteada);
                Console.Write("A palavra sorteada: " + palavra + "\n");
                Console.Write("Quantidade de erros: " + qtdErros + "\n\n");

                Console.Write("Digite uma letra: ");
                letra = Console.ReadLine().ToUpper();

                if (!palavraSorteada.Contains(letra))
                {
                    qtdErros++;
                    listaJogadores[posicao].pontuacao = qtdErros;
                } else
                {
                    //...
                    int indice;
                    string palavraTrabalho = palavraSorteada;
                    do
                    {
                        indice = palavraTrabalho.IndexOf(letra);
                        if (indice == -1) break;
                        palavra = palavra.Insert(indice, letra);
                        palavra = palavra.Remove(indice + 1, 1);//apaga um 0 depois da inserção
                        palavraTrabalho = palavraTrabalho.Insert(indice,"@");
                        palavraTrabalho = palavraTrabalho.Remove(indice + 1,1);
                    } while (true);
                }
            } while (qtdErros != palavraSorteada.Length && !palavra.Equals(palavraSorteada));

            return qtdErros;
        }
    }
}
