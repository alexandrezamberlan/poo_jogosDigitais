using System;
using System.Collections.Generic;

namespace _1_Construtor
{
    public class Revisao
    {
        //a palavra reservada static mostra que um método ou um atributo é da Classe
        //ou seja, para chamar este método ou um atributo é preciso ser uma Classe
        public static void revisar()
        {
            //revisão
            //1 - Classe Console
            //1.1 -> método de classe WriteLine -> escreve no console/terminal

            Console.WriteLine("Aula de revisão");

            //1.2 -> método de classe ReadLine -> captura o que o usuário digitar
            Console.Write("Digite uma frase: ");
            String frase = Console.ReadLine();
            Console.WriteLine("A frase digitada foi: " + frase);

            //2 - Classe Int32
            //2.1 -> método parse que converte um String para um inteiro 32 bits
            Console.Write("Digite sua idade em anos: ");
            int idade = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Você já dormiu " + (int)(idade / 3) + " anos");


            //3 - métodos/atributos de objetos/instâncias do tipo String
            //3.1 - atributo Length
            Console.WriteLine("A frase digitada possui " + frase.Length + " caracteres");

            //3.2 - método ToUpper()

            frase = frase.ToUpper();
            Console.WriteLine("Frase em maiíusculo: " + frase);

            //4 - Classe List<tipo>
            //4.1 -> método de instância/objeto Add() -> adiciona um objeto na lista
            List<String> listaFrases = new List<string>();

            //listaFrases.Add("primeira frase");
            //listaFrases.Add("segunda frase");
            //listaFrases.Add("outra frase");
            //listaFrases.Add(frase);

            do
            {
                Console.Write("Digite uma frase: ");
                frase = Console.ReadLine();

                if (frase.Equals("sair"))
                {
                    break;
                }


                listaFrases.Add(frase.ToUpper());
            } while (true);


            //4.2 - -> atributo de instância/objeto Count() -> conta quantos elementos há na lista
            Console.WriteLine("A lista possui " + listaFrases.Count + " elementos cadastrados");

            for (int i = 0; i < listaFrases.Count; i++)
            {
                Console.WriteLine(listaFrases[i]);
            }
        }



        public static void metodoDeClasse()
        {
            Console.Write("Estamos executando um método de classe\n");
        }

        public void metodoDeObjeto()
        {
            Console.Write("Estamos executando um método de objeto\n");
        }
    }
}
