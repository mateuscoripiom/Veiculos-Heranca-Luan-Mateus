using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDsVeiculo
{
    public abstract class Veiculo
    {
        private string tpMotor;
        private string marca;
        private string codVeiculo;
        private string cor;
        private string modelo;
        private string tpCambio;
        private string porte;
        public Veiculo()
        {
            this.tpMotor = null;
            this.marca = null;
            this.codVeiculo = null;
            this.cor = null;
            this.modelo = null;
            this.tpCambio = null;
            this.porte = null;
        }

        public Veiculo(string tpMotor, string marca, string codVeiculo, string cor, string modelo, string tpCambio, string porte)
        {
            this.tpMotor = tpMotor;
            this.marca = marca;
            this.codVeiculo = codVeiculo;
            this.cor = cor;
            this.modelo = modelo;
            this.tpCambio = tpCambio;
            this.porte = porte;
        }

        public string TpMotor
        {
            get { return tpMotor; }
            set { tpMotor = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string CodVeiculo
        {
            get { return codVeiculo; }
            set { codVeiculo = value; }
        }

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string TpCambio
        {
            get { return tpCambio; }
            set { tpCambio = value; }
        }

        public string Porte
        {
            get { return porte; }
            set { porte = value; }
        }


        public abstract String PrintMySQL();
    }
}
