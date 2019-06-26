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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria uma nova Instância do Formulário de Paciente para mostrá-lo na tela
            frmCadastroPaciente frmCadastroPaciente = new frmCadastroPaciente();
            frmCadastroPaciente.Show();
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroMedico frmCadastroMedico = new frmCadastroMedico();
            frmCadastroMedico.Show();
        }

        private void pesquisaPorNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pesquisaPorCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaPaciente frmPesquisaPaciente = new frmPesquisaPaciente();
            frmPesquisaPaciente.Show();
        }

        private void médicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPesquisaMedico frmPesquisaMedico = new frmPesquisaMedico();
            frmPesquisaMedico.Show();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            frmAgenda frmAgenda = new frmAgenda();
            frmAgenda.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAgenda frmAgenda = new frmAgenda();
            frmAgenda.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }
    }
}
