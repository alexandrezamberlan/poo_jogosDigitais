using System;
using System.Collections.Generic;

namespace _1_Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            //chamando um método de classe
            //Revisao.metodoDeClasse();

            //chamando um método de objeto
            //Revisao objeto = new Revisao();
            //objeto.metodoDeObjeto();

            Jogador um = new Jogador("Alexandre", -90);
            Jogador dois = new Jogador("Carlos", 1000);
            Jogador tres = new Jogador("Daini");


            Console.WriteLine("Jogador um: " + um.pegarNome() + "  -  " + um.pontuacao);
            Console.WriteLine("Jogador dois: " + dois.pegarNome() + "  -  " + dois.pontuacao); 
            Console.WriteLine("Jogador três: " + tres.pegarNome() + "  -  " + tres.pontuacao);


            //PROIBIDO -> um.Nome = "Alexandre Zamberlan";
            um.pontuacao = -90;

            Console.WriteLine("Jogador um: " + um.pegarNome() + "  -  " + um.pontuacao);


            List<Jogador> listaJogadores = new List<Jogador>();
        }
    }
}
