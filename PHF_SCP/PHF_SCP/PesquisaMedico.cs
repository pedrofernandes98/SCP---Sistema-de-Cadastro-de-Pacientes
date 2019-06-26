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
    public partial class frmPesquisaMedico : Form
    {
        Operacoes MinhasOperacoes = new Operacoes();
        
        private List<Medico> MedicosPesquisados;
        string Pesquisa;
        public frmPesquisaMedico()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisa = txtPesquisa.Text.ToUpper();

            int cont = 0;

            if (rbrCodigo.Checked == true)
            {
                dgvPesquisa.DataSource = MinhasOperacoes.PesquisaMedicoCodigo(Pesquisa);//
                MedicosPesquisados = MinhasOperacoes.PesquisaMedicoCodigo(Pesquisa);
                cont = MinhasOperacoes.PesquisaMedicoCodigo(Pesquisa).Count;
            }
            else if (rbrCRM.Checked == true)
            {
                MedicosPesquisados = MinhasOperacoes.PesquisaMedicoCRM(Pesquisa);
                dgvPesquisa.DataSource = MinhasOperacoes.PesquisaMedicoCRM(Pesquisa);
                cont = MinhasOperacoes.PesquisaMedicoCRM(Pesquisa).Count;
            }
            else
            {
                MedicosPesquisados = MinhasOperacoes.PesquisaMedicoNome(Pesquisa);
                dgvPesquisa.DataSource = MinhasOperacoes.PesquisaMedicoNome(Pesquisa);
                cont = MinhasOperacoes.PesquisaMedicoNome(Pesquisa).Count;
            }

            if (cont == 0)
            {
                MessageBox.Show("Nenhum registro encontrado!");
            }
            else
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }

            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Medico MedicoAlterado = MedicosPesquisados[0];
            frmAlterarMedico frmAlterar = new frmAlterarMedico(MedicoAlterado);
            dgvPesquisa.DataSource = null;
            txtPesquisa.Text = "";
            frmAlterar.Show();
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Medico MedicoExcluido = MedicosPesquisados[0];
            string msg = MinhasOperacoes.ExclusaoMedicoX(MedicoExcluido.Codigo, MedicoExcluido);
            MessageBox.Show(msg);
            dgvPesquisa.DataSource = null;
            txtPesquisa.Text = "";
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void frmPesquisaMedico_Load(object sender, EventArgs e)
        {
            dgvPesquisa.DataSource = MinhasOperacoes.ListaCompletaMedico();
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {
            dgvPesquisa.DataSource = MinhasOperacoes.ListaCompletaMedico();
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }
    }
}
