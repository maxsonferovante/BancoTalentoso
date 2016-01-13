using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace talentoso
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            //Arquivos temporários
            if (Directory.Exists("temp"))
            {
                Directory.Delete("temp", true);
                Directory.CreateDirectory("temp");
            }
            else
            {
                Directory.CreateDirectory("temp");
            }
            //Nome do arquivo do backup do dia.
            string autobackupArquivo = "Backup\\talentoso_" + DateTime.Now.ToString("dd-MM-yyyy") + ".db";
            //Verifica se o banco de dados existe
            if (File.Exists("talentoso.db") == true)
            {
                //Verificar se o backup do dia existe
                if (File.Exists(autobackupArquivo))
                {
                    //Apagar backups antigos. Serão armazenados somente arquivos para uma semana.
                    ApagaBackupAntigo();
                }
                //Caso o backup do dia não exista...
                else
                {
                    //Verificar se já foi feito algum backup na vida
                    if (Directory.Exists("Backup"))
                    {
                        //Se sim, o backup do dia não foi feito, e será feito neste momento.
                        File.Copy("talentoso.db", autobackupArquivo);
                        ApagaBackupAntigo();
                    }
                    //Se nunca nunca foi feito...
                    else
                    {
                        //...criar a pasta de backups e salvar o backup do dia.
                        Directory.CreateDirectory("Backup");
                        File.Copy("talentoso.db", autobackupArquivo);
                    }
                }
                //Caso o backup manual teha sido feito...
                while (GetDifferenceDays() > 15)
                {
                    MessageBox.Show("Para utilizar o programa, faça um backup agora!", "Alerta de backup", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SaveFileDialog dialogSalvarBackupObrigatorio = new SaveFileDialog();
                    dialogSalvarBackupObrigatorio.Title = "talentoso - Salvar cópia de segurança obrigatória...";
                    dialogSalvarBackupObrigatorio.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
                    dialogSalvarBackupObrigatorio.Filter = "Banco de dados do talentoso (*.db)|*.db";


                    //Nome do arquivo padrão: talentoso_dd-MM-yyyy.db
                    dialogSalvarBackupObrigatorio.FileName = "talentoso_" + DateTime.Now.ToString("dd-MM-yyyy") + ".db";
                    DialogResult resultado = dialogSalvarBackupObrigatorio.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        System.IO.File.Copy("talentoso.db", dialogSalvarBackupObrigatorio.FileName, true);
                        MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updataDate();
                    }
                }
                InitializeComponent();
            }
            else
            {
                //Criação de um banco de dados vazio.
                MessageBox.Show("Banco de dados não encontrado!", "Erro fatal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                using (SQLiteConnection cnn = new SQLiteConnection("data source=talentoso.db"))
                {
                    cnn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                    {
                        cmd.CommandText = "CREATE TABLE \"formulario\" (\"numero\" INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL , \"nome\" TEXT NOT NULL, \"nascimento\" TEXT NOT NULL,\"matricula\" TEXT NOT NULL , \"email\" TEXT NOT NULL, \"telefone\" TEXT NOT NULL, \"classificacao\" TEXT NOT NULL,\"curso\" TEXT NOT NULL,\"semestre\" TEXT NOT NULL )";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE TABLE \"talento_dicente\" (\"numero\" INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL ,\"classe\" TEXT NOT NULL, \"talento\" TEXT NOT NULL, \"experiencia\" TEXT NOT NULL, \"descricao\" TEXT NOT NULL, \"id_pessoa\" INTEGER NOT NULL)";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE TABLE \"talento_docente\" (\"numero\" INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL ,\"atuacao\" TEXT NOT NULL,\"experiencia\" TEXT NOT NULL, \"descricao\" TEXT NOT NULL, \"id_pessoa\" INTEGER NOT NULL )";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "CREATE  TABLE \"backup\" (\"data\" TEXT NOT NULL )";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "INSERT INTO \"backup\" VALUES (\"" + DateTime.Now.ToString("dd/MM/yyyy") + "\");";
                        cmd.ExecuteNonQuery();
                    }
                    cnn.Close();
                }
                MessageBox.Show("Um banco de dados vazio foi criado. Reinicie o programa.", "Banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastro cadastro = new TelaCadastro();
            cadastro.ShowDialog();
        }
        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaConsulta consulta = new TelaConsulta();
            consulta.ShowDialog();
        }

        private void caçarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Caça talentos: caçar.
        }

        public void ApagaBackupAntigo()
        {
            File.Delete("Backup\\talentoso_" + DateTime.Now.AddDays(-7).ToString("dd-MM-yyyy") + ".db");
            File.Delete("Backup\\talentoso_" + DateTime.Now.AddDays(-8).ToString("dd-MM-yyyy") + ".db");
            File.Delete("Backup\\talentoso_" + DateTime.Now.AddDays(-9).ToString("dd-MM-yyyy") + ".db");
        }
        //Coisa feia que deve estar escodida em uma método no fim do documento, mas nos trás a última data em que foi realizado no backup manual.
        public double GetDifferenceDays()
        {
            double dias;
            using (SQLiteConnection cnn = new SQLiteConnection("data source=talentoso.db "))
            {
                cnn.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM backup ", cnn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        string ultimadata = reader["data"].ToString();
                        TimeSpan direfencia = DateTime.Now - Convert.ToDateTime(ultimadata);
                        dias = direfencia.TotalDays;
                    }
                }
                cnn.Close();
            }
            return dias;
        }
        //Mais uma coisa feia: essa faz a atualização da data do backup manual.
        public void updataDate()
        {
            using (SQLiteConnection cnn = new SQLiteConnection("data source = talentoso.db"))
            {
                cnn.Open();
                using (SQLiteCommand command = new SQLiteCommand(cnn))
                {
                    command.CommandText = " UPDATE backup SET data = '" + DateTime.Now.ToString("dd-MM-yyyy") + "' where rowid = 1";
                    command.ExecuteNonQuery();
                }
                cnn.Close();
            }
        }
    }
}
