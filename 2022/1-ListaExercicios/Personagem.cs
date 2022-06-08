using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios
{
//Implemente um programa em C# no qual o usuário deverá informar o nome e o poder (0 a 10) de três personagens. 
//O programa deverá informar o nome do personagem que possuir o maior poder.

//Regras que deverão ser seguidas para a implementação do algoritmo:

//É obrigatório o uso de classe para representar um Personagem e a mesma deverá possuir como propriedades (características) um nome e um poder.
//A classe também deverá possuir um método chamado ExibirDados.Esse método deverá exibir o nome e o poder do personagem em questão.
//Ao implementar a classe é obrigatório implementar dois construtores (Sobrecarga), um que não recebe parâmetro algum e outro que
//irá receber o nome e o poder de um personagem
    class Personagem
    {
        string nome;
        int poder; //0 a 10

        public Personagem()
        {

        }

        public Personagem(string nome, int poder)
        {
            this.nome = nome;
            this.poder = poder;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Poder { get => poder; set => poder = value; }

        public void exibirDados()
        {
            Console.WriteLine(Nome + " - " + Poder);
        }

        //metodo de classe, ou seja, soh a classe Personagem pode invoca-lo ou chama-lo
        public static Personagem maisPoderoso(List<Personagem> lista)
        {
            Personagem poderoso = new Personagem();
            //assumir que o primeiro personagem é o mais poderoso
            poderoso.Nome = lista[0].Nome;
            poderoso.Poder = lista[0].Poder;

            foreach (var i in lista)
            {
                if (i.Poder > poderoso.Poder)
                {
                    poderoso.Nome = i.Nome;
                    poderoso.Poder = i.Poder;
                }
            }
            return poderoso;
        }
    }
}
