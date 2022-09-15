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
            s = String.Concat("Tipo do motor: ", this.TpMotor, "\n", "Marca: ", this.Marca, "\n", "Código do veículo: ", this.CodVeiculo, "\n", "Cor: ", this.Cor, "\n", "Modelo: ", this.Modelo, "\n", "Tipo de câmbio: ", this.TpCambio, "\n", "Porte: ", this.Porte, "\n", "Tipo de cabine: ", this.Tpcabine, "\n", "Número de eixos: ", this.Numeixo, "\n", "Tipo de carga: ", this.Tpcarga);
            return s;
        }
    }
}
