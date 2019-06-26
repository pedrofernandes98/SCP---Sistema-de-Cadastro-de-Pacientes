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
    public partial class frmAgenda : Form
    {
        Operacoes MinhasOperacoes = new Operacoes();
        List<Paciente> PacientesPesquisados;
        List<Medico> MedicosPesquisados;
        List<Consulta> ConsultaPesquisada;

        public frmAgenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            //lblDataAgenda.Text = mcDia.TodayDate.ToString().Substring(0,10);
            dgvConsultas.DataSource = MinhasOperacoes.ListaCompletaConsultas();
            lblAgenda.Text = "Agenda Completa";
        }

        private void mcDia_DateChanged(object sender, DateRangeEventArgs e)
        {
            //lblDataAgenda.Text = mcDia.SelectionRange.Start.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodPaciente.Text == "" || txtCodPaciente.Text == "" || !mtbHorario.MaskCompleted)
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {


                try
                {
                    Consulta MinhaConsulta = new Consulta();

                    MinhaConsulta.Codigo = Guid.NewGuid().ToString().Substring(9, 4).ToUpper();



                    MinhaConsulta.Horario = mtbHorario.Text;
                    MinhaConsulta.CodigoPaciente = txtCodPaciente.Text.ToUpper();



                    PacientesPesquisados = MinhasOperacoes.PesquisaPacienteCodigo(txtCodPaciente.Text.ToUpper());

                    Paciente PacienteAtual = PacientesPesquisados[0];
                    MinhaConsulta.NomePaciente = PacienteAtual.Nome;
                    MinhaConsulta.CodMedico = txtCodMedico.Text.ToUpper();
                    MedicosPesquisados = MinhasOperacoes.PesquisaMedicoCodigo(txtCodMedico.Text.ToUpper());
                    Medico MedicoAtual = MedicosPesquisados[0];
                    MinhaConsulta.NomeMedico = MedicoAtual.Nome;
                    MinhaConsulta.Data = dtpNovaConsulta.Value.Date;

                    int v = MinhasOperacoes.Validacao(MinhaConsulta);

                    if (v == 0)
                    {

                        string insercao = MinhasOperacoes.InsereDadosConsultas(MinhaConsulta);

                        MessageBox.Show(insercao);

                        mtbHorario.Text = "";
                        txtCodPaciente.Text = "";
                        txtCodMedico.Text = "";
                        dtpNovaConsulta.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Consulta em Horario já existente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Paciente ou médico não encontrados");
                }
            }
            dgvConsultas.DataSource = MinhasOperacoes.ListaCompletaConsultas();
            lblAgenda.Text = "Agenda Completa";

        }

        private void btnPesquisaPaciente_Click(object sender, EventArgs e)
        {
            frmPesquisaPaciente frmPesquisaPaciente = new frmPesquisaPaciente();
            frmPesquisaPaciente.Show();
        }

        private void btnListarMedicos_Click(object sender, EventArgs e)
        {
            frmPesquisaMedico frmPesquisaMedico = new frmPesquisaMedico();
            frmPesquisaMedico.Show();
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            dgvConsultas.DataSource = MinhasOperacoes.PesquisaConsultaDia(dtpData.Value.Date);
            lblAgenda.Text = "Agenda do dia " + dtpData.Value.Date.ToString().Substring(0,10);
        }

        private void btnAgCompleta_Click(object sender, EventArgs e)
        {
            dgvConsultas.DataSource = MinhasOperacoes.ListaCompletaConsultas();
            lblAgenda.Text = "Agenda Completa";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarConsulta frmEditarConsulta = new frmEditarConsulta(txtCodEdit.Text.ToUpper());
            frmEditarConsulta.Show();
            txtCodEdit.Text = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {


                ConsultaPesquisada = MinhasOperacoes.PesquisaConsultaCod(txtCodEdit.Text.ToUpper());
                Consulta MinhaConsulta = ConsultaPesquisada[0];
                string m = MinhasOperacoes.ExclusaoConsultaX(MinhaConsulta.Codigo, MinhaConsulta);
                MessageBox.Show(m);
                txtCodEdit.Text = "";
                dgvConsultas.DataSource = MinhasOperacoes.ListaCompletaConsultas();
                lblAgenda.Text = "Agenda Completa";
            }
            catch
            {
                MessageBox.Show("Códgio não encontrado");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string Pesquisa = txtPesqCod.Text.ToUpper();

            


            int cont = 0;

            if (rbrPaciente.Checked == true)
            {
                dgvConsultas.DataSource = MinhasOperacoes.PesquisaConsultaPacienteCodigo(Pesquisa);
                
                cont = MinhasOperacoes.PesquisaConsultaPacienteCodigo(Pesquisa).Count;
            }
            else
            {
                
                dgvConsultas.DataSource = MinhasOperacoes.PesquisaConsultaMedicoCodigo(Pesquisa);
                cont = MinhasOperacoes.PesquisaConsultaMedicoCodigo(Pesquisa).Count;
            }

            if (cont == 0)
            {
                MessageBox.Show("Nenhum registro encontrado!");
            }

            txtPesqCod.Text = "";
            
        }
    }
}
