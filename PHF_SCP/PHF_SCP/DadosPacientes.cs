using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace PHF_SCP
{
    class DadosPacientes
    {
        private List<Paciente> CadastroPaciente;

        public List<Paciente> RetornaListaMedicos
        {
            get { return CadastroPaciente; }

        }

        public DadosPacientes()
        {
            CadastroPaciente = new List<Paciente>();
        }

        public int RetornaIndice(Paciente MeuPaciente)
        {
            return CadastroPaciente.IndexOf(MeuPaciente);
        }

        public void AdicionaPaciente(Paciente MeuPaciente)
        {
            CadastroPaciente.Add(MeuPaciente);
        }

        public string CadastraPacienteXML()
        {

            try
            {
                //Abre uma instância de TextWriter - FIle Stream
                TextWriter EscrevePaciente = new StreamWriter(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoPacientes2.xml");

                //Paciente CadastrarPaciente = MeuPaciente;
                
                
                
                //Abre uma instância do Serializer para inserção de Dados de Paciente
                XmlSerializer Serializacao = new XmlSerializer(CadastroPaciente.GetType());

                Serializacao.Serialize(EscrevePaciente, CadastroPaciente);

                EscrevePaciente.Close();


                //TextWriter MeuWriter = new StreamWriter(@"C:\Users\Pedro Fernandes\ArquivoAlunos.xml");


                //Aluno[] ListaAlunoVetor = (Aluno[])Cadastro.ToArray(typeof(Aluno));

                //XmlSerializer Serialização = new XmlSerializer(ListaAlunoVetor.GetType());

                //Serialização.Serialize(MeuWriter, ListaAlunoVetor);

                //MeuWriter.Close();// Boa prática fechar o "DB"

                //return Cadastro.Count;

                return "Cadastro Realizado com Sucesso";
            }
            catch(Exception ex)
            {
                //Console.WriteLine(ex.Message);

                return ex.Message;
            }
            


        }

        public int LerPaciente()
        {
            try
            {
                FileStream Arquivo = new FileStream(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoPacientes2.xml", FileMode.Open);

                XmlSerializer Desserializacao = new XmlSerializer(CadastroPaciente.GetType());

                CadastroPaciente = (List<Paciente>)Desserializacao.Deserialize(Arquivo);

                Arquivo.Close();

                return CadastroPaciente.Count;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);

                return 0;
            }


            
        }

        //public Paciente PesquisarCodPaciente(string codigo)
        //{
            //int Pos;
            //Cadastro.Sort(new MinhaOutraOrdenação());

            //Pos = Cadastro.BinarySearch(Cód.ToUpper(), new MinhaComparação());

            //if (Pos > 0)
            //    return (Aluno)Cadastro[Pos];
            //else
            //{

            //    return null;
            //}

        //    int pos;

        //    Paciente Teste = new Paciente();
        //    Teste.Codigo = codigo;

        //    CadastroPaciente.Sort(new MinhaOrdenacao());

        //    pos = CadastroPaciente.BinarySearch(Teste, new MinhaComparacao());

        //    if(pos > 0)
        //    {
        //        return CadastroPaciente[pos];
        //    }
        //    else
        //    {
        //        return null;
        //    }






        //}

        public List<Paciente> ConsultaPacienteCodigo(string codigo)
        {

            var MinhaConsulta = from p in CadastroPaciente
                                where (p.Codigo).Equals(codigo)
                                select p;

            

            return MinhaConsulta.ToList();

        }

        public List<Paciente> ConsultaPacienteNome(string nome)
        {

            var MinhaConsulta = from p in CadastroPaciente
                                where (p.Nome).Equals(nome)
                                select p;



            return MinhaConsulta.ToList();

        }

        public List<Paciente> ConsultaPacienteCPF(string cpf)
        {

            var MinhaConsulta = from p in CadastroPaciente
                                where (p.CPF).Equals(cpf)
                                select p;



            return MinhaConsulta.ToList();

        }

        public string AlterarPacienteX(string codigo, Paciente PacienteAlterado)
        {

            try
            {


                XElement Raiz = XElement.Load(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoPacientes2.xml");

                //var MinhaConsulta = from p in CadastroPaciente
                //                    where (p.Codigo).Equals(codigo)
                //                    select p;

                var MinhaConsulta = from A in Raiz.Elements("Paciente")
                                    where ((string)A.Element("Codigo")).Equals(codigo)
                                    select A;

                foreach (XElement xe in MinhaConsulta)
                {
                    xe.SetElementValue("Codigo", PacienteAlterado.Codigo);
                    xe.SetElementValue("CPF", PacienteAlterado.CPF);
                    xe.SetElementValue("Nome", PacienteAlterado.Nome);
                    xe.SetElementValue("Endereco", PacienteAlterado.Endereco);
                    xe.SetElementValue("Telefone", PacienteAlterado.Telefone);
                    xe.SetElementValue("Mail", PacienteAlterado.Mail);
                    xe.SetElementValue("DataNascimento", PacienteAlterado.DataNascimento);


                }

                Raiz.Save(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoPacientes2.xml");
                return "Alteração Realizada com Sucesso!";
            }
            catch
            {
                return "Não deu";
            }
        }

        public string ExcluirPacienteX(string codigo, Paciente PacienteExcluido)
        {
            try
            {


                XElement Raiz = XElement.Load(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoPacientes2.xml");

                //var MinhaConsulta = from p in CadastroPaciente
                //                    where (p.Codigo).Equals(codigo)
                //                    select p;

                var MinhaConsulta = from A in Raiz.Elements("Paciente")
                                    where ((string)A.Element("Codigo")).Equals(codigo)
                                    select A;

                foreach (XElement xe in MinhaConsulta)
                {
                    xe.Element("Codigo").Parent.Remove();


                }

                Raiz.Save(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoPacientes2.xml");
                return "Exclusão Realizada com Sucesso!";
            }
            catch
            {
                return "Não deu";
            }
        }
    


        public Paciente ConsultaPeloIndice(int i)
        {
            return CadastroPaciente.ElementAt(i);
        }

        public string AlterarPacienteIndice(int i, Paciente PacienteAlterado)
        {
            //Console.WriteLine(CadastroPaciente.Count);
            Paciente Remover = CadastroPaciente[i];

            CadastroPaciente.Remove(Remover);
            CadastroPaciente.Insert(i,PacienteAlterado);

            return "Registro Alterado com Sucesso";

        }

        public int Validacao(Paciente Nova)
        {

            var MinhaConsulta = from p in CadastroPaciente
                                where ((p.CPF).Equals(Nova.CPF))
                                select p;



            return MinhaConsulta.Count();

        }


    }

   
}
