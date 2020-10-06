using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2409
{
    
    public partial class Form3 : Form
    {
        bool day = true;
        public Form3()
        {
            InitializeComponent();
            pictureBox3.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblVoltar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCodigo.Text))
            {
                if(numQuantidade.Value > 0)
                {
                    MessageBox.Show("Salvo com sucesso!");
                } else
                {
                    MessageBox.Show("Insira a quantidade.");
                }
            } else
            {
                MessageBox.Show("Insira o código.");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox1.Visible = false;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            lblVoltar.ForeColor = Color.White;
            this.BackColor = Color.Black;
            day = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox1.Visible = true;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            lblVoltar.ForeColor = Color.Black;
            this.BackColor = Color.SandyBrown;
            day = true;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
