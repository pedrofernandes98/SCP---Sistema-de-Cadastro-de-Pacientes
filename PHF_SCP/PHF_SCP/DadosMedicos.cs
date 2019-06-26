using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PHF_SCP
{
    class DadosMedicos
    {
        private List<Medico> CadastroMedico;

        

        public List<Medico> RetornaListaMedicos
        {
            get { return CadastroMedico; }
            
        }


        public DadosMedicos()
        {
            CadastroMedico = new List<Medico>();
        }

        public void AdicionaMedico(Medico MeuMedico)
        {
            CadastroMedico.Add(MeuMedico);
        }

        public string CadastraMedicoXML()
        {

            try
            {
                //Abre uma instância de TextWriter - FIle Stream
                TextWriter EscreveMedico = new StreamWriter(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoMedicos.xml");

                //Paciente CadastrarPaciente = MeuPaciente;



                //Abre uma instância do Serializer para inserção de Dados de Paciente
                XmlSerializer Serializacao = new XmlSerializer(CadastroMedico.GetType());

                Serializacao.Serialize(EscreveMedico, CadastroMedico);

                EscreveMedico.Close();


                //TextWriter MeuWriter = new StreamWriter(@"C:\Users\Pedro Fernandes\ArquivoAlunos.xml");


                //Aluno[] ListaAlunoVetor = (Aluno[])Cadastro.ToArray(typeof(Aluno));

                //XmlSerializer Serialização = new XmlSerializer(ListaAlunoVetor.GetType());

                //Serialização.Serialize(MeuWriter, ListaAlunoVetor);

                //MeuWriter.Close();// Boa prática fechar o "DB"

                //return Cadastro.Count;

                return "Cadastro Realizado com Sucesso";
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);

                return ex.Message;
            }



        }

        public int LerMedico()
        {
            try
            {
                FileStream Arquivo = new FileStream(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoMedicos.xml", FileMode.Open);

                XmlSerializer Desserializacao = new XmlSerializer(CadastroMedico.GetType());

                CadastroMedico = (List<Medico>)Desserializacao.Deserialize(Arquivo);

                Arquivo.Close();

                return CadastroMedico.Count;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return 0;
            }



        }

        public List<Medico> ConsultaMedicoCodigo(string codigo)
        {

            var MinhaConsulta = from p in CadastroMedico
                                where (p.Codigo).Equals(codigo)
                                select p;



            return MinhaConsulta.ToList();

        }

        public List<Medico> ConsultaMedicoNome(string nome)
        {

            var MinhaConsulta = from p in CadastroMedico
                                where (p.Nome).Equals(nome)
                                select p;



            return MinhaConsulta.ToList();

        }

        public List<Medico> ConsultaMedicoCRM(string crm)
        {

            var MinhaConsulta = from p in CadastroMedico
                                where (p.CRM).Equals(crm)
                                select p;



            return MinhaConsulta.ToList();

        }

        public string AlterarMedicoX(string codigo, Medico MedicoAlterado)
        {

            try
            {


                XElement Raiz = XElement.Load(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoMedicos.xml");


                var MinhaConsulta = from A in Raiz.Elements("Medico")
                                    where ((string)A.Element("Codigo")).Equals(codigo)
                                    select A;

                foreach (XElement xe in MinhaConsulta)
                {
                    xe.SetElementValue("Codigo", MedicoAlterado.Codigo);
                    xe.SetElementValue("CRM", MedicoAlterado.CRM);
                    xe.SetElementValue("Nome", MedicoAlterado.Nome);
                    xe.SetElementValue("Telefone", MedicoAlterado.Telefone);
                    xe.SetElementValue("Especialidade", MedicoAlterado.Especialidade);


                }

                Raiz.Save(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoMedicos.xml");
                return "Alteração Realizada com Sucesso!";
            }
            catch
            {
                return "Não deu";
            }
        }

        public string ExcluirMedicoX(string codigo, Medico MedicoExcluido)
        {
            try
            {


                XElement Raiz = XElement.Load(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoMedicos.xml");

                //var MinhaConsulta = from p in CadastroPaciente
                //                    where (p.Codigo).Equals(codigo)
                //                    select p;

                var MinhaConsulta = from A in Raiz.Elements("Medico")
                                    where ((string)A.Element("Codigo")).Equals(codigo)
                                    select A;

                foreach (XElement xe in MinhaConsulta)
                {
                    xe.Element("Codigo").Parent.Remove();


                }

                Raiz.Save(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoMedicos.xml");
                return "Exclusão Realizada com Sucesso!";
            }
            catch
            {
                return "Erro";
            }
        }

        public int Validacao(Medico Nova)
        {

            var MinhaConsulta = from p in CadastroMedico
                                where ((p.CRM).Equals(Nova.CRM))
                                select p;



            return MinhaConsulta.Count();

        }

    }
}
