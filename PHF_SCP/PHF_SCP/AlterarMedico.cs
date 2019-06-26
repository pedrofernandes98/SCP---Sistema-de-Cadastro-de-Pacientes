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
    public partial class frmAlterarMedico : Form
    {
        Operacoes MinhasOperacoes = new Operacoes();
        int MeuIndice;

        public frmAlterarMedico(Medico x)
        {
            InitializeComponent();
            txtCodigo.Text = x.Codigo;
            txtCRM.Text = x.CRM;
            txtNome.Text = x.Nome;
            txtTelefone.Text = x.Telefone;
            txtEspecialidade.Text = x.Especialidade;
        }

        private void AlterarMedico_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Medico MeuMedico = new Medico();

            MeuMedico.Codigo = txtCodigo.Text;
            MeuMedico.CRM = txtCRM.Text;
            MeuMedico.Nome = txtNome.Text;
            MeuMedico.Telefone = txtTelefone.Text;
            MeuMedico.Especialidade = txtEspecialidade.Text;


            

            string insercao = MinhasOperacoes.AlteraXMedico(txtCodigo.Text, MeuMedico);//


            MessageBox.Show(insercao);

            this.Close();
        }
    }
}
