using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Askaca
{
    class ArteAplicacao
    {
           public DBaskaca banco { get; set; }

        public ArteAplicacao()
        {
            banco = new DBaskaca();
        }

        public void Salvar(Arte arte)
        {
            banco.Arte.Add(arte);
            banco.SaveChanges();
        }

        public IEnumerable<Arte> Listar()
        {
            return banco.Arte.ToList();
        }

        public void Alterar(Arte arte)
        {
            Arte artesalvar = banco.Arte.Where(x => x.ID == arte.ID).First();
            artesalvar.ID = arte.ID;
            artesalvar.mensalidade = arte.mensalidade;
            artesalvar.nome = arte.nome;
            artesalvar.professor = arte.professor;
            banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Arte arteExcluir = banco.Arte.Where(x => x.ID == Id).First();
            banco.Set<Arte>().Remove(arteExcluir);
            banco.SaveChanges();
        }

        public Arte Pesquisar(Arte arte)
        {
            Arte artePesquisa = banco.Arte.Where(x => x.ID == arte.ID).First();
            return artePesquisa;
        }
    }
}
