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
    public partial class frmCadastroPaciente : Form
    {
        Operacoes MinhasOperacoes = new Operacoes();
        //Paciente MeuPaciente = new Paciente();

        public frmCadastroPaciente()
        {
            InitializeComponent();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtCPF.Text == "" || txtEmail.Text == "" || txtEndereco.Text == "" || txtNome.Text == "" || txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {






                Paciente MeuPaciente = new Paciente();

                MeuPaciente.Codigo = txtCodigo.Text;
                MeuPaciente.CPF = txtCPF.Text;
                MeuPaciente.Nome = txtNome.Text;
                MeuPaciente.Endereco = txtEndereco.Text;
                MeuPaciente.Telefone = txtTelefone.Text;
                MeuPaciente.Mail = txtEmail.Text;
                MeuPaciente.DataNascimento = dtpDataNasc.Value.Date;//Tratar a data para o formato padrão

                int v = MinhasOperacoes.Validacao(MeuPaciente);

                if (v == 0)
                {

                

                    string insercao = MinhasOperacoes.InsereDados(MeuPaciente);


                    MessageBox.Show(insercao);

                    txtCodigo.Text = Guid.NewGuid().ToString().Substring(9, 4).ToUpper();
                    txtCPF.Text = "";
                    txtNome.Text = "";
                    txtEndereco.Text = "";
                    txtTelefone.Text = "";
                    txtEmail.Text = "";
                    dtpDataNasc.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("CPF já existente");
                }

            }
            //if (insercao)
            //{
            //    MessageBox.Show("Cadastro feito com Sucesso!");
            //}
            //else
            //{
            //    MessageBox.Show("Erro");
            //}

        }

        private void frmCadastroPaciente_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = Guid.NewGuid().ToString().Substring(9, 4).ToUpper();
        }
    }
}
