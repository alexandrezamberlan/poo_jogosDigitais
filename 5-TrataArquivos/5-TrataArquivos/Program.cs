using System;
using System.Collections.Generic; //importação para manipular List
using System.IO; //importação para manipular arquivos
using System.Text; //importação para manipular o Encoding de um texto

namespace _5_TrataArquivos
{
    class Program
    {

        static void escreveNoArquivo()
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
                escreveNoArquivo(); //ponto de recursão - USAR COM CUIDADO
            }
            
        }

        static void leArquivo()
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
                leArquivo(); //ponto de recursão - USAR COM CUIDADO
            }
            

        }

        static void leArquivoEmLista()
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
                    if (frasesLidas[i].Contains("fruta"))
                    {
                        Console.WriteLine(frasesLidas[i]);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
                leArquivoEmLista();
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Aplicativo para ler e escrever em arquivos texto");
            //escreveNoArquivo();
            //leArquivo();
            leArquivoEmLista();
        }

    }
}
/***
 *
 * MANIPULAÇÃO DE ARQUIVO TEXTO -> PLAIN TEXT (html, xml, json)
 *  - Classe para escrever - StreamWriter (using System.IO)
 *  
 *      - new()       - aloca o objeto (escritor) e já o abre para escrita. Se já existe, sobreescreve o arquivo
 *      - WriteLine() - escreve uma string no objeto alocado, ou seja o escritor (memória)
 *      - Flush()     - descarrega o que foi digitado na memória para o arquivo em DISCO
 *      - Close()     - fecha o arquivo, ou seja, desconecta o escritor com o arquivo em DISCO
 *
 *      
 *  - Classe para ler      - StreamReader (using System.IO)
 *  
 *      - new()         - aloca o objeto e já o abre para leitura. Se não existe retorna null
 *                      - é possível definir o encoding
 *      - ReadToEnd()   - lê todo o conteúdo de um arquivo e joga para uma variável string
 *      - ReadLine()    - lê linha a linha um arquivo. Precisa de uma repetição
 *      - Close()       - fecha o arquivo
 *      
 * 
 */
