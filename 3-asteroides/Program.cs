using System;
using System.Collections.Generic;

namespace _1_jogos
{
    class Program
    {        
        static List<Asteroide> listaAsteroides = new List<Asteroide>();
        static List<Barreira> listaBarreiras = new List<Barreira>();

        static void populaListaAsteroides(int qtd) 
        {
            for (int i = 0; i < qtd; i++) 
            {
                listaAsteroides.Add(new Asteroide(600,800));
            }
        }

        static void exibeListaAsteroides()
        {
            Console.WriteLine("Lista de asteroides gerados (x,y,altura,largura,velocidade):");
            for (int i = 0; i < listaAsteroides.Count; i++)
            {
                Console.WriteLine("Asteroide " + (i+1) + ": " + listaAsteroides[i].posX + ","+ 
                                  listaAsteroides[i].posY + ","+ 
                                  listaAsteroides[i].altura + ","+
                                  listaAsteroides[i].largura + ","+ 
                                  listaAsteroides[i].velocidade);
                Console.WriteLine("============================");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Jogo dos Asteróides");
            //definir quantos asteróides o sistema irá trabalhar
            int quantidadeAsteroides;
            Console.Write("Quantos asteróides deseja?  ");
            quantidadeAsteroides = Int32.Parse(Console.ReadLine());
            
            //gerar e armazenar asteróides em lista
            //(posições, tamanhos e velocidades gerados aleatoriamente)
            populaListaAsteroides(quantidadeAsteroides);
            //exibir os dados de cada asteróide (x,y,tamanho,velocidade)
            exibeListaAsteroides();

            //gerar e armazenar barreiras em lista

            

            //exibir os dados de cada barreira (x,y,tamanho)
        }


    }
}
