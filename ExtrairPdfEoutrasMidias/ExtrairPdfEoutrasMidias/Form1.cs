using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExtrairPdfEoutrasMidias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "***Extrair-_-Midias-_-De-_-Sites-_-.html***";
        }

        private void Tb_Caminho_Click(object sender, EventArgs e)
        {
            Tb_Caminho.Text = "";
        }

        //Strings.
        String htmlFile;
        String Extenção = ".pdf";
        String Http = "http://";
        String Href = "href=";
        //Strings.

        private void Bt_Browser_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Extrair Midia";
            openFileDialog1.InitialDirectory = @"C:\Users\mr_binary\Downloads";
            openFileDialog1.Filter = "Files html (*.html) | *.html" +
                            "|Feles htm (*.htm) | *.htm";
            openFileDialog1.DefaultExt = "html";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FileName = "enem.html";

            DialogResult dr = this.openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Tb_Caminho.Text = openFileDialog1.FileName;
            } 
        }

        String Content;
        String Line;
        String LineLink;
        int countLine = 0;
        int startLine = 0;
        int finishLine = 0;
        int sizeLine = 0;
        int sizeString = 0;
        int startSubstring = 0;
        String TempContent = "";

        private void Bt_Start_Click(object sender, EventArgs e)
        {
            htmlFile = Tb_Caminho.Text;

            StreamReader LerOArquivoHtml = new StreamReader(htmlFile);//LER O ARQUIVO.
            while ((Content = LerOArquivoHtml.ReadLine()) != null)
            {
                countLine++;//VAI CONTAR AS LINHA.
                Line = Content;//RESEBE O CONTEUDO DO HTML LINHA A LINHA. 
                if (Line.Contains(Http) && Line.Contains(Extenção))
                {
                    if (Line.Contains(Http) && Line.Contains(Href) && Line.Contains(Http))
                    {
                        sizeLine = Line.Length;
                        String Cabecalho = (Href + "\"" + Http);
                        startLine = Line.IndexOf(Cabecalho) + Href.Length + 1;
                        sizeString = (sizeLine) - (startLine + 4);
                        LineLink = Line.Substring(startLine, sizeString);
                        sizeLine = LineLink.Length;

                        finishLine = LineLink.IndexOf(Extenção);
                        finishLine = finishLine + Extenção.Length;
                        LineLink = LineLink.Substring(0, finishLine);
                        startSubstring = Line.IndexOf(Extenção);
                    }
                }

                try
                { 
                    for (int i = 0; i < LineLink.Length; i++)
                    {
                        TempContent = TempContent + LineLink[i];
                        if (TempContent.Contains(Http) && TempContent.Contains("\">"))
                        {
                            int PosNãoPdf = LineLink.IndexOf("\">");
                            LineLink = LineLink.Substring(PosNãoPdf + 4);
                            TempContent = "";
                            break;
                        }

                        if (TempContent.Contains(Http) && !TempContent.Contains("\">") && TempContent.Contains(Extenção))
                        {
                            try
                            {
                                Tb_Resultado.AppendText(countLine + " -> " + TempContent);
                                TempContent = "";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO");
                }
            }
            Line = Line.Substring(startSubstring + Extenção.Length);
        }
    }
}
