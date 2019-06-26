using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHF_SCP
{
    class Operacoes
    {
        DadosPacientes MeusDados = new DadosPacientes();
        DadosMedicos MeusDadosMedicos = new DadosMedicos();
        DadosConsultas MeusDadosConsultas = new DadosConsultas();
        public string InsereDados(Paciente MeuPaciente)
        {
            MeusDados.LerPaciente();
            MeusDados.AdicionaPaciente(MeuPaciente);
            
            return MeusDados.CadastraPacienteXML();
        }

        public List<Paciente> ListaCompletaPaciente()
        {
            MeusDados.LerPaciente();
            return MeusDados.RetornaListaMedicos;
        }

        public int Validacao(Paciente x)
        {
            MeusDados.LerPaciente();
            return MeusDados.Validacao(x);
        }



        public string PesquisaCod()
        {
            int NovoCodigo = MeusDados.LerPaciente() + 1;
            return NovoCodigo.ToString();
        }

        public List<Paciente> PesquisaPacienteCodigo(string cod)
        {
            MeusDados.LerPaciente();
            return MeusDados.ConsultaPacienteCodigo(cod);
        }

        public List<Paciente> PesquisaPacienteNome(string nome)
        {
            MeusDados.LerPaciente();
            return MeusDados.ConsultaPacienteNome(nome);
        }

        public List<Paciente> PesquisaPacienteCPF(string cpf)
        {
            MeusDados.LerPaciente();
            return MeusDados.ConsultaPacienteCPF(cpf);
        }

        public Paciente PesquisaParaAlteracao(int indice)
        {
            MeusDados.LerPaciente();
            return MeusDados.ConsultaPeloIndice(indice);
        }

        public string AlterarPaciente(int indice, Paciente MeuPaciente)
        {
            MeusDados.LerPaciente();
            string retorno = MeusDados.AlterarPacienteIndice(indice, MeuPaciente);
            MeusDados.CadastraPacienteXML();
            return retorno;
        }

        public int PegaIndicePaciente(Paciente MeuPaciente)
        {
            return MeusDados.RetornaIndice(MeuPaciente);
        }

        public string AlteraXPaciente(string cod, Paciente x)
        {
            string r = MeusDados.AlterarPacienteX(cod, x);
            MeusDados.LerPaciente();



            return r;
        }

        public string ExclusaoPacienteX(string cod, Paciente x)
        {
            string r = MeusDados.ExcluirPacienteX(cod, x);
            MeusDados.LerPaciente();



            return r;
        }

        //public Paciente PesquisaCodPaciente(string codigo)
        //{
        //    return MeusDados.PesquisarCodPaciente(codigo);
        //}

        public List<Medico> ListaCompletaMedico()
        {
            MeusDadosMedicos.LerMedico();
            return MeusDadosMedicos.RetornaListaMedicos;
        }

        public int Validacao(Medico x)
        {
            MeusDadosMedicos.LerMedico();
            return MeusDadosMedicos.Validacao(x);
        }

        public string InsereDadosMedicos(Medico MeuMedico)
        {
            MeusDadosMedicos.LerMedico();
            MeusDadosMedicos.AdicionaMedico(MeuMedico);
            return MeusDadosMedicos.CadastraMedicoXML();
        }

        public string PesquisaCodMedico()
        {
            int NovoCodigo = MeusDadosMedicos.LerMedico() + 1;
            return NovoCodigo.ToString();
        }

        public List<Medico> PesquisaMedicoCodigo(string cod)
        {
            MeusDadosMedicos.LerMedico();
            return MeusDadosMedicos.ConsultaMedicoCodigo(cod);
        }

        public List<Medico> PesquisaMedicoNome(string nome)
        {
            MeusDadosMedicos.LerMedico();
            return MeusDadosMedicos.ConsultaMedicoNome(nome);
        }

        public List<Medico> PesquisaMedicoCRM(string crm)
        {
            MeusDadosMedicos.LerMedico();
            return MeusDadosMedicos.ConsultaMedicoCRM(crm);
        }

        public string AlteraXMedico(string cod, Medico x)
        {
            string r = MeusDadosMedicos.AlterarMedicoX(cod, x);
            MeusDadosMedicos.LerMedico();



            return r;
        }

        public string ExclusaoMedicoX(string cod, Medico x)
        {
            string r = MeusDadosMedicos.ExcluirMedicoX(cod, x);
            MeusDadosMedicos.LerMedico();



            return r;
        }




        //Consultas

        public string InsereDadosConsultas(Consulta MinhaConsulta)
        {
            MeusDadosConsultas.LerConsulta();
            MeusDadosConsultas.AdicionaConsulta(MinhaConsulta);
            //MeusDados.LerPaciente();
            //MeusDados.AdicionaPaciente(MeuPaciente);

            return MeusDadosConsultas.CadastraConsultaXML();
        }

        public List<Consulta> ListaCompletaConsultas()
        {
            //MeusDadosConsultas.OrdenarData();
            //MeusDadosConsultas.CadastraConsultaXML();
            MeusDadosConsultas.LerConsulta();
            int p = MeusDadosConsultas.OrdenarConsultas();
            MeusDadosConsultas.CadastraConsultaXML();
            MeusDadosConsultas.LerConsulta();
            return MeusDadosConsultas.RetornaCadastroConsultas;
        }

        public List<Consulta> PesquisaConsultaDia(DateTime d)
        {
            
            MeusDadosConsultas.LerConsulta();
            return MeusDadosConsultas.ConsultaConsultadata(d);
        }

        public List<Consulta> PesquisaConsultaCod(string cod)
        {
            MeusDadosConsultas.LerConsulta();
            return MeusDadosConsultas.PesquisaConsultaPeloCodigo(cod);
        }

        public string AlteraXConsulta(string cod, Consulta x)
        {
            string r = MeusDadosConsultas.AlterarConsultaX(cod, x);
            MeusDadosConsultas.LerConsulta();



            return r;
        }

        public string ExclusaoConsultaX(string cod, Consulta x)
        {
            string r = MeusDadosConsultas.ExcluirConsultaX(cod, x);
            MeusDadosConsultas.LerConsulta();



            return r;
        }

        public int Validacao(Consulta x)
        {
            MeusDadosConsultas.LerConsulta();
            return MeusDadosConsultas.Validacao(x);
        }

        public List<Consulta> PesquisaConsultaPacienteCodigo(string cod)
        {
            MeusDados.LerPaciente();
            return MeusDadosConsultas.ConsultasdoPaciente(cod);
        }

        public List<Consulta> PesquisaConsultaMedicoCodigo(string cod)
        {
            MeusDados.LerPaciente();
            return MeusDadosConsultas.ConsultasdoMedicoCodigo(cod);
        }



    }
}
