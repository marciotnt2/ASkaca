using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Askaca
{
    public class ProfessorAplicacao
    {
        public DBaskaca banco { get; set; }

        public ProfessorAplicacao()
        {
            banco = new DBaskaca();
        }

        public void Salvar(Professor professor)
        {
            banco.Professor.Add(professor);
            banco.SaveChanges();
        }

        public IEnumerable<Professor> Listar()
        {
            return banco.Professor.ToList();
        }

        public void Alterar(Professor professor)
        {
            Professor professorSalvar = banco.Professor.Where(x => x.Id == professor.Id).First();
            professorSalvar.Id = professor.Id;
            professorSalvar.nome = professor.nome;
            professorSalvar.RG = professor.RG;
            professorSalvar.telefone = professor.telefone;
            professorSalvar.turmas = professor.turmas;
            banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Professor professorExcluir = banco.Professor.Where(x => x.Id == Id).First();
            banco.Set<Professor>().Remove(professorExcluir);
            banco.SaveChanges();
        }

        public Professor Pesquisar(Professor professor)
        {
            Professor professorPesquisa = banco.Professor.Where(x => x.nome == professor.nome).First();
            return professorPesquisa;
        }
    }
}
