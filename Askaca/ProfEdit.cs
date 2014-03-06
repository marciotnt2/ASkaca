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
    public partial class ProfEdit : Form
    {
        public ProfEdit(Professor professor)
        {
            InitializeComponent();
            this.TopLevel = true;
            this.TopMost = true;
            this.BringToFront();
            this.Show();
            this.Activate();
            this.Focus();

            txtNome.Text = professor.nome;
            //txtModalidade.Text = pr.arte;
            txtCPF.Text = professor.CPF;
            txtRG.Text = professor.RG;
            txtTelefone.Text = professor.telefone;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Professor professorNome = new Professor();
            Professor pr = new Professor();
            List<Professor> professor2 = new List<Professor>();
            professorNome.Id = Convert.ToInt32(txtID.Text);
            ProfessorAplicacao prof = new ProfessorAplicacao();
            IEnumerable<Professor> professor = prof.Listar();

            try
            {
                pr = professor.Where(x => x.Id == professorNome.Id).First();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não existe professor com esse nome");
            }

            //txtNome.Text = pr.nome;
            ////txtModalidade.Text = pr.arte;
            //txtCPF.Text = pr.CPF;
            //txtRG.Text = pr.RG;
            //txtTelefone.Text = pr.telefone;

            txtNome.Text = pr.nome;
            //txtModalidade.Text = pr.arte;
            txtCPF.Text = pr.CPF;
            txtRG.Text = pr.RG;
            txtTelefone.Text = pr.telefone;
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfessorAplicacao professorApp = new ProfessorAplicacao();
            Professor prof = new Professor();
            prof.Id = Convert.ToInt32(txtID.Text);
            prof.nome = txtNome.Text;
            prof.RG = txtRG.Text;
            prof.CPF = txtCPF.Text;
            //prof.arte = txtModalidade.Text;
            prof.telefone = txtTelefone.Text;

            prof.telefone = txtTelefone.Text;
            Turmas turma = new Turmas();
            turma.Inicio = Convert.ToString(System.DateTime.Now);
            turma.ID = 1;
            turma.professor = prof;
            professorApp.Alterar(prof);
            MessageBox.Show("Registro alterado com sucesso");
            LimpaTela();
        }
        private void LimpaTela()
        {
            txtID.Text = "";
            txtCPF.Text = "";
            txtModalidade.Text = "";
            txtNome.Text = "";
            txtNome.Text = "";
            txtRG.Text = "";
            txtTelefone.Text = "";
            txtTurma.Text = "";
        }

        private void ProfEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
