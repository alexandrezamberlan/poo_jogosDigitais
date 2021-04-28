using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Perguntas_Respostas
{
    public class Util
    {
        public static void carregandoArquivos(List<Area> listaDeAreas, List<PerguntaResposta> listaDePerguntasRespostas)
        {
            //areas.dad - arquivo contendo as áreas
            StreamReader leitor = new StreamReader("areas.dad", Encoding.UTF8); //abre o arquivo para leitura

            //if (leitor == null)
            //{
            //    Console.WriteLine("Arquivo de áreas não localizado!");
            //} 

            //primeira repetição pega todas as frases do arquivo lido e jogo na lista frasesLidas
            List<string> frasesLidas = new List<string>();
            do
            {
                frasesLidas.Add(leitor.ReadLine());

            } while (!leitor.EndOfStream);

            leitor.Close(); //fecha o objeto que representa o arquivo

          
            String[] resposta;
            //na segunda repetição, pega cada frase lida, splita pelo @ e separa codigo e descricao
            for (int i = 0; i < frasesLidas.Count; i++)
            {
                //nome de um aluno@curso do aluno
                resposta = frasesLidas[i].Split("@");
                

                listaDeAreas.Add(new Area(Int32.Parse( resposta[0] ), resposta[1].ToUpper()));
            }


            //perguntas-respostas.dad - arquivo contendo perguntas e respostas
            leitor = new StreamReader("perguntas-respostas.dad", Encoding.UTF8); //abre o arquivo para leitura
            frasesLidas.Clear();

            do
            {
                frasesLidas.Add(leitor.ReadLine());

            } while (!leitor.EndOfStream);

            leitor.Close(); //fecha o objeto que representa o arquivo

            Area areaTmp;
            for (int i = 0; i < frasesLidas.Count; i++)
            {
                //nome de um aluno@curso do aluno
                resposta = frasesLidas[i].Split("@");

                areaTmp = new Area(000,resposta[2]);
                listaDePerguntasRespostas.Add(new PerguntaResposta(resposta[0].ToUpper(),
                    resposta[1].ToUpper(),
                    areaTmp,
                    Int32.Parse( resposta[3]) ));
            }
        }
    }
}
