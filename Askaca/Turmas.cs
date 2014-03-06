using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Askaca
{
   public class Turmas
    {
        public int ID { get; set; }
        public string Inicio { get; set; }
        public string fim { get; set; }
        public string dias { get; set; }
        public virtual Professor professor { get; set; }
         public Arte modalidade { get; set; }
        public virtual IEnumerable<Aluno> aluno { get; set; }

    }
}
