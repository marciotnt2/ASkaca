using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Askaca
{
    public partial class AlunoCad : Form
    {
        public AlunoCad()
        {
            InitializeComponent();
            //this.TopLevel = true;
            //this.TopMost = true;
            //this.BringToFront();
            //this.Show();
            //this.Activate();
            //this.Focus();
            PopulaCombProf();
            PopulaCombobHorario();
            PopulaComboArte();
        }

        private void PopulaCombProf()
        {
            ProfessorAplicacao profApp = new ProfessorAplicacao();
            IEnumerable<Professor> professor = profApp.Listar();
            IList<IList<Professor>> ret = new List<IList<Professor>>();
            var query = (from p in professor select p.nome).ToList();
            comboProf.DisplayMember = "nome";
            comboProf.DataSource = query;

        }
        private void PopulaCombobHorario()
        {
            TurmaAplicacao turmafApp = new TurmaAplicacao();
            IEnumerable<Turmas> turma = turmafApp.Listar();
            IList<IList<Professor>> ret = new List<IList<Professor>>();
            var query = (from p in turma select p.horario).ToList();
            ComboHorario.DisplayMember = "Horario";
            ComboHorario.DataSource = query;

        }
        private void PopulaCombModalidade()
        {
            TurmaAplicacao turmafApp = new TurmaAplicacao();
            IEnumerable<Turmas> turma = turmafApp.Listar();
            IList<IList<Professor>> ret = new List<IList<Professor>>();
            var query = (from p in turma select p.horario).ToList();
            ComboModalidade.DisplayMember = "Horario";
            ComboModalidade.DataSource = query;

        }
        private void PopulaComboArte()
        {
            ArteAplicacao arteApp = new ArteAplicacao();
            IEnumerable<Arte> turma = arteApp.Listar();
            IList<IList<Arte>> ret = new List<IList<Arte>>();
            var query = (from p in turma select p.nome).ToList();
            ComboModalidade.DisplayMember = "nome";
            ComboModalidade.DataSource = query;

        }
        private void AlunoCad_Load(object sender, EventArgs e)
        {
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turmas turma = new Turmas();
            AlunoAplicacao arteApp = new AlunoAplicacao();
            Aluno aluno = new Aluno();
            aluno.nome = txtNome.Text;
            aluno.RG = txtRG.Text;
            aluno.CPF = txtCPF.Text;
            aluno.logradouro = txtEndereco.Text;
            aluno.telefone = txtTelefone.Text;
            turma.ID = ComboHorario.SelectedIndex;
            aluno.turma.ID = turma.ID;
            
            turma.horario = System.DateTime.Now;
            turma.ID = 1;
            turma.professor = prof;
            professorApp.Salvar(prof);
            MessageBox.Show("Registro salvo com sucesso");
           // LimpaTela();
        }

               

              
    }
}
