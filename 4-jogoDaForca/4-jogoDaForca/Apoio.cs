using System;
using System.Collections.Generic;

namespace _4_jogoDaForca
{
    public class Apoio
    {
        static public void carregarPalavras(List<Palavra> lista)
        {
            string palavra, categoria;
            char opcao;
            do
            {
                Console.Write("Palavra: ");
                palavra = Console.ReadLine();

                Console.Write("Categoria (fruta ou país): ");
                categoria = Console.ReadLine();

                lista.Add(new Palavra(palavra, categoria));

                Console.Write("Continuar [S / N]? ");
                opcao = char.Parse(Console.ReadLine().ToUpper());

            } while (opcao != 'N');

            Console.WriteLine("Foram cadastradas " + lista.Count + " palavras");
        }

        static public void mostrarPalavras(List<Palavra> lista)
        {
            Console.WriteLine("Palavras cadastradas");
            Console.WriteLine("___________________________________________");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("Palavra: " + lista[i].texto +
                    " - Categoria: " + lista[i].categoria);
                Console.WriteLine("___________________________________________");
            }
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
    }
}
