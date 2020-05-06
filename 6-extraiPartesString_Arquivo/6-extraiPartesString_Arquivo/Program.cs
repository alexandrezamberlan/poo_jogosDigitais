using System;
using System.Collections.Generic;

namespace _6_extraiPartesString_Arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Extraido dados de strings que vêm de arquivo... vice-versa");

            List<Palavra> listaPalavras = new List<Palavra>();

            Console.Write("1 - Criar o arquivo com expressões; 2 - Abrir arquivo em lista: ");
            int opcao = Int32.Parse(Console.ReadLine());

            if (opcao == 1) Util.escreveEmArquivo();

            else if (opcao == 2)
            {
                Util.leArquivoEmLista(listaPalavras);
                for (int i = 0; i < listaPalavras.Count; i++)
                {
                    Console.WriteLine("Expressão: " + listaPalavras[i].expressao);
                    Console.WriteLine("Categoria: " + listaPalavras[i].categoria);
                    Console.WriteLine("=====================");
                }
            }
            else Console.WriteLine("Opção inválida");



        }
    }
}
