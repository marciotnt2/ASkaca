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
            var query = (from p in professor select p).ToList();
            comboProf.DisplayMember = "nome";
            comboProf.DataSource = query;

        }
        private void PopulaCombobHorario()
        {
            TurmaAplicacao turmafApp = new TurmaAplicacao();
            IEnumerable<Turmas> turma = turmafApp.Listar();
            IList<IList<Professor>> ret = new List<IList<Professor>>();
            var query = (from p in turma select p).ToList();
            ComboHorario.DisplayMember = "Horario";
            ComboHorario.DataSource = query;

        }
        private void PopulaCombModalidade()
        {
            TurmaAplicacao turmafApp = new TurmaAplicacao();
            IEnumerable<Turmas> turma = turmafApp.Listar();
            IList<IList<Professor>> ret = new List<IList<Professor>>();
            var query = (from p in turma select p).ToList();
            ComboModalidade.DisplayMember = "Horario";
            ComboModalidade.DataSource = query;

        }
        private void PopulaComboArte()
        {
            ArteAplicacao arteApp = new ArteAplicacao();
            IEnumerable<Arte> turma = arteApp.Listar();
            IList<IList<Arte>> ret = new List<IList<Arte>>();
            var query = (from p in turma select p).ToList();
            ComboModalidade.DisplayMember = "nome";
            ComboModalidade.DataSource = query;

        }
        private void AlunoCad_Load(object sender, EventArgs e)
        {
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turmas turma = new Turmas();
            AlunoAplicacao alunoApp = new AlunoAplicacao();
            TurmaAplicacao turmaApp = new TurmaAplicacao();
            ArteAplicacao arteApp = new ArteAplicacao();
            Aluno aluno = new Aluno();
            aluno.nome = txtNome.Text;
            aluno.RG = txtRG.Text;
            aluno.CPF = txtCPF.Text;
            aluno.logradouro = txtEndereco.Text;
            aluno.telefone = txtTelefone.Text;
            aluno.dataNascimento = System.DateTime.Now;
            aluno.dataPagamento = System.DateTime.Now;
            int selectedIndexTurma = ComboHorario.SelectedIndex;
            Object selectedItemTurma = ComboHorario.SelectedItem;
            turma = (Turmas)selectedItemTurma;

            aluno.Turma = turmaApp.Listar().Where(x => x.ID == turma.ID).First();
            //aluno.turma_id = 1;

           
            int selectedIndexProf = comboProf.SelectedIndex;
           Object selectedItemProf = comboProf.SelectedItem;
          // aluno. = (Professor) selectedItemProf;

           int selectedIndexModalidade = ComboModalidade.SelectedIndex;
           Object selectedItemModalidade = ComboModalidade.SelectedItem;
           Arte arte = new Arte();
            arte = (Arte)selectedItemModalidade;
            aluno.Arte = arteApp.Listar().Where(x => x.ID == arte.ID).First();
            //aluno.arte.ID = 1;
         
            alunoApp.Salvar(aluno);
            MessageBox.Show("Registro salvo com sucesso");
           // LimpaTela();
        }

               

              
    }
}
