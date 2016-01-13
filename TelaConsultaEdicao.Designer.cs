namespace talentoso
{
    partial class TelaConsultaEdicao
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
            this.mtxbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxbCelular = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMatricula = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbClassificacao = new System.Windows.Forms.Label();
            this.txbClassificacao = new System.Windows.Forms.TextBox();
            this.txbCurso = new System.Windows.Forms.TextBox();
            this.txbSemestre = new System.Windows.Forms.TextBox();
            this.dgListaTalento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaTalento)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxbNascimento
            // 
            this.mtxbNascimento.Location = new System.Drawing.Point(357, 16);
            this.mtxbNascimento.Mask = "00/00/0000";
            this.mtxbNascimento.Name = "mtxbNascimento";
            this.mtxbNascimento.Size = new System.Drawing.Size(70, 20);
            this.mtxbNascimento.TabIndex = 28;
            this.mtxbNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Data de Nascimento:";
            // 
            // mtxbCelular
            // 
            this.mtxbCelular.Location = new System.Drawing.Point(357, 42);
            this.mtxbCelular.Mask = "(999) 00000-0000";
            this.mtxbCelular.Name = "mtxbCelular";
            this.mtxbCelular.Size = new System.Drawing.Size(100, 20);
            this.mtxbCelular.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(244, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Celular:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(60, 42);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(176, 20);
            this.txbEmail.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Email:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(60, 12);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(173, 20);
            this.txbNome.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nome:";
            // 
            // txbMatricula
            // 
            this.txbMatricula.Location = new System.Drawing.Point(283, 102);
            this.txbMatricula.Name = "txbMatricula";
            this.txbMatricula.Size = new System.Drawing.Size(100, 20);
            this.txbMatricula.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Matrícula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Semestre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Curso:";
            // 
            // lbClassificacao
            // 
            this.lbClassificacao.AutoSize = true;
            this.lbClassificacao.Location = new System.Drawing.Point(16, 86);
            this.lbClassificacao.Name = "lbClassificacao";
            this.lbClassificacao.Size = new System.Drawing.Size(69, 13);
            this.lbClassificacao.TabIndex = 41;
            this.lbClassificacao.Text = "Classificação\r\n";
            // 
            // txbClassificacao
            // 
            this.txbClassificacao.Location = new System.Drawing.Point(15, 102);
            this.txbClassificacao.Name = "txbClassificacao";
            this.txbClassificacao.Size = new System.Drawing.Size(75, 20);
            this.txbClassificacao.TabIndex = 44;
            // 
            // txbCurso
            // 
            this.txbCurso.Location = new System.Drawing.Point(97, 102);
            this.txbCurso.Name = "txbCurso";
            this.txbCurso.Size = new System.Drawing.Size(180, 20);
            this.txbCurso.TabIndex = 45;
            // 
            // txbSemestre
            // 
            this.txbSemestre.Location = new System.Drawing.Point(393, 102);
            this.txbSemestre.Name = "txbSemestre";
            this.txbSemestre.Size = new System.Drawing.Size(51, 20);
            this.txbSemestre.TabIndex = 46;
            // 
            // dgListaTalento
            // 
            this.dgListaTalento.AllowUserToAddRows = false;
            this.dgListaTalento.AllowUserToDeleteRows = false;
            this.dgListaTalento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaTalento.Location = new System.Drawing.Point(15, 128);
            this.dgListaTalento.Name = "dgListaTalento";
            this.dgListaTalento.ReadOnly = true;
            this.dgListaTalento.Size = new System.Drawing.Size(457, 150);
            this.dgListaTalento.TabIndex = 47;
            // 
            // TelaConsultaEdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 452);
            this.Controls.Add(this.dgListaTalento);
            this.Controls.Add(this.txbSemestre);
            this.Controls.Add(this.txbCurso);
            this.Controls.Add(this.txbClassificacao);
            this.Controls.Add(this.lbClassificacao);
            this.Controls.Add(this.txbMatricula);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxbNascimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtxbCelular);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaConsultaEdicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição da Consulta";
            this.Load += new System.EventHandler(this.TelaConsultaEdicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaTalento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxbNascimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxbCelular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbClassificacao;
        private System.Windows.Forms.TextBox txbClassificacao;
        private System.Windows.Forms.TextBox txbCurso;
        private System.Windows.Forms.TextBox txbSemestre;
        private System.Windows.Forms.DataGridView dgListaTalento;
    }
}