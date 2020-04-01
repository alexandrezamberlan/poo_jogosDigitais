using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
   class Util
   {
      public static void ordenarPorColuna(List<Asteroide> lista)
      {
         //bolha
         Boolean houveTroca;
         Asteroide a;
         int i;
         do
         {
            houveTroca = false;
            for (i = 0; i < lista.Count() - 1; i++)
            {
               if (lista[i].posC > lista[i + 1].posC)
               {
                  houveTroca = true;
                  a = lista[i];
                  lista[i] = lista[i + 1];
                  lista[i + 1] = a;
               }
            }
         } while (houveTroca);

      }
      public static void gerarListaAsteroide(List<Asteroide> lista, int n)
      {
         Asteroide umAsteroide;
         int velocidade, tamanho, posL, posC;

         Random gerador = new Random();

         for (int i = 0; i < n; i++)
         {
            velocidade = gerador.Next(11);
            tamanho = gerador.Next(11);
            posL = 0;
            posC = gerador.Next(600);
            umAsteroide = new Asteroide(velocidade, tamanho, posL, posC);
            lista.Add(umAsteroide);
         }
      }

      public static void listarAsteroides(List<Asteroide> lista, TextBox textBox)
      {
         textBox.Clear();
         textBox.AppendText("Exibindo asteroides\n");
         textBox.AppendText("---------------------------\n");
         for (int i = 0; i < lista.Count(); i++)
         {
            textBox.AppendText("Asteroide " + i + "\n");
            textBox.AppendText("Velocidade: " + lista[i].velocidade + "\n");
            textBox.AppendText("Tamanho: " + lista[i].tamanho + "\n");
            textBox.AppendText("Linha: " + lista[i].posL + "\n");
            textBox.AppendText("Coluna: " + lista[i].posC + "\n");
            textBox.AppendText("---------------------------\n");
         }

         //Console.WriteLine("Exibindo asteroides");
         //Console.WriteLine("---------------------------");
         //for (int i = 0; i < lista.Count(); i++)
         //{
         //   Console.WriteLine("Velocidade: " + lista[i].velocidade);
         //   Console.WriteLine("Tamanho: " + lista[i].tamanho);
         //   Console.WriteLine("Linha: " + lista[i].posL);
         //   Console.WriteLine("Coluna: " + lista[i].posC);
         //   Console.WriteLine("---------------------------");
         //}
      }
   }
}