namespace talentoso
{
    partial class TelaConsulta
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
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bttBuscaDicente = new System.Windows.Forms.Button();
            this.txbNumeroMatriculaDicente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCountDicentes = new System.Windows.Forms.Label();
            this.dgListaDicente = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bttBuscaDocente = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCountDocentes = new System.Windows.Forms.Label();
            this.dgListaDocente = new System.Windows.Forms.DataGridView();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaDicente)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaDocente)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Location = new System.Drawing.Point(10, 10);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(575, 310);
            this.tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bttBuscaDicente);
            this.tabPage1.Controls.Add(this.txbNumeroMatriculaDicente);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbCountDicentes);
            this.tabPage1.Controls.Add(this.dgListaDicente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dicente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bttBuscaDicente
            // 
            this.bttBuscaDicente.Location = new System.Drawing.Point(255, 235);
            this.bttBuscaDicente.Name = "bttBuscaDicente";
            this.bttBuscaDicente.Size = new System.Drawing.Size(75, 23);
            this.bttBuscaDicente.TabIndex = 8;
            this.bttBuscaDicente.Text = "Buscar";
            this.bttBuscaDicente.UseVisualStyleBackColor = true;
            this.bttBuscaDicente.Click += new System.EventHandler(this.bttBuscaDicente_Click);
            // 
            // txbNumeroMatriculaDicente
            // 
            this.txbNumeroMatriculaDicente.Location = new System.Drawing.Point(122, 237);
            this.txbNumeroMatriculaDicente.Name = "txbNumeroMatriculaDicente";
            this.txbNumeroMatriculaDicente.Size = new System.Drawing.Size(118, 20);
            this.txbNumeroMatriculaDicente.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número de Matrícula:";
            // 
            // lbCountDicentes
            // 
            this.lbCountDicentes.AutoSize = true;
            this.lbCountDicentes.Location = new System.Drawing.Point(520, 270);
            this.lbCountDicentes.Name = "lbCountDicentes";
            this.lbCountDicentes.Size = new System.Drawing.Size(35, 13);
            this.lbCountDicentes.TabIndex = 5;
            this.lbCountDicentes.Text = "label2";
            // 
            // dgListaDicente
            // 
            this.dgListaDicente.AllowUserToAddRows = false;
            this.dgListaDicente.AllowUserToDeleteRows = false;
            this.dgListaDicente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaDicente.Location = new System.Drawing.Point(0, 0);
            this.dgListaDicente.MultiSelect = false;
            this.dgListaDicente.Name = "dgListaDicente";
            this.dgListaDicente.ReadOnly = true;
            this.dgListaDicente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListaDicente.Size = new System.Drawing.Size(565, 230);
            this.dgListaDicente.TabIndex = 3;
            this.dgListaDicente.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgListaDicente_CellMouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bttBuscaDocente);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lbCountDocentes);
            this.tabPage2.Controls.Add(this.dgListaDocente);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Docente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bttBuscaDocente
            // 
            this.bttBuscaDocente.Location = new System.Drawing.Point(255, 235);
            this.bttBuscaDocente.Name = "bttBuscaDocente";
            this.bttBuscaDocente.Size = new System.Drawing.Size(75, 23);
            this.bttBuscaDocente.TabIndex = 11;
            this.bttBuscaDocente.Text = "Buscar";
            this.bttBuscaDocente.UseVisualStyleBackColor = true;
            this.bttBuscaDocente.Click += new System.EventHandler(this.bttBuscaDocente_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Número de Matrícula:";
            // 
            // lbCountDocentes
            // 
            this.lbCountDocentes.AutoSize = true;
            this.lbCountDocentes.Location = new System.Drawing.Point(520, 270);
            this.lbCountDocentes.Name = "lbCountDocentes";
            this.lbCountDocentes.Size = new System.Drawing.Size(35, 13);
            this.lbCountDocentes.TabIndex = 7;
            this.lbCountDocentes.Text = "label2";
            // 
            // dgListaDocente
            // 
            this.dgListaDocente.AllowUserToAddRows = false;
            this.dgListaDocente.AllowUserToDeleteRows = false;
            this.dgListaDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaDocente.Location = new System.Drawing.Point(0, 0);
            this.dgListaDocente.Name = "dgListaDocente";
            this.dgListaDocente.ReadOnly = true;
            this.dgListaDocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListaDocente.Size = new System.Drawing.Size(565, 230);
            this.dgListaDocente.TabIndex = 3;
            this.dgListaDocente.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgListaDocente_CellMouseDoubleClick);
            // 
            // TelaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 335);
            this.Controls.Add(this.tab);
            this.MaximizeBox = false;
            this.Name = "TelaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.TelaConsulta_Load);
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaDicente)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaDocente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgListaDicente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgListaDocente;
        private System.Windows.Forms.Label lbCountDicentes;
        private System.Windows.Forms.Label lbCountDocentes;
        private System.Windows.Forms.TextBox txbNumeroMatriculaDicente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttBuscaDicente;
        private System.Windows.Forms.Button bttBuscaDocente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;

    }
}