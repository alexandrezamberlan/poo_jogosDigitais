using System;
using System.Collections.Generic;

namespace _1_jogos
{
    class Program
    {
        static List<Autor> listaAutores = new List<Autor>();

        static void exibirLista(List<Autor> lista){
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].identificador + " - " + lista[i].nome);
                Console.WriteLine("-------------------------------");
            }

        }

        static bool jaExiste(int matricula, List<Autor> lista) {
            for (int i = 0; i < lista.Count; i++)
            {
                if (matricula == lista[i].identificador) {
                    //já cadastrado
                    return true;
                }
            }
            return false;
        }

        static void gestaoAutores() {
            int matricula;
            string nome;

            Console.Write("Digite a matricula do autor: ");
            matricula = Int32.Parse(Console.ReadLine());

            if (!jaExiste(matricula,listaAutores)) {
                Console.Write("Digite nome do autor: ");
                nome = Console.ReadLine();
                
                listaAutores.Add(new Autor(matricula,nome));
                exibirLista(listaAutores);
            } else {
                Console.WriteLine("Matrícula já existe. Quer excluir [s/n]?");
                char op = Char.Parse(Console.ReadLine());
                if (op == 's' || op == 'S') {
                    //excluir


                }

            }
        }

        static void menu() {
            int op;
            do {
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Gestão de autores");
                Console.WriteLine("2 - Gestão de áudio");
                Console.WriteLine("3 - Gestão de ????");
                Console.WriteLine("5 - Sair sistema");
                Console.WriteLine("Opção: ");
                op = Int32.Parse( Console.ReadLine() );
            

                switch (op) {
                    case 1 : 
                            Console.WriteLine("GESTÃO DE AUTORES");
                            gestaoAutores();
                            break;
                    case 2 : 
                            Console.WriteLine("GESTÃO DE MÍDIAS");
                            //..
                            break; 
                    case 5 : 
                            Console.WriteLine("Obrigado por usar o sistema");
                            break;               
                    // default : Console.WriteLine("Opção inválida");            
                }
            } while (op != 5);
        }
        
        static void Main(string[] args)
        {

            Console.WriteLine("SISTEMA DE CONTROLE DE MIDIAS EM JOGOS");
            menu();
        }


    }
}
