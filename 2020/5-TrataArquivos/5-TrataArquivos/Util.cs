using System;
using System.Collections.Generic; //importação para manipular List
using System.IO; //importação para manipular arquivos
using System.Text; //importação para manipular o Encoding de um texto
namespace _5_TrataArquivos
{
    class Util
    {
        public static void leArquivoEmLista()
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

                List<Palavra> listaPalavras = new List<Palavra>();
                String[] resposta;

                for (int i = 0; i < frasesLidas.Count; i++)
                {
                    //Console.WriteLine(frasesLidas[i]);

                    //nova zelândia@país
                    resposta = frasesLidas[i].Split("@");
                    //resposta = ["nova zelândia", "país"];

                    listaPalavras.Add(new Palavra(resposta[0].ToUpper(), resposta[1].ToUpper()));
                }

                for (int i = 0; i < listaPalavras.Count; i++)
                {
                    Console.WriteLine("Expressão: " + listaPalavras[i].expressao);
                    Console.WriteLine("Categoria: " + listaPalavras[i].categoria);
                    Console.WriteLine("=====================");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
                leArquivoEmLista();
            }

        }
    }
}
