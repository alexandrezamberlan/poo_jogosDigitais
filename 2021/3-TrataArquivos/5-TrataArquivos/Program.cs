using System;
using System.Collections.Generic; //importação para manipular List
using System.IO; //importação para manipular arquivos
using System.Text; //importação para manipular o Encoding de um texto

namespace _5_TrataArquivos
{
    class Program
    {

        

        static void Main(string[] args)
        {
            //Console.WriteLine("Aplicativo para ler e escrever em arquivos texto");
            //Util.escreveNoArquivo();
            //Util.leArquivo();
            //Util.leArquivoEmLista0();
            //Util.desafioProfessor();
            Util.lerArquivoAlunosEmLista();

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
 */

    