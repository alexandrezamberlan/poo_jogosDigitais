using System;
namespace Perguntas_Respostas
{
    public class Jogador
    {
        public int codigo;
        public String nome;
        public int pontuacao;

        public Jogador(int codigo, string nome, int pontuacao)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.pontuacao = pontuacao;
        }
    }
}
