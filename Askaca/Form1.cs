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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListarProfessores();
            ListarAlunos();
        }
    private void ListarProfessores()
    {
         ProfessorAplicacao prof = new ProfessorAplicacao();
         dataGridProf.DataSource = prof.Listar();  
    }
    private void ListarAlunos()
    {
        AlunoAplicacao Aluno = new AlunoAplicacao();
        dataGridAluno.DataSource = Aluno.Listar();
    }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfessorAplicacao professorApp = new ProfessorAplicacao();
            Professor prof = new Professor();
            prof.nome = "Marcio galdino";
            prof.RG = "602548";
            prof.telefone = "3265889";
            Turmas turma = new Turmas();
            turma.horario = System.DateTime.Now;
            turma.ID = 1;
            turma.professor = prof;
            professorApp.Salvar(prof);
            

        }

        private void cadastroDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfCad profcad = new ProfCad();
            profcad.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtpesquisa.Text != "")
            {
                Professor professorNome = new Professor();
                Professor pr = new Professor();
                List<Professor> professor2 = new List<Professor>();
                professorNome.nome = txtpesquisa.Text;
                ProfessorAplicacao prof = new ProfessorAplicacao();
                IEnumerable<Professor> professor = prof.Listar();

                try
                {
                    pr = professor.Where(x => x.nome == professorNome.nome).First();
                    professor2.Add(pr);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não existe professor com esse nome");
                }
                dataGridProf.DataSource = professor2;
            }
            else
            {
                MessageBox.Show("Digite um nome");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            ListarProfessores();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProfCad profcad = new ProfCad();
            profcad.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor = (Professor)dataGridProf.CurrentRow.DataBoundItem;
            ProfEdit profEdit = new ProfEdit(professor);
            profEdit.Show();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
           
            Professor professor = new Professor(); 
            professor = (Professor) dataGridProf.CurrentRow.DataBoundItem;
            ProfessorAplicacao app = new ProfessorAplicacao();
            app.Excluir(professor.Id);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tALITA A nOVINHA DO BREGA");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ListarAlunos();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtpesquisaNome.Text != "")
            {
                Aluno alunoNome = new Aluno();
                Aluno aluno = new Aluno();
                List<Aluno> alunos = new List<Aluno>();
                alunoNome.nome = txtpesquisaNome.Text;
                AlunoAplicacao alunoapp = new AlunoAplicacao();
                IEnumerable<Aluno> alunoslist = alunoapp.Listar();

                try
                {
                    aluno = alunoslist.Where(x => x.nome == alunoNome.nome).First();
                    alunos.Add(aluno);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não existe aluno com esse nome");
                }
                dataGridAluno.DataSource = alunos;
            }
            else
            {
                MessageBox.Show("Digite um nome");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno = (Aluno)dataGridAluno.CurrentRow.DataBoundItem;
            AlunoAplicacao app = new AlunoAplicacao();
            app.Excluir(aluno.Id);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AlunoCad alunoCad = new AlunoCad();
            alunoCad.Show();
        }
    }
}
