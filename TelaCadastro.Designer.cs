namespace talentoso
{
    partial class TelaCadastro
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
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbListaCursos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.lbClasseTalento = new System.Windows.Forms.Label();
            this.bttSalvar = new System.Windows.Forms.Button();
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.lbXp = new System.Windows.Forms.Label();
            this.cbExperiencia2 = new System.Windows.Forms.ComboBox();
            this.bttIncluir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btttalentoextra = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mtxbCelular = new System.Windows.Forms.MaskedTextBox();
            this.dgListaTalento = new System.Windows.Forms.DataGridView();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Experiencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTalento = new System.Windows.Forms.Label();
            this.cbTalento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbMatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.rBtDicente = new System.Windows.Forms.RadioButton();
            this.rBtDocente = new System.Windows.Forms.RadioButton();
            this.lbXp2 = new System.Windows.Forms.Label();
            this.cbExperiencia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaTalento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(64, 12);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(173, 20);
            this.txbNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Curso:";
            // 
            // cbListaCursos
            // 
            this.cbListaCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListaCursos.FormattingEnabled = true;
            this.cbListaCursos.Location = new System.Drawing.Point(19, 129);
            this.cbListaCursos.Name = "cbListaCursos";
            this.cbListaCursos.Size = new System.Drawing.Size(173, 21);
            this.cbListaCursos.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Semestre:";
            // 
            // cbSemestre
            // 
            this.cbSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbSemestre.Location = new System.Drawing.Point(316, 129);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(64, 21);
            this.cbSemestre.TabIndex = 9;
            // 
            // lbClasseTalento
            // 
            this.lbClasseTalento.AutoSize = true;
            this.lbClasseTalento.Location = new System.Drawing.Point(20, 165);
            this.lbClasseTalento.Name = "lbClasseTalento";
            this.lbClasseTalento.Size = new System.Drawing.Size(100, 13);
            this.lbClasseTalento.TabIndex = 6;
            this.lbClasseTalento.Text = "Classe de Talentos:";
            // 
            // bttSalvar
            // 
            this.bttSalvar.Location = new System.Drawing.Point(20, 417);
            this.bttSalvar.Name = "bttSalvar";
            this.bttSalvar.Size = new System.Drawing.Size(75, 23);
            this.bttSalvar.TabIndex = 17;
            this.bttSalvar.Text = "Salvar";
            this.bttSalvar.UseVisualStyleBackColor = true;
            this.bttSalvar.Click += new System.EventHandler(this.bttSalvar_Click);
            // 
            // cbClasses
            // 
            this.cbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Location = new System.Drawing.Point(19, 181);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(173, 21);
            this.cbClasses.TabIndex = 10;
            this.cbClasses.TextChanged += new System.EventHandler(this.cbTipo_TextChanged);
            // 
            // lbXp
            // 
            this.lbXp.AutoSize = true;
            this.lbXp.Location = new System.Drawing.Point(200, 205);
            this.lbXp.Name = "lbXp";
            this.lbXp.Size = new System.Drawing.Size(65, 13);
            this.lbXp.TabIndex = 2;
            this.lbXp.Text = "Experiência:";
            // 
            // cbExperiencia2
            // 
            this.cbExperiencia2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExperiencia2.FormattingEnabled = true;
            this.cbExperiencia2.Items.AddRange(new object[] {
            "Básico",
            "Intermediário",
            "Avançado"});
            this.cbExperiencia2.Location = new System.Drawing.Point(203, 221);
            this.cbExperiencia2.Name = "cbExperiencia2";
            this.cbExperiencia2.Size = new System.Drawing.Size(121, 21);
            this.cbExperiencia2.TabIndex = 12;
            // 
            // bttIncluir
            // 
            this.bttIncluir.Location = new System.Drawing.Point(330, 261);
            this.bttIncluir.Name = "bttIncluir";
            this.bttIncluir.Size = new System.Drawing.Size(50, 40);
            this.bttIncluir.TabIndex = 15;
            this.bttIncluir.Text = "Incluir";
            this.bttIncluir.UseVisualStyleBackColor = true;
            this.bttIncluir.Click += new System.EventHandler(this.bttIncluir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Descrição:";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(22, 261);
            this.txbDescricao.Multiline = true;
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(302, 38);
            this.txbDescricao.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Lista de Talentos";
            // 
            // btttalentoextra
            // 
            this.btttalentoextra.Location = new System.Drawing.Point(395, 261);
            this.btttalentoextra.Name = "btttalentoextra";
            this.btttalentoextra.Size = new System.Drawing.Size(50, 40);
            this.btttalentoextra.TabIndex = 16;
            this.btttalentoextra.Text = "+";
            this.btttalentoextra.UseVisualStyleBackColor = true;
            this.btttalentoextra.Click += new System.EventHandler(this.btttalentoextra_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Email:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(64, 42);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(176, 20);
            this.txbEmail.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Celular:";
            // 
            // mtxbCelular
            // 
            this.mtxbCelular.Location = new System.Drawing.Point(361, 42);
            this.mtxbCelular.Mask = "(999) 00000-0000";
            this.mtxbCelular.Name = "mtxbCelular";
            this.mtxbCelular.Size = new System.Drawing.Size(100, 20);
            this.mtxbCelular.TabIndex = 4;
            // 
            // dgListaTalento
            // 
            this.dgListaTalento.AllowUserToAddRows = false;
            this.dgListaTalento.AllowUserToOrderColumns = true;
            this.dgListaTalento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaTalento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Classe,
            this.Talento,
            this.Experiencia,
            this.Descricao});
            this.dgListaTalento.Location = new System.Drawing.Point(20, 318);
            this.dgListaTalento.Name = "dgListaTalento";
            this.dgListaTalento.ReadOnly = true;
            this.dgListaTalento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListaTalento.Size = new System.Drawing.Size(446, 93);
            this.dgListaTalento.TabIndex = 20;
            // 
            // Classe
            // 
            this.Classe.HeaderText = "Classe";
            this.Classe.Name = "Classe";
            this.Classe.ReadOnly = true;
            // 
            // Talento
            // 
            this.Talento.HeaderText = "Talento";
            this.Talento.Name = "Talento";
            this.Talento.ReadOnly = true;
            // 
            // Experiencia
            // 
            this.Experiencia.HeaderText = "Experiência";
            this.Experiencia.Name = "Experiencia";
            this.Experiencia.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // lbTalento
            // 
            this.lbTalento.AutoSize = true;
            this.lbTalento.Location = new System.Drawing.Point(20, 205);
            this.lbTalento.Name = "lbTalento";
            this.lbTalento.Size = new System.Drawing.Size(46, 13);
            this.lbTalento.TabIndex = 21;
            this.lbTalento.Text = "Talento:";
            // 
            // cbTalento
            // 
            this.cbTalento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTalento.FormattingEnabled = true;
            this.cbTalento.Location = new System.Drawing.Point(20, 221);
            this.cbTalento.Name = "cbTalento";
            this.cbTalento.Size = new System.Drawing.Size(170, 21);
            this.cbTalento.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Matrícula:";
            // 
            // txbMatricula
            // 
            this.txbMatricula.Location = new System.Drawing.Point(206, 129);
            this.txbMatricula.Name = "txbMatricula";
            this.txbMatricula.Size = new System.Drawing.Size(100, 20);
            this.txbMatricula.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Data de Nascimento:";
            // 
            // mtxbNascimento
            // 
            this.mtxbNascimento.Location = new System.Drawing.Point(361, 16);
            this.mtxbNascimento.Mask = "00/00/0000";
            this.mtxbNascimento.Name = "mtxbNascimento";
            this.mtxbNascimento.Size = new System.Drawing.Size(70, 20);
            this.mtxbNascimento.TabIndex = 2;
            this.mtxbNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // rBtDicente
            // 
            this.rBtDicente.AutoSize = true;
            this.rBtDicente.Location = new System.Drawing.Point(14, 86);
            this.rBtDicente.Name = "rBtDicente";
            this.rBtDicente.Size = new System.Drawing.Size(62, 17);
            this.rBtDicente.TabIndex = 5;
            this.rBtDicente.Text = "Dicente";
            this.rBtDicente.UseVisualStyleBackColor = true;
            this.rBtDicente.CheckedChanged += new System.EventHandler(this.rBtDicente_CheckedChanged);
            // 
            // rBtDocente
            // 
            this.rBtDocente.AutoSize = true;
            this.rBtDocente.Location = new System.Drawing.Point(82, 86);
            this.rBtDocente.Name = "rBtDocente";
            this.rBtDocente.Size = new System.Drawing.Size(66, 17);
            this.rBtDocente.TabIndex = 6;
            this.rBtDocente.Text = "Docente";
            this.rBtDocente.UseVisualStyleBackColor = true;
            this.rBtDocente.CheckedChanged += new System.EventHandler(this.rBtDocente_CheckedChanged);
            // 
            // lbXp2
            // 
            this.lbXp2.AutoSize = true;
            this.lbXp2.Location = new System.Drawing.Point(203, 165);
            this.lbXp2.Name = "lbXp2";
            this.lbXp2.Size = new System.Drawing.Size(62, 13);
            this.lbXp2.TabIndex = 29;
            this.lbXp2.Text = "Experiência";
            // 
            // cbExperiencia
            // 
            this.cbExperiencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExperiencia.FormattingEnabled = true;
            this.cbExperiencia.Items.AddRange(new object[] {
            "Básico",
            "Intermediário",
            "Avançado"});
            this.cbExperiencia.Location = new System.Drawing.Point(203, 181);
            this.cbExperiencia.Name = "cbExperiencia";
            this.cbExperiencia.Size = new System.Drawing.Size(121, 21);
            this.cbExperiencia.TabIndex = 11;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 452);
            this.Controls.Add(this.cbExperiencia);
            this.Controls.Add(this.lbXp2);
            this.Controls.Add(this.rBtDocente);
            this.Controls.Add(this.rBtDicente);
            this.Controls.Add(this.mtxbNascimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbMatricula);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbTalento);
            this.Controls.Add(this.lbTalento);
            this.Controls.Add(this.dgListaTalento);
            this.Controls.Add(this.mtxbCelular);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btttalentoextra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttIncluir);
            this.Controls.Add(this.cbExperiencia2);
            this.Controls.Add(this.bttSalvar);
            this.Controls.Add(this.lbXp);
            this.Controls.Add(this.cbClasses);
            this.Controls.Add(this.lbClasseTalento);
            this.Controls.Add(this.cbSemestre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbListaCursos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.TelaCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaTalento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbListaCursos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.Label lbClasseTalento;
        private System.Windows.Forms.Button bttSalvar;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.Label lbXp;
        private System.Windows.Forms.ComboBox cbExperiencia2;
        private System.Windows.Forms.Button bttIncluir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btttalentoextra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtxbCelular;
        private System.Windows.Forms.DataGridView dgListaTalento;
        private System.Windows.Forms.Label lbTalento;
        private System.Windows.Forms.ComboBox cbTalento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxbNascimento;
        private System.Windows.Forms.RadioButton rBtDicente;
        private System.Windows.Forms.RadioButton rBtDocente;
        private System.Windows.Forms.Label lbXp2;
        private System.Windows.Forms.ComboBox cbExperiencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Talento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Experiencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}