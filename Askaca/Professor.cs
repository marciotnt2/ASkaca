using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Askaca
{
   public class Professor
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public Arte arte { get; set; }
        public string telefone  { get; set; }
        public virtual IEnumerable<Turmas> turmas { get; set; }

    }
}
