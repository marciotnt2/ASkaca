namespace Askaca
{
    partial class TurmaCad
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbProf = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxProfessor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // cbProf
            // 
            this.cbProf.FormattingEnabled = true;
            this.cbProf.Location = new System.Drawing.Point(75, 103);
            this.cbProf.Name = "cbProf";
            this.cbProf.Size = new System.Drawing.Size(121, 21);
            this.cbProf.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Professor";
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(80, 38);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(115, 20);
            this.txtInicio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fim";
            // 
            // txtFim
            // 
            this.txtFim.Location = new System.Drawing.Point(77, 68);
            this.txtFim.Name = "txtFim";
            this.txtFim.Size = new System.Drawing.Size(115, 20);
            this.txtFim.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dias";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sabado",
            "Domingo"});
            this.checkedListBox1.Location = new System.Drawing.Point(72, 170);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(19, 270);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(186, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Professor";
            // 
            // cbxProfessor
            // 
            this.cbxProfessor.FormattingEnabled = true;
            this.cbxProfessor.Location = new System.Drawing.Point(75, 138);
            this.cbxProfessor.Name = "cbxProfessor";
            this.cbxProfessor.Size = new System.Drawing.Size(121, 21);
            this.cbxProfessor.TabIndex = 9;
            // 
            // TurmaCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 312);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxProfessor);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProf);
            this.Controls.Add(this.label1);
            this.Name = "TurmaCad";
            this.Text = "TurmaCad";
            this.Load += new System.EventHandler(this.TurmaCad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxProfessor;
    }
}