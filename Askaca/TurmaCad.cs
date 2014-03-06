using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Askaca
{
    public partial class TurmaCad : Form
    {
        public TurmaCad( )
        {
            InitializeComponent();
            //this.TopLevel = true;
            //this.TopMost = true;
            //this.BringToFront();
            //this.Show();
            //this.Activate();
            //this.Focus();
            PopulaCombProf();
        }

        private void TurmaCad_Load(object sender, EventArgs e)
        {

        }

        private void PopulaCombProf()
        {
            ProfessorAplicacao profApp = new ProfessorAplicacao();
            IEnumerable<Professor> professor = profApp.Listar();
            IList<IList<Professor>> ret = new List<IList<Professor>>();
            var query = (from p in professor select p).ToList();
            cbProf.DisplayMember = "nome";
            cbProf.DataSource = query;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TurmaAplicacao turmaApp = new TurmaAplicacao();
            Turmas turma = new Turmas();
            turma.Inicio = txtInicio.Text;
            turma.fim = txtFim.Text;

            int selectedIndexProf = cbProf.SelectedIndex;
            Object selectedItemProf = cbProf.SelectedItem;
            ProfessorAplicacao profApp = new ProfessorAplicacao();
            
            Professor professor = new Professor();
            professor = (Professor)selectedItemProf;
            turma.professor = profApp.Listar().Where(x => x.Id == professor.Id).First();

            //Cria uma instância para o objeto
            StringBuilder oSB = new StringBuilder();

            foreach (string item in checkedListBox1.CheckedItems)
            {
                oSB.Append(item.ToString());
                oSB.Append(" ");
            }
            string sVariavel = oSB.ToString();

            turma.dias = sVariavel;
            turmaApp.Salvar(turma);
            LimpaTela();
        }
        private void LimpaTela()
        {
            txtInicio.Text.DefaultIfEmpty();
            txtFim.Text.DefaultIfEmpty();
            checkedListBox1.ClearSelected();
        }
    }
}
