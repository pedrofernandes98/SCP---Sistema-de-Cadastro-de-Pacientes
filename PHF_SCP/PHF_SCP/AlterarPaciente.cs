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
    public partial class frmAlterarPaciente : Form
    {
        Operacoes MinhasOperacoes = new Operacoes();
        int MeuIndice;
        public frmAlterarPaciente(Paciente x)
        {
            InitializeComponent();
            txtCodigo.Text = x.Codigo;
            txtCPF.Text = x.CPF;
            txtNome.Text = x.Nome;
            txtEndereco.Text = x.Endereco;
            txtTelefone.Text = x.Telefone;
            txtEmail.Text = x.Telefone;
            dtpData.Value = x.DataNascimento;
            //MeuIndice = indice;
        }

        private void lblCPF_Click(object sender, EventArgs e)
        {

        }

        private void frmAlterarPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Paciente MeuPaciente = new Paciente();

            MeuPaciente.Codigo = txtCodigo.Text;
            MeuPaciente.CPF = txtCPF.Text;
            MeuPaciente.Nome = txtNome.Text;
            MeuPaciente.Endereco = txtEndereco.Text;
            MeuPaciente.Telefone = txtTelefone.Text;
            MeuPaciente.Mail = txtEmail.Text;
            MeuPaciente.DataNascimento = dtpData.Value;//Tratar a data para o formato padrão

            string insercao = MinhasOperacoes.AlteraXPaciente(txtCodigo.Text,MeuPaciente);


            MessageBox.Show(insercao);

            this.Close();

            //txtCodigo.Text = MinhasOperacoes.PesquisaCod();
            //txtCPF.Text = "";
            //txtNome.Text = "";
            //txtEndereco.Text = "";
            //txtTelefone.Text = "";
            //txtEmail.Text = "";
            //dtpDataNasc.Value = DateTime.Now;
        }
    }
}
