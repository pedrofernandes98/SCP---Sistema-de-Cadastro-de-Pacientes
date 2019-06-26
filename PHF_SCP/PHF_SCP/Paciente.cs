using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHF_SCP
{
    public class Paciente
    {
        public string Codigo { get; set; } //- Implementar consulta a base de dados XML e pegar o último código gerado
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Mail { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
