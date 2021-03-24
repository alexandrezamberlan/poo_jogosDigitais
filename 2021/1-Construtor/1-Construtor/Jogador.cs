using System;
namespace _1_Construtor
{
    public class Jogador
    {
        String nome; //tem visibilidade privada
        public int pontuacao;

        //método para acessar o nome e retornar seu valor
        public String pegarNome()
        {
            return this.nome;
        }


        //construtor vazio
        public Jogador()
        {

        }

        //construtor que inicializa as duas variáveis
        public Jogador(String nome, int pontuacao)
        {
            this.nome = nome;
            this.pontuacao = pontuacao;
        }

        //construtor que inicializa nome e a pontuacao com zero
        public Jogador(String nome)
        {
            this.nome = nome;
            this.pontuacao = 0;
        }

    }
}
