﻿using System;
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
        public Form1()
        {
            InitializeComponent();
            picSol.Visible = false;
            picSairB.Visible = false;
            picLogoB.Visible = false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLogin.Text) || !string.IsNullOrEmpty(txtSenha.Text))
            {
                Form2 form2 = new Form2();
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

        }

        private void picLua_Click(object sender, EventArgs e)
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
        }

        private void picSol_Click(object sender, EventArgs e)
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
        }

        private void picSairB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
