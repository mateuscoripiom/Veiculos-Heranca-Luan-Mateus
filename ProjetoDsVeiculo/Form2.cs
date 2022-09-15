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
    public partial class Form2 : Form
    {
        Carro carro;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carro.PrintMySQL());
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnvoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.Show();
        }

        private void btncadastrar_Click_1(object sender, EventArgs e)
        {
            carro = new Carro(txtmotor.Text, txtmarca.Text, txtveiculo.Text, txtcor.Text, txtmodelo.Text, txtcambio.Text, txtporte.Text, txtcarroceria.Text, txtportamalas.Text, txtabertura.Text);
            txtmotor.Clear();
            txtmarca.Clear();
            txtveiculo.Clear();
            txtcor.Clear();
            txtmodelo.Clear();
            txtcambio.Clear();
            txtporte.Clear();
            txtcarroceria.Clear();
            txtportamalas.Clear();
            txtabertura.Clear();
        }

        private void btnconsultar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(carro.PrintMySQL());
        }
    }
}
