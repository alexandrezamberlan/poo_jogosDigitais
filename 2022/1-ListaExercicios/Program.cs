using System;
using System.Collections.Generic;

namespace ListaExercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            //Personagem gandalf = new Personagem("Gandalf, The Grey", 10);
            //gandalf.exibirDados();

            //Personagem bilbo = new Personagem();   //construtor vazio
            //bilbo.Nome = "Bilbo Baggins";
            //bilbo.Poder = 2;

            //string nome;
            //int poder;
            //List<Personagem> lista = new List<Personagem>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Digite o nome do personagem: ");
            //    nome = Console.ReadLine();

            //    Console.Write("Digite o poder [0 10]: ");
            //    poder = Int32.Parse(Console.ReadLine());

            //    lista.Add(new Personagem(nome, poder));
            //}

            ////for (int i = 0; i < lista.Count; i++)
            ////{
            ////    lista[i].exibirDados();
            ////}


            //Console.WriteLine("Lista de personagens cadastrados!!");
            //foreach (var i in lista)
            //{
            //    i.exibirDados();
            //}


            ////a chamada do método maisPoderoso() está associada 'a classe, pois é um método de classe
            //Personagem poderoso = Personagem.maisPoderoso(lista);

            //Console.WriteLine("Personagem mais poderoso!!");
            //poderoso.exibirDados();


            List<Animal> listaAnimais = new List<Animal>();
            Console.WriteLine("Cadastrando animais!!");
            string nome;
            string tipo;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite nome do seu animal de estimação: ");
                nome = Console.ReadLine().ToUpper();

                do
                {
                    Console.Write("Digite tipo do seu animal de estimação: [Gato, Cachorro ou Peixe]: ");
                    tipo = Console.ReadLine().ToUpper();
                    
                    if (tipo == "PEIXE" || tipo == "CACHORRO" || tipo == "GATO")
                    {
                        break;
                    }

                } while (true);

                listaAnimais.Add( new Animal(nome,tipo) );
            }


       

            foreach (var i in listaAnimais)
            {
                Console.WriteLine(i.Nome + " - " + i.Tipo);
            }
            


        }
    }
}
