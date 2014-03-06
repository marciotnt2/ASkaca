namespace Askaca
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAlunosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Aluno = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridProf = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.txtpesquisaNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridAluno = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.txtpesquisaTurma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridTUrmas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.cbModalidade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.Aluno.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProf)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAluno)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTUrmas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProfessoresToolStripMenuItem,
            this.cadastroDeAlunosToolStripMenuItem,
            this.cadastroDeAlunosToolStripMenuItem1});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // cadastrarProfessoresToolStripMenuItem
            // 
            this.cadastrarProfessoresToolStripMenuItem.Name = "cadastrarProfessoresToolStripMenuItem";
            this.cadastrarProfessoresToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.cadastrarProfessoresToolStripMenuItem.Text = "Cadastrar Professores";
            this.cadastrarProfessoresToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProfessoresToolStripMenuItem_Click);
            // 
            // cadastroDeAlunosToolStripMenuItem
            // 
            this.cadastroDeAlunosToolStripMenuItem.Name = "cadastroDeAlunosToolStripMenuItem";
            this.cadastroDeAlunosToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.cadastroDeAlunosToolStripMenuItem.Text = "Cadastro de Modalidades";
            this.cadastroDeAlunosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAlunosToolStripMenuItem_Click);
            // 
            // cadastroDeAlunosToolStripMenuItem1
            // 
            this.cadastroDeAlunosToolStripMenuItem1.Name = "cadastroDeAlunosToolStripMenuItem1";
            this.cadastroDeAlunosToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            this.cadastroDeAlunosToolStripMenuItem1.Text = "Cadastro de Alunos";
            // 
            // Aluno
            // 
            this.Aluno.Controls.Add(this.tabPage1);
            this.Aluno.Controls.Add(this.tabPage2);
            this.Aluno.Controls.Add(this.tabPage3);
            this.Aluno.Location = new System.Drawing.Point(0, 27);
            this.Aluno.Name = "Aluno";
            this.Aluno.SelectedIndex = 0;
            this.Aluno.ShowToolTips = true;
            this.Aluno.Size = new System.Drawing.Size(768, 356);
            this.Aluno.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.txtpesquisa);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridProf);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Professores";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(659, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Remover";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(562, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Editar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cadastrar Professor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Listar Todos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(50, 257);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(197, 20);
            this.txtpesquisa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // dataGridProf
            // 
            this.dataGridProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProf.Location = new System.Drawing.Point(3, 3);
            this.dataGridProf.Name = "dataGridProf";
            this.dataGridProf.Size = new System.Drawing.Size(738, 235);
            this.dataGridProf.TabIndex = 0;
            this.dataGridProf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbModalidade);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.txtpesquisaNome);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridAluno);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aluno";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(667, 262);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Remover";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(570, 262);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Editar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(448, 262);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 23);
            this.button8.TabIndex = 13;
            this.button8.Text = "Cadastrar Professor";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(325, 262);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(108, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "Listar Todos";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // txtpesquisaNome
            // 
            this.txtpesquisaNome.Location = new System.Drawing.Point(58, 265);
            this.txtpesquisaNome.Name = "txtpesquisaNome";
            this.txtpesquisaNome.Size = new System.Drawing.Size(197, 20);
            this.txtpesquisaNome.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome";
            // 
            // dataGridAluno
            // 
            this.dataGridAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAluno.Location = new System.Drawing.Point(11, 11);
            this.dataGridAluno.Name = "dataGridAluno";
            this.dataGridAluno.Size = new System.Drawing.Size(738, 235);
            this.dataGridAluno.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button11);
            this.tabPage3.Controls.Add(this.button12);
            this.tabPage3.Controls.Add(this.button13);
            this.tabPage3.Controls.Add(this.button14);
            this.tabPage3.Controls.Add(this.txtpesquisaTurma);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.dataGridTUrmas);
            this.tabPage3.Controls.Add(this.button15);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(760, 296);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(667, 262);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(82, 23);
            this.button11.TabIndex = 23;
            this.button11.Text = "Remover";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(570, 262);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(91, 23);
            this.button12.TabIndex = 22;
            this.button12.Text = "Editar";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(448, 262);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(107, 23);
            this.button13.TabIndex = 21;
            this.button13.Text = "Cadastrar Turma";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(325, 262);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(108, 23);
            this.button14.TabIndex = 20;
            this.button14.Text = "Listar Todos";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // txtpesquisaTurma
            // 
            this.txtpesquisaTurma.Location = new System.Drawing.Point(58, 265);
            this.txtpesquisaTurma.Name = "txtpesquisaTurma";
            this.txtpesquisaTurma.Size = new System.Drawing.Size(197, 20);
            this.txtpesquisaTurma.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nome";
            // 
            // dataGridTUrmas
            // 
            this.dataGridTUrmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTUrmas.Location = new System.Drawing.Point(11, 11);
            this.dataGridTUrmas.Name = "dataGridTUrmas";
            this.dataGridTUrmas.Size = new System.Drawing.Size(738, 235);
            this.dataGridTUrmas.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Image = global::Askaca.Properties.Resources.Pesquisar;
            this.button1.Location = new System.Drawing.Point(264, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button10
            // 
            this.button10.Image = global::Askaca.Properties.Resources.Pesquisar;
            this.button10.Location = new System.Drawing.Point(272, 263);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(38, 23);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button15
            // 
            this.button15.Image = global::Askaca.Properties.Resources.Pesquisar;
            this.button15.Location = new System.Drawing.Point(272, 263);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(38, 23);
            this.button15.TabIndex = 17;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // cbModalidade
            // 
            this.cbModalidade.FormattingEnabled = true;
            this.cbModalidade.Location = new System.Drawing.Point(100, 291);
            this.cbModalidade.Name = "cbModalidade";
            this.cbModalidade.Size = new System.Drawing.Size(121, 21);
            this.cbModalidade.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Modalidade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 414);
            this.Controls.Add(this.Aluno);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Aluno.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProf)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAluno)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTUrmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProfessoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAlunosToolStripMenuItem1;
        private System.Windows.Forms.TabControl Aluno;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridProf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox txtpesquisaNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView dataGridAluno;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox txtpesquisaTurma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridTUrmas;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbModalidade;
    }
}

