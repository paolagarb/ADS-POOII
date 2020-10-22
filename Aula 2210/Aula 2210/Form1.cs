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
                MessageBox.Show("Preencha todos os campos!", "Erro!", MessageBoxButtons.OK);
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
    }
}
