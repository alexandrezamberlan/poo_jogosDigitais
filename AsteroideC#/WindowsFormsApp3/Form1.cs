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
   public partial class Form1 : Form
   {
      Thread thread1, thread2, thread3;
      public Form1() {
         InitializeComponent();
         thread1 = new Thread(new ThreadStart(inicializaAsteroide1));
      }

      private void button1_Click(object sender, EventArgs e)
      {
         int tamanho = int.Parse(textBox_qtdAsteroides.Text);
         Util.gerarListaAsteroide(lista, tamanho);
         Util.listarAsteroides(lista, textBox_asteroides);
      }

      private void button_ordena_Click(object sender, EventArgs e)
      {
         Util.ordenarPorColuna(lista);
         Util.listarAsteroides(lista, textBox_asteroides);
      }

      List<Asteroide> lista = new List<Asteroide>();
      
      private void button_jogar_Click(object sender, EventArgs e)
      {
         if (lista.Count() == 0)
         {
            MessageBox.Show("Não há asteróides gerados", "Atenção");
         } else
         {
           thread1.Start();
           thread2 = new Thread(new ThreadStart(inicializaAsteroide2));
           thread2.Start();  
           thread3 = new Thread(new ThreadStart(inicializaAsteroide3));
           thread3.Start(); 
         }
      }

      private void inicializaAsteroide1()
      {
         int y = button_asteroide1.Location.Y;
         int x = button_asteroide1.Location.X;

         while (y < panel1.Height - 10)
         {
            y += 10;
            button_asteroide1.SetBounds(x,
                                        y,
                                        button_asteroide1.Width,
                                        button_asteroide1.Height);
            Thread.Sleep(200);
         }
      }
      private void inicializaAsteroide2()
      {
         int y = button_asteroide2.Location.Y;
         int x = button_asteroide2.Location.X;

         while (y < panel1.Height - 10)
         {
            y += 10;
            button_asteroide2.SetBounds(x,
                                        y,
                                        button_asteroide2.Width,
                                        button_asteroide2.Height);
            Thread.Sleep(100);
         }
      }

      private void inicializaAsteroide3()
      {
         int y = button_asteroide3.Location.Y;
         int x = button_asteroide3.Location.X;

         while (y < panel1.Height - 10)
         {
            y += 10;
            button_asteroide3.SetBounds(x,
                                        y,
                                        button_asteroide3.Width,
                                        button_asteroide3.Height);
            Thread.Sleep(400);
         }
      }
   }   
}
