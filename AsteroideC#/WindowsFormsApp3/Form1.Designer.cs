namespace WindowsFormsApp3
{
   partial class Form1
   {
      /// <summary>
      /// Variável de designer necessária.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Limpar os recursos que estão sendo usados.
      /// </summary>
      /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Código gerado pelo Windows Form Designer

      /// <summary>
      /// Método necessário para suporte ao Designer - não modifique 
      /// o conteúdo deste método com o editor de código.
      /// </summary>
      private void InitializeComponent() {
         this.label4 = new System.Windows.Forms.Label();
         this.textBox_qtdAsteroides = new System.Windows.Forms.TextBox();
         this.button_executa = new System.Windows.Forms.Button();
         this.textBox_asteroides = new System.Windows.Forms.TextBox();
         this.button_ordena = new System.Windows.Forms.Button();
         this.button_jogar = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.button_asteroide1 = new System.Windows.Forms.Button();
         this.button_asteroide3 = new System.Windows.Forms.Button();
         this.button_asteroide2 = new System.Windows.Forms.Button();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(8, 19);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(176, 13);
         this.label4.TabIndex = 4;
         this.label4.Text = "Informe a quantidade de asteroides:";
         // 
         // textBox_qtdAsteroides
         // 
         this.textBox_qtdAsteroides.Location = new System.Drawing.Point(190, 12);
         this.textBox_qtdAsteroides.Name = "textBox_qtdAsteroides";
         this.textBox_qtdAsteroides.Size = new System.Drawing.Size(100, 20);
         this.textBox_qtdAsteroides.TabIndex = 5;
         // 
         // button_executa
         // 
         this.button_executa.Location = new System.Drawing.Point(11, 50);
         this.button_executa.Name = "button_executa";
         this.button_executa.Size = new System.Drawing.Size(75, 23);
         this.button_executa.TabIndex = 6;
         this.button_executa.Text = "Executa";
         this.button_executa.UseVisualStyleBackColor = true;
         this.button_executa.Click += new System.EventHandler(this.button1_Click);
         // 
         // textBox_asteroides
         // 
         this.textBox_asteroides.Location = new System.Drawing.Point(11, 79);
         this.textBox_asteroides.Multiline = true;
         this.textBox_asteroides.Name = "textBox_asteroides";
         this.textBox_asteroides.ReadOnly = true;
         this.textBox_asteroides.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.textBox_asteroides.Size = new System.Drawing.Size(279, 371);
         this.textBox_asteroides.TabIndex = 7;
         // 
         // button_ordena
         // 
         this.button_ordena.Location = new System.Drawing.Point(111, 50);
         this.button_ordena.Name = "button_ordena";
         this.button_ordena.Size = new System.Drawing.Size(83, 23);
         this.button_ordena.TabIndex = 8;
         this.button_ordena.Text = "Ordena";
         this.button_ordena.UseVisualStyleBackColor = true;
         this.button_ordena.Click += new System.EventHandler(this.button_ordena_Click);
         // 
         // button_jogar
         // 
         this.button_jogar.Location = new System.Drawing.Point(215, 50);
         this.button_jogar.Name = "button_jogar";
         this.button_jogar.Size = new System.Drawing.Size(75, 23);
         this.button_jogar.TabIndex = 9;
         this.button_jogar.Text = "Joga";
         this.button_jogar.UseVisualStyleBackColor = true;
         this.button_jogar.Click += new System.EventHandler(this.button_jogar_Click);
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.button_asteroide1);
         this.panel1.Controls.Add(this.button_asteroide3);
         this.panel1.Controls.Add(this.button_asteroide2);
         this.panel1.Location = new System.Drawing.Point(296, 3);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(399, 447);
         this.panel1.TabIndex = 10;
         // 
         // button_asteroide1
         // 
         this.button_asteroide1.Location = new System.Drawing.Point(12, 12);
         this.button_asteroide1.Name = "button_asteroide1";
         this.button_asteroide1.Size = new System.Drawing.Size(75, 23);
         this.button_asteroide1.TabIndex = 0;
         this.button_asteroide1.Text = "asteroide1";
         this.button_asteroide1.UseVisualStyleBackColor = true;
         // 
         // button_asteroide3
         // 
         this.button_asteroide3.Location = new System.Drawing.Point(228, 12);
         this.button_asteroide3.Name = "button_asteroide3";
         this.button_asteroide3.Size = new System.Drawing.Size(75, 23);
         this.button_asteroide3.TabIndex = 2;
         this.button_asteroide3.Text = "asteroide3";
         this.button_asteroide3.UseVisualStyleBackColor = true;
         // 
         // button_asteroide2
         // 
         this.button_asteroide2.Location = new System.Drawing.Point(122, 12);
         this.button_asteroide2.Name = "button_asteroide2";
         this.button_asteroide2.Size = new System.Drawing.Size(75, 23);
         this.button_asteroide2.TabIndex = 1;
         this.button_asteroide2.Text = "asteroide2";
         this.button_asteroide2.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(696, 450);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.button_jogar);
         this.Controls.Add(this.button_ordena);
         this.Controls.Add(this.textBox_asteroides);
         this.Controls.Add(this.button_executa);
         this.Controls.Add(this.textBox_qtdAsteroides);
         this.Controls.Add(this.label4);
         this.Name = "Form1";
         this.Text = "Jogo Asteroides - Gestão";
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox textBox_qtdAsteroides;
      private System.Windows.Forms.Button button_executa;
      private System.Windows.Forms.TextBox textBox_asteroides;
      private System.Windows.Forms.Button button_ordena;
      private System.Windows.Forms.Button button_jogar;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button button_asteroide1;
      private System.Windows.Forms.Button button_asteroide3;
      private System.Windows.Forms.Button button_asteroide2;
   }
}

