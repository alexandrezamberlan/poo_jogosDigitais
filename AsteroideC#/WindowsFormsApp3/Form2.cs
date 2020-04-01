using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
   public partial class Form2 : Form
   {
      public Form2()
      {
         InitializeComponent();
         Thread.Sleep(2000);
         inicializaJogo();

      }

      private void inicializaJogo()
      {
         int y = button_asteroide1.Location.Y;
         int x = button_asteroide1.Location.X;
         

         while (y < panel1.Height - 100)
         {
            y += 10;
            button_asteroide1.SetBounds(x,
                                        y,
                                        button_asteroide1.Width,
                                        button_asteroide1.Height);
            Thread.Sleep(500);
         }

      }
   }
}
