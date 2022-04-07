using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios
{
//Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
//O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

//Regras que deverão ser seguidas para a implementação do programa:

//Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
//Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
//É obrigatório criar uma classe para representar o Animal.
//A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
//A classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir que o usuário armazene/leia os dados dos dois dados privados(propriedades).
    class Animal
    {
        string nome;
        string tipo;
        public static string[] tiposValidos =
        {
            "GATO",
            "CACHORRO",
            "PEIXE",
            "TARTARUGA"
        };

        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; }

        public Animal(string nome, string tipo)
        {
            this.nome = nome;
            this.tipo = tipo;
        }
    }
}
