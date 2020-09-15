using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1009
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botApresentar(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            //int idade = Int32.Parse(txtIdade.Text);
            string idade = txtIdade.Text;
            string endereco = txtEndereço.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(idade) || string.IsNullOrEmpty(endereco) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefone))
            {
                MessageBox.Show("Preencha todos os campos!");
            } else
            {
                panel1.Visible = true;
                lblRelatorioNome.Text = $"Nome: {nome}";
                lblRelatorioIdade.Text = $"Idade: {idade}";
                lblRelatorioEndereco.Text = $"Endereço: {endereco}";
                lblRelatorioEmail.Text = $"Email: {email}";
                lblRelatorioTelefone.Text = $"Telefone: {telefone}";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtNome.Text = "";
            txtIdade.Text = "";
            txtEndereço.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
        }

        private void ValidarIdade(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
