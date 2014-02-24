using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Askaca
{
     public class DBaskaca:DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Turmas> Turmas { get; set; }
        public DbSet<Arte> Arte { get; set; }
    }
}
