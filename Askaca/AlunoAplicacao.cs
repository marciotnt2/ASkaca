using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Askaca
{
    class AlunoAplicacao
    {
        public DBaskaca banco { get; set; }

        public AlunoAplicacao()
        {
            banco = new DBaskaca();
        }

        public void Salvar(Aluno aluno)
        {
            banco.Aluno.Add(aluno);
            banco.SaveChanges();
        }

        public IEnumerable<Aluno> Listar()
        {
            return banco.Aluno.ToList();
        }

        public void Alterar(Aluno aluno)
        {
            Aluno alunoSalvar = banco.Aluno.Where(x => x.Id == aluno.Id).First();
            alunoSalvar.Id = aluno.Id;
            alunoSalvar.nome = aluno.nome;
            alunoSalvar.RG = aluno.RG;
            alunoSalvar.telefone = aluno.telefone;
            alunoSalvar.turma = aluno.turma;
            banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Aluno alunoExcluir = banco.Aluno.Where(x => x.Id == Id).First();
            banco.Set<Aluno>().Remove(alunoExcluir);
            banco.SaveChanges();
        }

        public Aluno Pesquisar(Aluno aluno)
        {
            Aluno alunoPesquisa = banco.Aluno.Where(x => x.nome == aluno.nome).First();
            return alunoPesquisa;
        }
    }
}
