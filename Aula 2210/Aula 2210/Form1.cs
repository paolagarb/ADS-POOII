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

        }
    }
}
