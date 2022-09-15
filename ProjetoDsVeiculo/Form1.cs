using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDsVeiculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncarro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 carrinho = new Form2();
            carrinho.Show();
        }

        private void btncaminhao_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 caminhaozinho = new Form3();
            caminhaozinho.Show();
        }
    }
}
