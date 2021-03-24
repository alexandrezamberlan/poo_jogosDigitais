using System;
namespace _4_jogoDaForca
{
    public class Jogador
    {
        public string nome;
        public int pontuacao;

        public Jogador(string nome)
        {
            this.nome = nome.ToUpper();
            this.pontuacao = 0;
        }

        public override bool Equals(object obj)
        {
            return obj is Jogador jogador &&
                   nome == jogador.nome;
        }
    }
}
