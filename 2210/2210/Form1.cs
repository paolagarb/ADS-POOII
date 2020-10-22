using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2210
{
    public partial class Form1 : Form
    {

        string[] itens =
        {
                "Lápis",
                "Borracha",
                "Apontador",
                "Caneta",
                "Régua",
                "Caderno"
        };

        public Form1()
        {
            InitializeComponent();

            checkedListBox1.Items.AddRange(itens);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
                checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                //checkedListBox1.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        //private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ListViewItem list = new ListViewItem("Produtos");
        //    list.SubItems.Add("produtos");
        //}

        private void button4_Click(object sender, EventArgs e)
        {
             for (int i = 0; i < listBox1.Items.Count; i++)
            {
                checkedListBox1.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
                //******
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(itens);
        }
    }
}
