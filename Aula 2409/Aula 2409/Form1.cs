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
    public partial class Form1 : Form
    {
        bool day = true;
        int option = 1;

        public Form1()
        {
            InitializeComponent();
            picSol.Visible = false;
            picSairB.Visible = false;
            picLogoB.Visible = false;
        }

        public Form1(int option)
        {
            InitializeComponent();
            if (option == 0) First();
            if (option == 1) Day();
            if (option == 2) Middle();
            if (option == 3) Night();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLogin.Text) || !string.IsNullOrEmpty(txtSenha.Text))
            {
                Form2 form2 = new Form2(option);
                form2.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Preencha os campos!");
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLogin.Select();
            trackBar1.Maximum = 3;
            trackBar1.Visible = false;
        }

        private void picLua_Click(object sender, EventArgs e)
        {
            Night();
        }

        private void picSol_Click(object sender, EventArgs e)
        {
            Day();
        }

        private void picSairB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Day()
        {
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            picSol.Visible = false;
            picLua.Visible = true;
            picLogoB.Visible = false;
            picLogo.Visible = true;
            picSairB.Visible = false;
            pictureBox2.Visible = true;
            this.BackColor = Color.SandyBrown;
            day = true;
            option = 1;
        }

        private void Night()
        {
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            picSol.Visible = true;
            picLua.Visible = false;
            picLogoB.Visible = true;
            picLogo.Visible = false;
            picSairB.Visible = true;
            pictureBox2.Visible = false;
            this.BackColor = Color.Black;
            day = false;
            option = 3;
        }

        private void Middle()
        {
            this.BackColor = Color.Sienna; 
            picSol.Visible = true;
            picLua.Visible = false;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            picLogoB.Visible = true;
            picLogo.Visible = false;
            picSairB.Visible = true;
            pictureBox2.Visible = false;
            option = 2;
        }

        private void First()
        {
            this.BackColor = Color.White; 
            picSol.Visible = false;
            picLua.Visible = true;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            picLogoB.Visible = false;
            picLogo.Visible = true;
            picSairB.Visible = false;
            pictureBox2.Visible = true;
            btnEntrar.BackColor = Color.Black;
            btnEntrar.ForeColor = Color.White;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.White;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            option = 0;
        }

        private void picLogoB_Click(object sender, EventArgs e)
        {
            if (trackBar1.Visible == true)
            {
                trackBar1.Visible = false;
            } else
            {
                trackBar1.Visible = true;
            }
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            if (trackBar1.Visible == true)
            {
                trackBar1.Visible = false;
            }
            else
            {
                trackBar1.Visible = true;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0) First();
            if (trackBar1.Value == 1) Day();
            if (trackBar1.Value == 2) Middle();
            if (trackBar1.Value == 3) Night();
        }
    }
}
