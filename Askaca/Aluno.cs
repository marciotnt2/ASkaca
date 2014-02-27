using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Askaca
{
   public class Aluno
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public DateTime dataNascimento { get; set; }
        public DateTime dataPagamento { get; set; }
        public Arte Arte { get; set; }
        public string telefone { get; set; }
        public string logradouro  { get; set; }
        public Turmas Turma { get; set; }
    }
}
