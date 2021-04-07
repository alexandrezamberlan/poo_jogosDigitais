using System;
namespace GestaoPersonagensArmas
{
    public class Arma
    {
        //visibilidade pública, ou seja, acessíveis em qq lugar do sistema
        public int codigo;
        public String descricao;
        public String nome;
        public int poderDestruicao;

        //construtor com 4 parametros
        public Arma(int codigo, string descricao, string nome, int poderDestruicao)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.nome = nome;
            this.poderDestruicao = poderDestruicao;
        }

        //construtor sobrecarregado com 3 parâmetros
        public Arma(int codigo, string descricao, string nome)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.nome = nome;
            this.poderDestruicao = 0; //valor mínimo
        }
    }
}
