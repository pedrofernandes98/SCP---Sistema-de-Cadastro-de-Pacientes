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
    public partial class frmPesquisaPaciente : Form
    {
        Operacoes MinhasOperacoes = new Operacoes();
        //Paciente MeuPaciente;
        private List<Paciente> PacientesPesquisados;
        string Pesquisa;

        public frmPesquisaPaciente()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisa = txtPesquisa.Text.ToUpper();

            //MeuPaciente = MinhasOperacoes.PesquisaPacienteCodigo(codigoPesquisa);


            int cont = 0;

            if(rbrCod.Checked == true)
            {
                dgvPesquisa.DataSource = MinhasOperacoes.PesquisaPacienteCodigo(Pesquisa);
                PacientesPesquisados = MinhasOperacoes.PesquisaPacienteCodigo(Pesquisa);
                cont = MinhasOperacoes.PesquisaPacienteCodigo(Pesquisa).Count;
            }
            else if(rbrCPF.Checked == true)
            {
                PacientesPesquisados = MinhasOperacoes.PesquisaPacienteCPF(Pesquisa);
                dgvPesquisa.DataSource = MinhasOperacoes.PesquisaPacienteCPF(Pesquisa);
                cont = MinhasOperacoes.PesquisaPacienteCPF(Pesquisa).Count;
            }
            else
            {
                PacientesPesquisados = MinhasOperacoes.PesquisaPacienteNome(Pesquisa);
                dgvPesquisa.DataSource = MinhasOperacoes.PesquisaPacienteNome(Pesquisa);
                cont = MinhasOperacoes.PesquisaPacienteNome(Pesquisa).Count;
            }

            if(cont == 0)
            {
                MessageBox.Show("Nenhum registro encontrado!");
            }
            else
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }

            

            

            //dgvPesquisa.ClearSelection();

            //dgvDados.Columns[0].Width = 190;//Largura das Colunas
            //dgvDados.Columns[1].Width = 190;
            //dgvDados.Columns[2].Width = 65;
            //dgvDados.Columns[3].Width = 100;




            //txtPesquisa.Text = "";

            //Paciente MeuPaciente;

            //MeuPaciente = MinhasOperacoes.PesquisaCodPaciente(codigoPesquisa);

            //MessageBox.Show(MeuPaciente.Nome);


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            //int x = MinhasOperacoes.PegaIndicePaciente(PacientesPesquisados[0]);
            //Paciente PacienteAlterado = MinhasOperacoes.PesquisaParaAlteracao(x);
            Paciente PacienteAlterado = PacientesPesquisados[0];
            frmAlterarPaciente frmAlterar = new frmAlterarPaciente(PacienteAlterado);
            dgvPesquisa.DataSource = null;
            txtPesquisa.Text = "";
            frmAlterar.Show();
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            Paciente PacienteExcluido = PacientesPesquisados[0];
            string msg = MinhasOperacoes.ExclusaoPacienteX(PacienteExcluido.Codigo, PacienteExcluido);
            MessageBox.Show(msg);
            dgvPesquisa.DataSource = null;
            txtPesquisa.Text = "";
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void frmPesquisaPaciente_Load(object sender, EventArgs e)
        {
            dgvPesquisa.DataSource = MinhasOperacoes.ListaCompletaPaciente();
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            dgvPesquisa.DataSource = MinhasOperacoes.ListaCompletaPaciente();
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }
    }
}
