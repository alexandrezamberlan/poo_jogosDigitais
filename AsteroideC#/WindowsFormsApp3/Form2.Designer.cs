namespace WindowsFormsApp3
{
   partial class Form2
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.button_asteroide1 = new System.Windows.Forms.Button();
         this.button_asteroide2 = new System.Windows.Forms.Button();
         this.button_asteroide3 = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
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
         // button_asteroide2
         // 
         this.button_asteroide2.Location = new System.Drawing.Point(122, 12);
         this.button_asteroide2.Name = "button_asteroide2";
         this.button_asteroide2.Size = new System.Drawing.Size(75, 23);
         this.button_asteroide2.TabIndex = 1;
         this.button_asteroide2.Text = "asteroide2";
         this.button_asteroide2.UseVisualStyleBackColor = true;
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
         // panel1
         // 
         this.panel1.Controls.Add(this.button_asteroide1);
         this.panel1.Controls.Add(this.button_asteroide3);
         this.panel1.Controls.Add(this.button_asteroide2);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(315, 432);
         this.panel1.TabIndex = 3;
         // 
         // Form2
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(315, 432);
         this.Controls.Add(this.panel1);
         this.Name = "Form2";
         this.Text = "Jogo Asteroides";
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button button_asteroide1;
      private System.Windows.Forms.Button button_asteroide2;
      private System.Windows.Forms.Button button_asteroide3;
      private System.Windows.Forms.Panel panel1;
   }
}