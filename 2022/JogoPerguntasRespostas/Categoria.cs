using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPerguntasRespostas
{
    class Categoria
    {
        string descricao;
        int codigo;
        string sigla;

        public string Descricao { get => descricao; set => descricao = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Sigla { get => sigla; set => sigla = value; }

        public Categoria(string descricao, int codigo, string sigla)
        {
            this.Descricao = descricao;
            this.Codigo = codigo;
            this.Sigla = sigla;
        }

        public Categoria(string descricao, int codigo)
        {
            this.Descricao = descricao;
            this.Codigo = codigo;
        }

        public override string ToString()
        {
            return "Código: " + this.codigo + " - " + "Descrição: " + this.descricao;
        }



        public static int qualPosicao(string categoria, List<Categoria> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Descricao.ToUpper().Equals(categoria.ToUpper()))
                {
                    return i;
                }
            }
            //categoria não encontrada, retornar -27
            return -27;
        }

        public static void mostrar(List<Categoria> lista)
        {
            Console.Write("Categorias cadastradas: ");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write(lista[i].Descricao + ", ");
            }
            Console.WriteLine();
        }
    }
}
