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
    public partial class ProfCad : Form
    {
        public ProfCad()
        {
            InitializeComponent();
            this.TopLevel = true;
            this.TopMost = true;
            this.BringToFront();
            this.Show();
            this.Activate();
            this.Focus();
        }

        private void ProfCad_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfessorAplicacao professorApp = new ProfessorAplicacao();
            Professor prof = new Professor();
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
            professorApp.Salvar(prof);
            MessageBox.Show("Registro salvo com sucesso");
            LimpaTela();
            
        }
        private void LimpaTela()
        {
            txtCPF.Text = string.Empty;
            txtModalidade.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtTurma.Text = string.Empty;
        }
    }
}
