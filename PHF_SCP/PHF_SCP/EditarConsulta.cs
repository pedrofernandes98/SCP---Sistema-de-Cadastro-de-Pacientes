using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHF_SCP
{
    public partial class frmEditarConsulta : Form
    {
        List<Consulta> ConsultaPesquisada;
        Operacoes MinhasOperacoes = new Operacoes();
        string codigo;
        public frmEditarConsulta(string c)
        {
            InitializeComponent();
            codigo = c;
        }

        private void frmEditarConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                ConsultaPesquisada = MinhasOperacoes.PesquisaConsultaCod(codigo);
                Consulta MinhaConsulta = ConsultaPesquisada[0];
                dtpNovaData.Value = MinhaConsulta.Data;
                maskedTextBox1.Text = MinhaConsulta.Horario;
            }
            catch
            {
                MessageBox.Show("Código não encontrado");
                this.Close();
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Consulta MinhaConsulta = ConsultaPesquisada[0];
            MinhaConsulta.Data = dtpNovaData.Value;
            MinhaConsulta.Horario = maskedTextBox1.Text;

            string m = MinhasOperacoes.AlteraXConsulta(codigo, MinhaConsulta);
            MessageBox.Show(m);
            this.Close();
        }
    }
}
