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

namespace Aula_0810
{
    public partial class Google : Form
    {
        int maxValue = 100;
        int actualValue = 0;

        public Google()
        {
            InitializeComponent();
            linkLabel2.Links.Add(0, 25, "https://google.com");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", e.Link.LinkData.ToString());
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //webBrowser1.Document.Body.Style = "zoom: 20%";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
          


            if (!string.IsNullOrEmpty(txtEmail.Text) 
               || !string.IsNullOrEmpty(txtEndereço.Text) 
               || !string.IsNullOrEmpty(txtNome.Text) 
               || !string.IsNullOrEmpty(txtNum.Text) 
               || !string.IsNullOrEmpty(txtSenha.Text) 
               || !string.IsNullOrEmpty(maskTelefone.Text))
            {
                lblPorcentagem.Visible = true;
                progressBar1.Visible = true;
                timer1.Start();
                new Thread(Run).Start();
            } else
            {
                MessageBox.Show("Preencha todos os campos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = actualValue;
            lblPorcentagem.Text = $"{progressBar1.Value} %";
        }

        private void Run()
        {
            while (actualValue < maxValue)
            {
                actualValue++;
                Thread.Sleep(30);
            }
            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
