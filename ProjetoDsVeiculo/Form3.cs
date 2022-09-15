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
    public partial class Form3 : Form
    {
        Caminhao caminhao;
        public Form3()
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
            MessageBox.Show(caminhao.PrintMySQL());
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            caminhao = new Caminhao(txtmotor.Text, txtmarca.Text, txtveiculo.Text, txtcor.Text, txtmodelo.Text, txtcambio.Text, txtporte.Text, txtcarga.Text, txteixos.Text, txtcabine.Text);
            txtmotor.Clear();
            txtmarca.Clear();
            txtveiculo.Clear();
            txtcor.Clear();
            txtmodelo.Clear();
            txtcambio.Clear();
            txtporte.Clear();
            txtcabine.Clear();
            txtcarga.Clear();
            txteixos.Clear();
        }
    }
}
