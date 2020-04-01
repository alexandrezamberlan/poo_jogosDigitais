using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
   class Asteroide
   {
      public int velocidade, tamanho, posL, posC;

      public Asteroide()
      {
         this.velocidade = 0;
         this.tamanho = 0;
         this.posC = 0;
         this.posL = 0;
      }
      public Asteroide(int velocidade, int tamanho, int posL, int posC)
      {
         this.velocidade = velocidade;
         this.tamanho = tamanho;
         this.posL = posL;
         this.posC = posC;
      }
   }
}
