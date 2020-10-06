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
        int option = 1;
        public Form3()
        {
            InitializeComponent();
            pictureBox3.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
        }

        public Form3(int option)
        {
            InitializeComponent();
            if (option == 0) First();
            if (option == 1) Day();
            if (option == 2) Middle();
            if (option == 3) Night();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblVoltar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(option);
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
                    var result = MessageBox.Show("Salvo com sucesso!", "CONFIRMAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Venda cancelada.");
                    } else
                    {
                        txtCodigo.Text = "";
                        txtCodigo.Focus();
                        numQuantidade.Value = 0;
                    }
                } 
                else
                {
                    MessageBox.Show("Insira a quantidade.");
                }
            } 
            else
            {
                MessageBox.Show("Insira o código.");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            trackBar1.Maximum = 3;
            trackBar1.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Night();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Day();
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

        private void Day()
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
            option = 1;
        }

        private void Night()
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
            option = 3;
        }

        private void Middle()
        {
            this.BackColor = Color.Sienna; 
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
            option = 2;
        }

        private void First()
        {
            this.BackColor = Color.White;
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
            btnSalvar.BackColor = Color.Black;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.FlatAppearance.MouseDownBackColor = Color.White;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            option = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0) First();
            if (trackBar1.Value == 1) Day();
            if (trackBar1.Value == 2) Middle();
            if (trackBar1.Value == 3) Night();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (trackBar1.Visible == true) trackBar1.Visible = false;
            if (trackBar1.Visible == false) trackBar1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (trackBar1.Visible == true) trackBar1.Visible = false;
            if (trackBar1.Visible == false) trackBar1.Visible = true;
        }
    }
}
