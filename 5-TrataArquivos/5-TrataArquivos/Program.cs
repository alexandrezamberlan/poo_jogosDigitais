using System;
using System.Collections.Generic;
using System.IO; //importação para manipular arquivos
using System.Text;

namespace _5_TrataArquivos
{
    class Program
    {

        static void escreveNoArquivo()
        {
            String frase;
            StreamWriter escritor = new StreamWriter("frases.txt"); //abre o arquivo para escrita
            do
            {
                Console.Write("Digite uma frase ou 'sair' para encerrar programa: ");
                frase = Console.ReadLine();
                frase.ToLower();
                if (frase.Equals("sair"))
                {
                    break;
                }
                escritor.WriteLine(frase); //literalmente escreve no arquivo
                escritor.Flush(); //garante depois de cada frase digitada que vá para o arquivo

            } while (true);
            escritor.Close(); //fecha o objeto que representa o arquivo
        }

        static void leArquivo()
        {
            String fraseLida;
            StreamReader leitor = new StreamReader("frases.txt",Encoding.UTF8); //abre o arquivo para leitura

            fraseLida = leitor.ReadToEnd();
            Console.WriteLine(fraseLida);

            leitor.Close(); //fecha o objeto que representa o arquivo

        }

        static void leArquivoEmLista()
        {
            List<String> frasesLidas = new List<string>();
            StreamReader leitor = new StreamReader("frases.txt", Encoding.UTF8); //abre o arquivo para leitura

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

        static void Main(string[] args)
        {
            Console.WriteLine("Aplicativo para ler e escrever em arquivos texto");
            escreveNoArquivo();
            //leArquivo();
            //leArquivoEmLista();
        }
    }
}
