using System;
using System.Windows.Forms;

namespace ExtrairPdfEoutrasMidias
{
    partial class Form1
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
            this.Bt_Browser = new System.Windows.Forms.Button();
            this.Bt_Start = new System.Windows.Forms.Button();
            this.Tb_Caminho = new System.Windows.Forms.TextBox();
            this.Tb_Resultado = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Bt_Browser
            // 
            this.Bt_Browser.Location = new System.Drawing.Point(13, 13);
            this.Bt_Browser.Name = "Bt_Browser";
            this.Bt_Browser.Size = new System.Drawing.Size(75, 23);
            this.Bt_Browser.TabIndex = 0;
            this.Bt_Browser.Text = "Browser";
            this.Bt_Browser.UseVisualStyleBackColor = true;
            this.Bt_Browser.Click += new System.EventHandler(this.Bt_Browser_Click);
            // 
            // Bt_Start
            // 
            this.Bt_Start.Location = new System.Drawing.Point(13, 42);
            this.Bt_Start.Name = "Bt_Start";
            this.Bt_Start.Size = new System.Drawing.Size(827, 23);
            this.Bt_Start.TabIndex = 1;
            this.Bt_Start.Text = "Start";
            this.Bt_Start.UseVisualStyleBackColor = true;
            this.Bt_Start.Click += new System.EventHandler(this.Bt_Start_Click);
            // 
            // Tb_Caminho
            // 
            this.Tb_Caminho.Location = new System.Drawing.Point(94, 13);
            this.Tb_Caminho.Multiline = true;
            this.Tb_Caminho.Name = "Tb_Caminho";
            this.Tb_Caminho.Size = new System.Drawing.Size(746, 23);
            this.Tb_Caminho.TabIndex = 2;
            this.Tb_Caminho.Text = "Digite o caminho aqui ou procure no browser com o botão ao lado";
            this.Tb_Caminho.Click += new System.EventHandler(this.Tb_Caminho_Click);
            this.Tb_Caminho.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tb_Caminho_MouseClick);
            this.Tb_Caminho.TextChanged += new System.EventHandler(this.Tb_Caminho_TextChanged);
            // 
            // Tb_Resultado
            // 
            this.Tb_Resultado.Location = new System.Drawing.Point(13, 71);
            this.Tb_Resultado.Multiline = true;
            this.Tb_Resultado.Name = "Tb_Resultado";
            this.Tb_Resultado.Size = new System.Drawing.Size(827, 315);
            this.Tb_Resultado.TabIndex = 3;
            this.Tb_Resultado.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 398);
            this.Controls.Add(this.Tb_Resultado);
            this.Controls.Add(this.Tb_Caminho);
            this.Controls.Add(this.Bt_Start);
            this.Controls.Add(this.Bt_Browser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Tb_Caminho_TextChanged(object sender, EventArgs e)
        {
        }

        private void Tb_Caminho_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Button Bt_Browser;
        private System.Windows.Forms.Button Bt_Start;
        private System.Windows.Forms.TextBox Tb_Caminho;
        private System.Windows.Forms.TextBox Tb_Resultado;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

