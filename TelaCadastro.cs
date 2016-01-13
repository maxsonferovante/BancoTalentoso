using System;
using System.Windows.Forms;
using System.Xml;
using System.Data.SQLite;
using System.Data;

namespace talentoso
{
    public partial class TelaCadastro : Form
    {
        private static Boolean validado = false;
                
        public TelaCadastro()
        {
            InitializeComponent();
            lbXp2.Visible = false;
            cbExperiencia.Visible = false;
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {
            mtxbNascimento.ValidatingType = typeof(System.DateTime);
            mtxbNascimento.TypeValidationCompleted += new TypeValidationEventHandler(mTBNascimento_TypeValidationCompleted);
            btttalentoextra.Enabled = false;
            bttIncluir.Enabled = true;
        }

        void mTBNascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                mtxbNascimento.Clear();
                mtxbNascimento.Focus();
            }
        } 

        private void bttIncluir_Click(object sender, EventArgs e)
        {
            if (rBtDicente.Checked == true)
            {
                /*CASO SEJA DICENTE: Verifica campos obrigatórios: Classe de Talento, Talento, Experiência. 
                Se  não vazio, mensagem pedindo o preenchimento , senão incluir no dgListaTalento.*/
                if (!(string.IsNullOrEmpty(cbClasses.Text.ToString()) || string.IsNullOrEmpty(cbTalento.Text.ToString()) || string.IsNullOrEmpty(cbExperiencia2.Text.ToString())))
                {
                    dgListaTalento.Rows.Add(cbClasses.Text.ToString(), cbTalento.Text.ToString(), cbExperiencia2.Text.ToString(), txbDescricao.Text.ToString());
                    bttIncluir.Enabled = false;
                    btttalentoextra.Enabled = true;
                    validado = true;
                }
                else
                {
                    validado = false;
                    MessageBox.Show("É obrigatório o preenchimendo dos campos \"Classe de Talentos\", \"Talento\", \"Experiência\" do dicente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbClasses.Focus();
                }
            }
            else if (rBtDocente.Checked == true)
            {
                /*CASO SEJA DoCENTE: Verifica campos obrigatórios: Área de atuação, Experiência. 
                Se  não vazio, mensagem pedindo o preenchimento , senão incluir no dgListaTalento.*/
                if (!(string.IsNullOrEmpty(cbClasses.Text.ToString())))
                {
                    dgListaTalento.Rows.Add(cbClasses.Text.ToString(), cbExperiencia.Text.ToString(),txbDescricao.Text.ToString());
                    bttIncluir.Enabled = false;
                    btttalentoextra.Enabled = true;
                    validado = true;
                }
                else
                {
                    validado = false;
                    MessageBox.Show("É obrigatório o preenchimendo dos campos \"Área de atuação\",\"Experiência\" do docente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbClasses.Focus();
                }
            }
            cbClasses.Enabled = false;
            cbTalento.Enabled = false;
            cbExperiencia2.Enabled = false;
            cbExperiencia.Enabled = false;
            txbDescricao.Enabled = false;
        }
        private void btttalentoextra_Click(object sender, EventArgs e)
        {
            bttIncluir.Enabled = true;
            btttalentoextra.Enabled = false;
            validado = false;

            cbClasses.Enabled = true;       
            cbTalento.Enabled = true;
            cbExperiencia.Enabled = true;
            cbExperiencia2.Enabled = true;
            txbDescricao.Enabled = true;
            txbDescricao.ResetText();
            
            /*
            EU QUERO! Tu és só minha ??????? 
            és só meu?
            se sou somente seu (e sou), és somente minha!
            siiiiiiiim
                :D
            */
        }
        private void bttSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbMatricula.Text.ToString())) //É Obrigatório número de matricula.
                MessageBox.Show("É obrigatório o preenchimendo do campo Matrícula.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (validado)
                {
                    if (mtxbNascimento.MaskCompleted == true)
                    {
                        DialogResult rsSalvar = MessageBox.Show("Salvar alterações?", "Questionamento!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rsSalvar == DialogResult.Yes)
                        {
                            string classificacao = null;
                            Int64 id;
                            using (SQLiteConnection cnn = new SQLiteConnection("data source=talentoso.db"))
                            {
                                cnn.Open();
                                
                                if (rBtDicente.Checked == true) { classificacao = "dicente"; }
                                else if (rBtDocente.Checked == true) { classificacao = "docente"; }

                                using (SQLiteCommand command = new SQLiteCommand(cnn))
                                {
                                    /*Inserindo dados pessoais do cadastrado.*/
                                    command.CommandText = "INSERT INTO formulario (\"nome\",\"nascimento\",\"matricula\",\"email\",\"telefone\",\"classificacao\",\"curso\",\"semestre\") VALUES ('" + txbNome.Text.ToString() + "','" + mtxbNascimento.Text.ToString() + "','" + txbMatricula.Text.ToString() + "','" + txbEmail.Text.ToString() + "','" + mtxbCelular.Text.ToString() + "','" + classificacao + "','" + cbListaCursos.Text.ToString() + "','" + cbSemestre.Text.ToString() + "')";
                                    command.ExecuteReader();
                                }

                                string Text = "SELECT * FROM formulario where matricula=" +txbMatricula.Text.ToString();
                                using(SQLiteCommand command = new SQLiteCommand(Text, cnn))
                                {
                                    /*Lendo o numero da linha na tabela 'formulario' na qual foi salvo o Formulário. Tal valor será armazenado na coluna 'id_pessoa' ou na tabela 'dicente' ou 'docente'.*/
                                    command.ExecuteNonQuery();
                                    using (SQLiteDataReader reader = command.ExecuteReader())
                                    {
                                        reader.Read();
                                        id = Convert.ToInt64(reader["numero"].ToString());
                                    }
                                }   
                                using(SQLiteCommand command = new SQLiteCommand(cnn)) 
                                {
                                    /*Inserindo dados sobre o talento ou area de atuação do cadastro.*/
                                    if (rBtDicente.Checked == true)
                                    {
                                        classificacao = "Dicente";
                                        for (int i = 0; i < dgListaTalento.Rows.Count; i++)
                                        {
                                            command.CommandText = "INSERT INTO talento_dicente (classe,talento,experiencia,descricao, id_pessoa) VALUES ('" 
                                                + dgListaTalento.Rows[i].Cells[0].Value.ToString() 
                                                + "','" + dgListaTalento.Rows[i].Cells[1].Value.ToString() 
                                                + "','" + dgListaTalento.Rows[i].Cells[2].Value.ToString() 
                                                + "','" + dgListaTalento.Rows[i].Cells[3].Value.ToString() 
                                                + "','" + id + "')";

                                            command.ExecuteNonQuery();
                                        }
                                    }
                                    else if (rBtDocente.Checked == true)
                                    {
                                        classificacao = "Docente";
                                        for (int i = 0; i < dgListaTalento.Rows.Count; i++)
                                        {
                                            command.CommandText = "INSERT INTO talento_docente (atuacao,experiencia,descricao,id_pessoa) VALUES ('"
                                                + dgListaTalento.Rows[i].Cells[0].Value.ToString()
                                                + "','" + dgListaTalento.Rows[i].Cells[1].Value.ToString()
                                                + "','" + dgListaTalento.Rows[i].Cells[2].Value.ToString() 
                                                + "','" + id + "')";
                                        command.ExecuteNonQuery();
                                        }
                                    }
                                }
                                cnn.Close(); // Encerrano conexão com o banco de dados.
                            }
                            MessageBox.Show("Formulário Armazenado com Sucesso.", "Conclusão!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult rsContinuar = MessageBox.Show("Cadastrar outro Dicente ou um outro Docente?", "Questionamento!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (rsContinuar == DialogResult.Yes)
                            {
                                LimpaCampos();
                            }
                            else
                            {
                                this.Close();
                            }

                        }
                    }
                    else
                        MessageBox.Show("Data de Nascimento incorreta.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Os campos obrigatórios não foram preenchidos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbClasses.Focus();
                }
            }
        }

        private void cbTipo_TextChanged(object sender, EventArgs e)
        {
            if (rBtDicente.Checked == true)
            {
                cbTalento.Items.Clear();
                XmlDocument doc = new XmlDocument();

                doc.Load(cbClasses.Text.ToString() + ".xml");
                XmlNodeList ClassList = doc["tipo"].SelectNodes("nome");
                foreach (XmlNode n in ClassList)
                {
                    cbTalento.Items.Add(n.InnerText);
                }
            }
            
        }
        
        private void rBtDicente_CheckedChanged(object sender, EventArgs e)
        {
            dgListaTalento.Rows.Clear(); 

            dgListaTalento.Columns["Classe"].HeaderText = "Classe";
            dgListaTalento.Columns["Talento"].HeaderText = "Talento";
            dgListaTalento.Columns["Experiencia"].HeaderText = "Experiência";
            dgListaTalento.Columns["descricao"].Visible = true;

            cbClasses.Items.Clear();
            cbExperiencia2.SelectedIndex = -1;
            cbListaCursos.SelectedIndex = -1;
            cbSemestre.SelectedIndex = -1;
            cbTalento.Visible = true;
            cbExperiencia.Visible = false;
            cbExperiencia2.Visible = true;
            cbTalento.Enabled = true;
            cbClasses.Enabled = true;
            cbExperiencia2.Enabled = true;
            
            lbTalento.Visible = true;
            lbXp.Visible = true;
            lbXp2.Visible = false;

            txbMatricula.ResetText();

            bttIncluir.Enabled = true;
            btttalentoextra.Enabled = false;
        
            lbClasseTalento.Text = "Classe de Talentos:";
        
            itemsdotipo();
        }
        private void rBtDocente_CheckedChanged(object sender, EventArgs e)
        {
            dgListaTalento.Rows.Clear();

            dgListaTalento.Columns["Classe"].HeaderText = "Área de Atuação";
            dgListaTalento.Columns["Talento"].HeaderText = "Experiência";
            dgListaTalento.Columns["Experiencia"].HeaderText = "Descrição";
            dgListaTalento.Columns["descricao"].Visible = false;

            cbClasses.Items.Clear();
            cbTalento.Items.Clear();
            cbExperiencia.SelectedIndex = -1;
            cbListaCursos.SelectedIndex = -1;
            cbSemestre.SelectedIndex = -1;
            cbTalento.Visible = false;
            cbExperiencia.Visible = true;
            cbTalento.Enabled = false;
            cbClasses.Enabled = true;
            cbExperiencia.Enabled = true;

            lbXp.Visible = false;
            cbExperiencia2.Visible = false;
            lbTalento.Visible = false;
            lbXp2.Visible = true;

            txbMatricula.ResetText();

            bttIncluir.Enabled = true;
            btttalentoextra.Enabled = false;

            lbClasseTalento.Text = "Área de Atuação:";

            itemsdotipo();
        }

        private void itemsdotipo()
        {
            cbClasses.Items.Clear();
            XmlDocument doc = new XmlDocument();
            XmlNodeList ClassList;
            if (rBtDicente.Checked == true)
            {
                doc.Load("classes.xml");
                ClassList = doc["classes"].SelectNodes("classe");
            }
            else
            {
                doc.Load("areaatuacao.xml");
                ClassList = doc["tipo"].SelectNodes("nome");
            }
           
            foreach (XmlNode c in ClassList)
            {
                cbClasses.Items.Add(c.InnerText);
            }
        }
        private void LimpaCampos()
        {
            rBtDicente.Checked = false;
            rBtDocente.Checked = false;

            txbNome.Clear();
            txbEmail.Clear();
            txbMatricula.Clear();
            txbDescricao.Clear();

            mtxbCelular.Clear();
            mtxbNascimento.Clear();

            cbClasses.Items.Clear();
            cbExperiencia.Items.Clear();
            cbExperiencia2.Items.Clear();
            cbListaCursos.Items.Clear();
            cbTalento.Items.Clear();
            cbSemestre.Items.Clear();

            dgListaTalento.Rows.Clear();
        }
      
    }   
}


