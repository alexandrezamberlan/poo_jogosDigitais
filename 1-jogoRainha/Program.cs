using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {


            int dimensao;

            Console.Write("Informe a dimensão da matriz: ");
            dimensao = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou: " + dimensao);

            int[,] mat = new int[dimensao, dimensao];

            Console.WriteLine();
            List<String> visitados = new List<string>();

           


            inicializaMatriz(mat, dimensao);

            String estado = gerarString(mat, dimensao);
            visitados.Add(estado);

            exibirMatriz(mat, dimensao);

            popularMatriz(mat, dimensao, visitados);

            for (int i = 0; i < visitados.Count; i++)
            {
                Console.WriteLine(visitados[i]);
            }
        }

        static void inicializaMatriz(int[,] mat, int dimensao)
        {
            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    mat[i, j] = 0;
                }
            }
        }

        static void exibirMatriz(int[,] mat, int dimensao)
        {
            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    Console.Write(" " + mat[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void popularMatriz(int[,] mat, int dimensao, List<String> visitados)
        {
            int linha, coluna;
            int repete = 0;
            String estado = "";

            do
            {
                Console.Write("Informe uma linha: ");
                linha = Int32.Parse(Console.ReadLine());
                if (linha < 0 || linha >= dimensao)
                {
                    Console.WriteLine("Deu xabuu!");
                    return;
                }
                Console.Write("Informe uma coluna: ");

                coluna = Int32.Parse(Console.ReadLine());
                if (coluna < 0 || coluna >= dimensao)
                {
                    Console.WriteLine("Deu xabuu!");
                    return;
                }

                mat[linha, coluna] = 1;

                //gerar o estado visitado
                estado = gerarString(mat, dimensao);

                if (EhValido(mat, linha, coluna, dimensao)) {
                    if (!visitados.Contains(estado))
                    {
                        visitados.Add(estado);
                        exibirMatriz(mat, dimensao);
                    }
                    else Console.WriteLine("Estado já produzido");
                } else
                {
                    mat[linha, coluna] = 0;
                    Console.WriteLine("Estaddo invalido");
                }

                


                repete++;
            } while (repete < 5);
        }

        static String gerarString(int[,] mat, int dimensao)
        {
            String estado = "";
            for (int i = 0; i < dimensao; i++)
            {
                for (int j = 0; j < dimensao; j++)
                {
                    estado = estado + mat[i, j];
                }
            }
            Console.WriteLine("String gerada do estado: " + estado);
            return estado;
        }

        static Boolean EhValido(int[,] mat, int linha, int coluna, int dimensao)
        {
            //analisando a linha
            int total = 0;
            for (int i = 0; i < dimensao; i++)
            {
                if (mat[linha,i] == 1)
                {
                    total++;
                }
                if (total > 1) return false;

            }
            //analisando a coluna
            total = 0;
            for (int i = 0; i < dimensao; i++)
            {
                if (mat[coluna, i] == 1)
                {
                    total++;
                }
                if (total > 1) return false;
            }


            //analisando a diagonal principal onde coluna >= linha
            if (coluna >= linha)
            {
                total = 0;
                int j = coluna - linha;
                for (int i = 0; i < dimensao && j < dimensao; i++, j++)
                {
                    if (mat[i, j] == 1)
                    {
                        total++;
                    }
                    if (total > 1) return false;
                }
            } else
            {
                total = 0;
                int j = 0;
                for (int i = linha - coluna; i < dimensao && j < dimensao; i++, j++)
                {
                    if (mat[i, j] == 1)
                    {
                        total++;
                    }
                    if (total > 1) return false;
                }
            }
            
            
            
            
            
            
            
            
            
            return true;

        }
    }
}
