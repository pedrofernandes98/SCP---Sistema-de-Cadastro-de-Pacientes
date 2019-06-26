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
    public partial class frmCadastroMedico : Form
    {
        Operacoes MinhasOperacoes = new Operacoes();

        public frmCadastroMedico()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text == "" || txtCRM.Text == "" || txtEspecialidade.Text == "" || txtNome.Text == "" || txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {


                Medico MeuMedico = new Medico();

                MeuMedico.Codigo = txtCod.Text;
                MeuMedico.CRM = txtCRM.Text;
                MeuMedico.Nome = txtNome.Text;
                MeuMedico.Telefone = txtTelefone.Text;
                MeuMedico.Especialidade = txtEspecialidade.Text;

                int v = MinhasOperacoes.Validacao(MeuMedico);

                if (v == 0)
                {



                    string insercao = MinhasOperacoes.InsereDadosMedicos(MeuMedico);


                    MessageBox.Show(insercao);

                    txtCod.Text = Guid.NewGuid().ToString().Substring(9, 4).ToUpper();

                    txtCRM.Text = "";
                    txtNome.Text = "";
                    txtTelefone.Text = "";
                    txtEspecialidade.Text = "";
                }
                else
                {
                    MessageBox.Show("CRM já cadastrado");
                }
            }
        }

        private void frmCadastroMedico_Load(object sender, EventArgs e)
        {
            txtCod.Text = Guid.NewGuid().ToString().Substring(9, 4).ToUpper();
        }
    }
}
