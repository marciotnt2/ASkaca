using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Askaca
{
   public class Arte
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public virtual IEnumerable<Professor> professor { get; set; }
        public int mensalidade { get; set; }
    }
}
