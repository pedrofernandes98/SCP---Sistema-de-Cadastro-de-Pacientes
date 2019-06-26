using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PHF_SCP
{
    class DadosConsultas
    {
        private List<Consulta> CadastroConsultas;

        

        public List<Consulta> RetornaCadastroConsultas
        {
            get { return CadastroConsultas; }
            
        }


        public DadosConsultas()
        {
            CadastroConsultas = new List<Consulta>();
        }

        public void AdicionaConsulta(Consulta MinhaConsulta)
        {
            CadastroConsultas.Add(MinhaConsulta);
        }

        public string CadastraConsultaXML()
        {

            try
            {
                //Abre uma instância de TextWriter - FIle Stream
                TextWriter EscrevePaciente = new StreamWriter(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoConsultas3.xml");

                //Paciente CadastrarPaciente = MeuPaciente;



                //Abre uma instância do Serializer para inserção de Dados de Paciente
                XmlSerializer Serializacao = new XmlSerializer(CadastroConsultas.GetType());

                Serializacao.Serialize(EscrevePaciente, CadastroConsultas);

                EscrevePaciente.Close();

                return "Cadastro Realizado com Sucesso";
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);

                return ex.Message;
            }



        }

        public void OrdenarData()
        {
            XElement Raiz = XElement.Load(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoConsultas3.xml");

            var MinhaConsulta = from p in Raiz.Elements("Consulta")
                       orderby (DateTime)p.Element("Data") ascending, (string)p.Element("Horario")
                       select new
                       {
                           Codigo = (string)p.Element("Codigo"),
                           Horario = (string)p.Element("Horario"),
                           CodigoPaciente = (string)p.Element("CodigoPaciente"),
                           NomePaciente = (string)p.Element("NomePaciente"),
                           CodMedico = (string)p.Element("CodMedico"),
                           NomeMedico = (string)p.Element("NomeMedico"),
                           Data = (DateTime)p.Element("Data")
                           
                       };

            CadastroConsultas.Clear();

            Consulta ConsultaAlterada = new Consulta();

            foreach(var x in MinhaConsulta)
            {
                ConsultaAlterada.Codigo = x.Codigo;
                ConsultaAlterada.Horario = x.Horario;
                ConsultaAlterada.CodigoPaciente = x.CodigoPaciente;
                ConsultaAlterada.NomePaciente = x.NomePaciente;
                ConsultaAlterada.CodMedico = x.CodMedico;
                ConsultaAlterada.NomeMedico = x.NomeMedico;
                ConsultaAlterada.Data = x.Data;

                CadastroConsultas.Add(ConsultaAlterada);

            }

            //CadastraConsultaXML();




            Raiz.Save(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoConsultas3.xml");


            

            
        }



        public int LerConsulta()
        {
            
            try
            {
                FileStream Arquivo = new FileStream(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoConsultas3.xml", FileMode.Open);

                XmlSerializer Desserializacao = new XmlSerializer(CadastroConsultas.GetType());

                CadastroConsultas = (List<Consulta>)Desserializacao.Deserialize(Arquivo);

                Arquivo.Close();

                return CadastroConsultas.Count;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return 0;
            }



        }

        public List<Consulta> ConsultaConsultadata(DateTime data)
        {

            var MinhaConsulta = from p in CadastroConsultas
                                where (p.Data).Equals(data)
                                select p;



            return MinhaConsulta.ToList();

        }

        public List<Consulta> PesquisaConsultaPeloCodigo(string codigo)
        {

            var MinhaConsulta = from p in CadastroConsultas
                                where (p.Codigo).Equals(codigo)
                                select p;



            return MinhaConsulta.ToList();

        }

        public string AlterarConsultaX(string codigo, Consulta ConsultaAlterada)
        {

            try
            {


                XElement Raiz = XElement.Load(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoConsultas3.xml");

                //var MinhaConsulta = from p in CadastroPaciente
                //                    where (p.Codigo).Equals(codigo)
                //                    select p;

                var MinhaConsulta = from A in Raiz.Elements("Consulta")
                                    where ((string)A.Element("Codigo")).Equals(codigo)
                                    select A;

                foreach (XElement xe in MinhaConsulta)
                {
                    xe.SetElementValue("Codigo", ConsultaAlterada.Codigo);
                    xe.SetElementValue("Horario", ConsultaAlterada.Horario);
                    xe.SetElementValue("CodigoPaciente", ConsultaAlterada.CodigoPaciente);
                    xe.SetElementValue("NomePaciente", ConsultaAlterada.NomePaciente);
                    xe.SetElementValue("CodMedico", ConsultaAlterada.CodMedico);
                    xe.SetElementValue("NomeMedico", ConsultaAlterada.NomeMedico);
                    xe.SetElementValue("Data", ConsultaAlterada.Data);


                }

                Raiz.Save(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoConsultas3.xml");
                return "Alteração Realizada com Sucesso!";
            }
            catch
            {
                return "Não deu";
            }
        }

        public string ExcluirConsultaX(string codigo, Consulta ConsultaExcluida)
        {
            try
            {


                XElement Raiz = XElement.Load(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoConsultas3.xml");

                //var MinhaConsulta = from p in CadastroPaciente
                //                    where (p.Codigo).Equals(codigo)
                //                    select p;

                var MinhaConsulta = from A in Raiz.Elements("Consulta")
                                    where ((string)A.Element("Codigo")).Equals(codigo)
                                    select A;

                foreach (XElement xe in MinhaConsulta)
                {
                    xe.Element("Codigo").Parent.Remove();


                }

                Raiz.Save(@"C:\Users\Pedro Fernandes\Desktop\PUC\2° Período\POO\Trabalho Final\PHF_SCP\ArquivoConsultas3.xml");
                return "Exclusão Realizada com Sucesso!";
            }
            catch
            {
                return "Não deu";
            }
        }

        public int OrdenarConsultas()
        {
            //CadastroConsultas.Sort(new MinhaOrdenação());
            CadastroConsultas = CadastroConsultas.OrderBy(m => m.Data).ThenBy(m => m.Horario).ToList();
            return CadastroConsultas.Count();
        }

        public int Validacao(Consulta Nova)
        {

            var MinhaConsulta = from p in CadastroConsultas
                                where ((p.Data).Equals(Nova.Data) && (p.Horario).Equals(Nova.Horario) && (p.CodMedico).Equals(Nova.CodMedico))
                                select p;



            return MinhaConsulta.Count();

        }

        public List<Consulta> ConsultasdoPaciente(string codigo)
        {

            var MinhaConsulta = from p in CadastroConsultas
                                where (p.CodigoPaciente).Equals(codigo)
                                select p;



            return MinhaConsulta.ToList();

        }

        public List<Consulta> ConsultasdoMedicoCodigo(string codigo)
        {

            var MinhaConsulta = from p in CadastroConsultas
                                where (p.CodMedico).Equals(codigo)
                                select p;



            return MinhaConsulta.ToList();

        }


    }

    public class MinhaOrdenação : IComparer<Consulta>
    {
        public int Compare(Consulta x, Consulta y)
        {
            x.Horario.CompareTo(y.Horario);
            return x.Data.CompareTo(y.Data);
        }

        
    }

    
}
