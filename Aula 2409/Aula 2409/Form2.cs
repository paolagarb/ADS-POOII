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
        bool day;
        public Form2()
        {
            InitializeComponent();
            picSol.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        public Form2(bool day)
        {
            InitializeComponent();
            trackBar1.Maximum = 3;
            if (day)
            {
                Day();
            } else
            {
                Night();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            trackBar1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(day);
            form1.Show();
            this.Hide();
        }

        private void lblNova_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(day);
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
            Day();
        }

        private void picLua_Click(object sender, EventArgs e)
        {
            Night();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Day()
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
            day = true;
        }

        private void Night()
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
            day = false;
        }

        private void picSol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void picLua_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (trackBar1.Visible == true)
            {
                trackBar1.Visible = false;
            } else
            {
                this.trackBar1.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (trackBar1.Visible == true)
            {
                trackBar1.Visible = false;
            }
            else
            {
                this.trackBar1.Visible = true;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           if (trackBar1.Value == 1)
            {
                Day();
            }
            
            if (trackBar1.Value == 3)
            {
                Night();
            }
        }
    }
}
