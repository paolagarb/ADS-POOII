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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            picSol.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void lblNova_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Visible = false;
            form3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picSol_Click(object sender, EventArgs e)
        {
            picSol.Visible = false;
            picLua.Visible = true;
            this.BackColor = Color.SandyBrown;

            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            lblNova.ForeColor = Color.Black;


            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
            pictureBox4.Visible = false;
        }

        private void picLua_Click(object sender, EventArgs e)
        {
            picLua.Visible = false;
            picSol.Visible = true;
            this.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            lblNova.ForeColor = Color.White;
            pictureBox1.Visible = false;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
