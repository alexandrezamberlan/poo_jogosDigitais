using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPerguntasRespostas
{
    class Nivel
    {
        string descricao;
        int pontuacao;

        public Nivel(string descricao, int pontuacao)
        {
            this.Descricao = descricao.ToUpper();
            this.Pontuacao = pontuacao;
        }

        public string Descricao { get => descricao; set => descricao = value; }
        public int Pontuacao { get => pontuacao; set => pontuacao = value; }

        public override string ToString()
        {
            return "Nível: " + this.descricao + " - " + "Pontuação: " + this.pontuacao;
        }

        public static int qualPosicao(string nivel, List<Nivel> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Descricao.ToUpper().Equals(nivel.ToUpper()))
                {
                    return i;
                }
            }
            return -27; //nivel não localizado
        }

        public static void mostrar(List<Nivel> lista)
        {
            Console.WriteLine("Níveis cadastradas: ");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write(lista[i] + ",");
            }
            Console.WriteLine();

        }
    }
}
