using System;
using System.Collections.Generic; //importação para manipular List
using System.IO; //importação para manipular arquivos
using System.Text; //importação para manipular o Encoding de um texto

namespace _6_extraiPartesString_Arquivo
{
    public class Util
    {

        public static void escreveEmArquivo()
        {
            String expressao;
            String categoria;

            String nomeArquivo;
            Console.Write("Digite o nome do arquivo que deseja gravar: ");
            nomeArquivo = Console.ReadLine();
            StreamWriter escritor = new StreamWriter(nomeArquivo);

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


        public static void leArquivoEmLista(List<Palavra> listaPalavras)
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
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
                //leArquivoEmLista(listaPalavras);
            }

        }
    }
}
