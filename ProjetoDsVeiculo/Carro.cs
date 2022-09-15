using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDsVeiculo
{
    public class Carro : Veiculo
    {
        private string carroceria;
        private string portamala;
        private string tpporta;


        public Carro()
        {
            this.carroceria = null;
            this.portamala = null;
            this.tpporta = null;
        }

        public Carro(string tpMotor, string marca, string codVeiculo, string cor, string modelo, string tpCambio, string porte, string carroceria, string portamala, string tpporta)
        {
            this.TpMotor = tpMotor;
            this.Marca = marca;
            this.CodVeiculo = codVeiculo;
            this.Cor = cor;
            this.Modelo = modelo;
            this.TpCambio = tpCambio;
            this.Porte = porte;
            this.carroceria = carroceria;
            this.portamala = portamala;
            this.tpporta = tpporta;
        }

        public string Carroceria
        {
            get { return carroceria; }
            set { carroceria = value; }
        }

        public string Portamala
        {
            get { return portamala; }
            set { portamala = value; }
        }

        public string Tpporta
        {
            get { return tpporta; }
            set { tpporta = value; }
        }

        public override string PrintMySQL()
        {
            String s = String.Empty;
            s = String.Concat(this.TpMotor, " ", this.Marca, " ", this.CodVeiculo, " ", this.Cor, " ", this.Modelo, " ", this.TpCambio, " ", this.Porte, " ", this.Carroceria, " ", this.Portamala, " ", this.Tpporta);
            return s;
        }
    }
}
