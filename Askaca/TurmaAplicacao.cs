using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Askaca
{
    class TurmaAplicacao
    {
         public DBaskaca banco { get; set; }

        public TurmaAplicacao()
        {
            banco = new DBaskaca();
        }

        public void Salvar(Turmas turma)
        {
            banco.Turmas.Add(turma);
            banco.SaveChanges();
        }

        public IEnumerable<Turmas> Listar()
        {
            return banco.Turmas.ToList();
        }

        public void Alterar(Turmas turma)
        {
            Turmas turmaSalvar = banco.Turmas.Where(x => x.ID == turma.ID).First();
            turmaSalvar.ID = turma.ID;
            turmaSalvar.horario = turma.horario;
            turmaSalvar.professor = turma.professor;
            banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Turmas turmaExcluir = banco.Turmas.Where(x => x.ID == Id).First();
            banco.Set<Turmas>().Remove(turmaExcluir);
            banco.SaveChanges();
        }

        public Turmas Pesquisar(Turmas turma)
        {
            Turmas turmaPesquisa = banco.Turmas.Where(x => x.ID == turma.ID).First();
            return turmaPesquisa;
        }
    }

}
