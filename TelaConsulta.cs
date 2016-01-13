using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace talentoso
{
    public partial class TelaConsulta : Form
    {
        public TelaConsulta()
        {
            InitializeComponent();
        }

        /*Carregando os Datagrid's com a lista de Dicentes e Docentes.*/
        private void TelaConsulta_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection cnn = new SQLiteConnection("Data source=talentoso.db"))
            {
                //Dados dos Dicentes cadastrados.
                cnn.Open();
                string query = "SELECT numero,nome, email, telefone, matricula FROM  formulario where classificacao = 'dicente' order by numero";
                using (SQLiteCommand command = new SQLiteCommand(query, cnn))
                { 
                    using (SQLiteDataAdapter daList = new SQLiteDataAdapter(command))
                    {
                        DataTable dtDicentes = new DataTable();
                        daList.Fill(dtDicentes);
                        dgListaDicente.DataSource = dtDicentes.DefaultView;

                        lbCountDicentes.Text = "Total: " + dgListaDicente.RowCount.ToString();
                    }
                }
                //Dados do Docentes cadastrados.
                query = "SELECT numero, nome, email, telefone FROM  formulario where classificacao = 'docente' order by numero";
                using (SQLiteCommand command = new SQLiteCommand(query, cnn))
                {
                    DataTable dtDocentes = new DataTable();
                    using (SQLiteDataAdapter daList = new SQLiteDataAdapter(command))
                    {
                        daList.Fill(dtDocentes);
                        dgListaDocente.DataSource = dtDocentes.DefaultView;
                        lbCountDocentes.Text = "Total: " + dgListaDocente.RowCount.ToString();
                    }
                }
               cnn.Close();
            }
        }

        private void bttBuscaDicente_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection cnn = new SQLiteConnection("Data source = talentoso.db"))
            { 
                cnn.Open();
                string query = "SELECT *FROM formulario WHERE classificacao='dicente' AND matricula LIKE '%" + txbNumeroMatriculaDicente.Text + "'% ordey by numero";
                using (SQLiteCommand command = new SQLiteCommand(query, cnn))
                {
                    DataTable dtDicentes = new DataTable();
                    using (SQLiteDataAdapter daList = new SQLiteDataAdapter(command))
                    {
                        daList.Fill(dtDicentes);
                        dgListaDicente.DataSource = dtDicentes.DefaultView;
                        lbCountDicentes.Text = "Total: " + dgListaDicente.RowCount.ToString();
                    }
                }
                cnn.Close();
            }
        }

        private void bttBuscaDocente_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection cnn = new SQLiteConnection("Data source = talentoso.db"))
            {
                cnn.Open();
                string query = "SELECT *FROM formulario WHERE classificacao='docente' AND matricula LIKE '%" + txbNumeroMatriculaDicente.Text + "'% ordey by numero";
                using (SQLiteCommand command = new SQLiteCommand(query, cnn))
                {
                    DataTable dtDocentes = new DataTable();
                    using (SQLiteDataAdapter daList = new SQLiteDataAdapter(command))
                    {
                        daList.Fill(dtDocentes);
                        dgListaDocente.DataSource = dtDocentes.DefaultView;
                        lbCountDocentes.Text = "Total: " + dgListaDocente.RowCount.ToString();
                    }
                }
                cnn.Close();
            }
        }

        private void dgListaDicente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TelaConsultaEdicao edicao = new TelaConsultaEdicao();
            edicao.numero_id = dgListaDicente.SelectedCells[0].FormattedValue.ToString();
            edicao.classificacao = "dicente";
            edicao.ShowDialog();
            TelaConsulta_Load(null, null);
        }

        private void dgListaDocente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TelaConsultaEdicao edicao = new TelaConsultaEdicao();
            edicao.numero_id = dgListaDocente.SelectedCells[0].FormattedValue.ToString();
            edicao.classificacao = "docente";
            edicao.ShowDialog();
            TelaConsulta_Load(null, null);
        }

    }
}
