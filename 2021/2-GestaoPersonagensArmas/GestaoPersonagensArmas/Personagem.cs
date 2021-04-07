using System;
using System.Collections.Generic;

namespace GestaoPersonagensArmas
{
    public class Personagem
    {
        //visibilidade pública, ou acessível por todos os códigos
        public int codigo;
        public String descricao;
        public String nome;
        public List<Arma> inventario;
        public int healthPoints;

        public Personagem(int codigo, string descricao, string nome)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.nome = nome;
            this.inventario = new List<Arma>();
            this.healthPoints = 0;
        }

        //método de objeto/instancia
        public void mostrarMeusDados()
        {
            Console.WriteLine("Sou o personagem: " + this.nome);
            Console.WriteLine("Meu código é    : " + this.codigo);
            Console.WriteLine("Descrição       : " + this.descricao);
            Console.WriteLine("Nível de vida   : " + this.healthPoints);
            Console.WriteLine("Inventário: ");
            for (int i = 0; i < this.inventario.Count; i++)
            {
                Console.WriteLine("Código          : " + inventario[i].codigo);
                Console.WriteLine("Descrição       : " + inventario[i].descricao);
                Console.WriteLine("Nome            : " + inventario[i].nome);
                Console.WriteLine("Poder destruição: " + inventario[i].poderDestruicao);
                Console.WriteLine();
            }
        }
    }
}
