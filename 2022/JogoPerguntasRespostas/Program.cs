using System;
using System.Collections.Generic;

namespace JogoPerguntasRespostas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            listaCategorias.Add(new Categoria("Games", 1));
            listaCategorias.Add(new Categoria("Esportes", 2));
            listaCategorias.Add(new Categoria("Geografia", 3));

            List<Nivel> listaNiveis = new List<Nivel>();
            listaNiveis.Add(new Nivel("Fácil", 1));
            listaNiveis.Add(new Nivel("Médio", 3));
            listaNiveis.Add(new Nivel("Difícil", 5));

            int posicaoCategoria;
            do
            {
                Categoria.mostrar(listaCategorias);
                Console.Write("Informe categoria: ");
                string categoria = Console.ReadLine();
                posicaoCategoria = Categoria.qualPosicao(categoria, listaCategorias);
            } while (posicaoCategoria == -27);

            int posicaoNivel;
            do
            {
                Nivel.mostrar(listaNiveis);
                Console.Write("Informe nível: ");
                string nivel = Console.ReadLine();
                posicaoNivel = Nivel.qualPosicao(nivel, listaNiveis);
            } while (posicaoNivel == -27);

            Console.Write("Digite a pergunta que deseja cadastrar: ");
            string pergunta = Console.ReadLine();

            Console.Write("Digite a resposta da pergunta cadastrada: ");
            string resposta = Console.ReadLine();

            PerguntaResposta objeto = new PerguntaResposta(pergunta, resposta, 
                listaCategorias[posicaoCategoria], listaNiveis[posicaoNivel]);

            List<PerguntaResposta> listaPerguntasRespostas = new List<PerguntaResposta>();
            listaPerguntasRespostas.Add(objeto);


            Console.WriteLine(objeto);

            //PerguntaResposta.mostrar(listaPerguntasRespostas);



        }
    }
}
