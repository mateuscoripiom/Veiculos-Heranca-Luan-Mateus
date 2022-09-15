using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDsVeiculo
{
    public class Caminhao : Veiculo
    {
        private string tpcabine;
        private string numeixo;
        private string tpcarga;


        public Caminhao()
        {
            this.tpcabine = null;
            this.numeixo = null;
            this.tpcarga = null;
        }

        public Caminhao(string tpMotor, string marca, string codVeiculo, string cor, string modelo, string tpCambio, string porte, string tpcabine, string numeixo, string tpcarga)
        {
            this.TpMotor = tpMotor;
            this.Marca = marca;
            this.CodVeiculo = codVeiculo;
            this.Cor = cor;
            this.Modelo = modelo;
            this.TpCambio = tpCambio;
            this.Porte = porte;
            this.tpcabine = tpcabine;
            this.numeixo = numeixo;
            this.tpcarga = tpcarga;
        }

        public string Tpcabine
        {
            get { return tpcabine; }
            set { tpcabine = value; }
        }

        public string Numeixo
        {
            get { return numeixo; }
            set { numeixo = value; }
        }

        public string Tpcarga
        {
            get { return tpcarga; }
            set { tpcarga = value; }
        }

        public override string PrintMySQL()
        {
            String s = String.Empty;
            s = String.Concat(this.TpMotor, " ", this.Marca, " ", this.CodVeiculo, " ", this.Cor, " ", this.Modelo, " ", this.TpCambio, " ", this.Porte, " ", this.Tpcabine, " ", this.Numeixo, " ", this.Tpcarga);
            return s;
        }
    }
}
