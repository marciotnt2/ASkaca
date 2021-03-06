﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

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
            return banco.Aluno.Include(x => x.Arte).ToList();
        }

        public void Alterar(Aluno aluno)
        {
            Aluno alunoSalvar = banco.Aluno.Where(x => x.Id == aluno.Id).First();
            alunoSalvar.Id = aluno.Id;
            alunoSalvar.nome = aluno.nome;
            alunoSalvar.RG = aluno.RG;
            alunoSalvar.telefone = aluno.telefone;
            alunoSalvar.Turma = aluno.Turma;
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
