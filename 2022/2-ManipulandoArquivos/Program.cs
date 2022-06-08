using System;
using System.Collections.Generic;
using System.IO;

namespace ManipulandoArquivos
{
    class Program
    {
        static void revisao()
        {
            //revisão inicial
            //1 - classe é uma "fábrica" que gera objetos ou fornece atributos e/ou serviços
            Console.WriteLine("Estamos fazendo uma revisão"); //classe console foi invocada mais seu método de classe WriteLine

            int idade;
            List<int> listaIdades = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Digite sua idade: ");
                idade = Int32.Parse(Console.ReadLine());
                listaIdades.Add(idade);  //objeto listaIdades do tipo List está invocando o método Add()          
            }

            listaIdades.Sort(); //objeto listaIdadses do tipo List está invocando o método Sort() que ordena a lista


            for (int i = 0; i < listaIdades.Count; i++)
            {
                Console.WriteLine(listaIdades[i]);
            }
        }

        static void lerArquivo()
        {
            Console.Write("Informe o nome do arquivo a ser lido e exibido na tela: ");
            string nomeArquivo = Console.ReadLine();

            // To read the entire file at once
            if (File.Exists(nomeArquivo)) //o método de classe Exists() é invocado pela classe File
            {
                //Primeira forma
                // Le todo o conteúdo do arquivo em uma única string conteudoArquivo
                //string conteudoArquivo = File.ReadAllText(nomeArquivo);
                //Console.WriteLine(conteudoArquivo);


                //Segunda forma - é a mais útil
                //le o conteúdo do arquivo linha por linha e armazena em uma lista/vetor de string
                string[] linhas = File.ReadAllLines(nomeArquivo);
                string[] dados;
                for (int i = 0; i < linhas.Length; i++)
                {
                    dados = linhas[i].Split("@"); //método de instância que divide uma string em um vetor por algum critério
                    Console.WriteLine(dados[1]);
                 }

                //Exercício 1: qual linha um determinado aluno encontra-se

                //Exercício 2: um determinado aluno está ou não no arquivo

                //Exercício 3: quantas linhas há no arquivo

                //Exercício 4: como gravar/escrever no arquivo

                    
            } 
            else
            {
                Console.WriteLine("Arquivo não localizado");
            }
           
    }
        static void Main(string[] args)
        {
            //Program.revisao(); //dentro do Main o método de classe revisao() está sendo invocado
            //Manipular Arquivos Textos
            //ler arquivos textos em memória
            Program.lerArquivo();
        }
    }
}
