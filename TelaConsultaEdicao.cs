using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace talentoso
{
    public partial class TelaConsultaEdicao : Form
    {
        public TelaConsultaEdicao()
        {
            InitializeComponent();
        }
        public string numero_id;
        public string classificacao;
        private Int64 id_pessoa;

        private void TelaConsultaEdicao_Load(object sender, EventArgs e)
        {
          /*  txbNome.Enabled = false;
            txbEmail.Enabled = false;
            mtxbNascimento.Enabled = false;
            mtxbCelular.Enabled = false;

            txbClassificacao.Enabled = false;
            txbCurso.Enabled = false;
            txbMatricula.Enabled = false;
            txbSemestre.Enabled = false;

            dgListaTalento.Enabled = false;
           */
            switch (classificacao) 
            {
                case "dicente":
                    {
                        using (SQLiteConnection cnn = new SQLiteConnection("data source=talentoso.db"))
                        {
                            cnn.Open(); 
                            /*Carregando os dados pessoais e acadêmicos 
                             * através do numero da linha 
                             * onde tal cadastro está armazenado na tabaela 'formulario'*/
                            string query = "SELECT *FROM formulario where numero = "+numero_id;                         
                            using (SQLiteCommand command = new SQLiteCommand(query, cnn))
                            {
                                using (SQLiteDataReader reader = command.ExecuteReader())
                                {
                                    reader.Read();
                                    id_pessoa = Convert.ToInt64(reader["numero"]);
                                    txbNome.Text = reader["nome"].ToString();
                                    txbEmail.Text = reader["email"].ToString();
                                    mtxbNascimento.Text = reader["nascimento"].ToString();
                                    mtxbCelular.Text = reader["telefone"].ToString();
                                    txbClassificacao.Text = reader["classificacao"].ToString(); //
                                    txbCurso.Text = reader["curso"].ToString();                                  
                                    txbSemestre.Text = reader["semestre"].ToString(); //
                                    txbMatricula.Text = reader["matricula"].ToString();
                                }
                            }/*Fim*/

                            /*Carregando lista de talentos do id_pessoa.*/
                            query = "SELECT numero, classe, talento, experiencia, descricao FROM talento_dicente WHERE id_pessoa = " + id_pessoa + " ORDER BY numero";
                            using (SQLiteCommand command = new SQLiteCommand(query, cnn))
                            {
                                
                                using (SQLiteDataAdapter dalist = new SQLiteDataAdapter(command))
                                {
                                    DataTable dtlist = new DataTable();
                                    dalist.Fill(dtlist);
                                    dgListaTalento.DataSource = dtlist.DefaultView;
                                }
                            }/*Fim*/
                            cnn.Close();
                        }
                     }break;
                case "docente":
                    { 

                    }break;
            }
        }
    }
}
