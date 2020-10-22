using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2210
{
    public partial class Form1 : Form
    {

        string[] categorias =
        {
            "Categoria 1",
            "Categoria 2",
            "Categoria 3"
        };

        public Form1()
        {
            InitializeComponent();
            cboCategoria.Items.AddRange(categorias);
            mskID.Select();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(mskID.Text) &&
                !String.IsNullOrEmpty(mskRazaoSocial.Text) &&
                !String.IsNullOrEmpty(mskTelefone.Text) &&
                !String.IsNullOrEmpty(mskEndereco.Text) &&
                !String.IsNullOrEmpty(mskEmail.Text) &&
                !String.IsNullOrEmpty(cboCategoria.Text) &&
                !String.IsNullOrEmpty(mskProduto.Text) &&
                !String.IsNullOrEmpty(mskValor.Text)) 
            {
                ListViewItem itens = new ListViewItem(mskID.Text);

                itens.SubItems.Add(mskRazaoSocial.Text);
                itens.SubItems.Add(mskTelefone.Text);
                itens.SubItems.Add(mskEndereco.Text);
                itens.SubItems.Add(mskEmail.Text);
                itens.SubItems.Add(cboCategoria.Text);
                itens.SubItems.Add(mskProduto.Text);
                itens.SubItems.Add(mskValor.Text);
                itens.SubItems.Add(dtpickerDate.Value.ToString());

                if (radioBtnSim.Checked) itens.SubItems.Add(radioBtnSim.Text);
                if (radioBtnNao.Checked) itens.SubItems.Add(radioBtnNao.Text);

                listView1.Items.Add(itens);
                LimparCampos();
            } else
            {
                MessageBox.Show("Preencha todos os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void LimparCampos()
        {
            mskID.Text = "";
            mskRazaoSocial.Text = "";
            mskTelefone.Text = "";
            mskEndereco.Text = "";
            mskEmail.Text = "";
            cboCategoria.Text = "";
            mskProduto.Text = "";
            mskValor.Text = "";
            dtpickerDate.Value = DateTime.Now.Date;
            radioBtnSim.Checked = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void mskID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            picSair.Visible = false;
            btnGravar.ForeColor = Color.White;
            btnGravar.BackColor = Color.Black;
            btnGravar.FlatAppearance.MouseDownBackColor = Color.White;
            btnGravar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnLimpar.ForeColor = Color.White;
            btnLimpar.BackColor = Color.Black;
            btnLimpar.FlatAppearance.MouseDownBackColor = Color.White;
            btnLimpar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            picSair.Visible = true;
            btnGravar.ForeColor = Color.Black;
            btnGravar.BackColor = Color.White;
            btnGravar.FlatAppearance.MouseDownBackColor = Color.White;
            btnGravar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnLimpar.ForeColor = Color.Black;
            btnLimpar.BackColor = Color.White;
            btnLimpar.FlatAppearance.MouseDownBackColor = Color.White;
            btnLimpar.FlatAppearance.MouseOverBackColor = Color.DimGray;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
