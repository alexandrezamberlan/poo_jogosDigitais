using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPerguntasRespostas
{
    class PerguntaResposta
    {
        string pergunta;
        string resposta;
        Categoria categoria;
        Nivel nivel;

        public PerguntaResposta(string pergunta, string resposta, Categoria categoria, Nivel nivel)
        {
            this.pergunta = pergunta;
            this.resposta = resposta;
            this.categoria = categoria;
            this.nivel = nivel;
        }

        public string Pergunta { get => pergunta; set => pergunta = value; }
        public string Resposta { get => resposta; set => resposta = value; }
        internal Categoria Categoria { get => categoria; set => categoria = value; }
        internal Nivel Nivel { get => nivel; set => nivel = value; }

        public override string ToString()
        {
            return "Pergunta: " + this.pergunta + " - Categoria: " + this.categoria.Descricao + " -" + this.nivel;
        }
    }
}
