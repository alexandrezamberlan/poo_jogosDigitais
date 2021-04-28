using System;
namespace Perguntas_Respostas
{
    public class PerguntaResposta
    {
        public String pergunta;
        public String resposta;
        public Area categoria;
        public int grauDificuldade;

        public PerguntaResposta(string pergunta, string resposta, Area categoria, int grauDificuldade)
        {
            this.pergunta = pergunta;
            this.resposta = resposta;
            this.categoria = categoria;
            this.grauDificuldade = grauDificuldade;
        }

        public PerguntaResposta(string pergunta, string resposta)
        {
            this.pergunta = pergunta;
            this.resposta = resposta;
            this.categoria = new Area();
            this.grauDificuldade = 0;
        }
    }
}
