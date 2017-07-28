using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Controls;

namespace Projeto_Final
{
    public partial class DashFormador : MetroFramework.Controls.MetroUserControl
    {
        public DashFormador()
        {
            InitializeComponent();
        }

        DataTable dataNotas = new DataTable();
        static MySqlCommand cmd = new MySqlCommand();
        public void VerNotasDaTurma()
        {
            string conn = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            string Query = "SELECT Nome AS Formando, Cotacao AS Pontos FROM Plataforma.RegistaNotas WHERE id_Teste=@Teste AND id_Turma=@turma AND id_UFCD=@ufcd;";
            MySqlConnection conDatabase = new MySqlConnection(conn);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            cmdDatabase.Parameters.AddWithValue("@Teste", ComboTeste.SelectedItem);
            cmdDatabase.Parameters.AddWithValue("@turma", ComboTurma.SelectedItem);
            cmdDatabase.Parameters.AddWithValue("@ufcd", ComboUFCD.SelectedItem);

            MySqlDataAdapter da = new MySqlDataAdapter(cmdDatabase);
            dataNotas.Clear();
            da.Fill(dataNotas);
            dataGridNotas.DataSource = dataNotas;

        }

        List<int> idtestes = new List<int>();
        private void ComboUFCD_SelectedValueChanged(object sender, EventArgs e)
        {
            MySqlConnection conn2 = new MySqlConnection();
            ComboTeste.Items.Clear();
            ComboTeste.ResetText();


            ComboTeste.Refresh();
            ComboTurma.Refresh();
            idtestes.Clear();
            if (ComboUFCD.SelectedItem != null)
            {
                var forma = Form.ActiveForm as Formador;
                Console.WriteLine("wtf");
                forma.realizarTeste1.comboTestes.Items.Clear();
                conn2.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
                conn2.Open();
                string Query = "SELECT Teste,titulo FROM Plataforma.testes INNER JOIN Plataforma.UFCD ON ufcd=Num  WHERE NomeUFCD=@ufcd;";

                //MySqlConnection conDatabase = new MySqlConnection(conn);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conn2);
                cmdDataBase.Parameters.AddWithValue("@ufcd", ComboUFCD.SelectedItem);
                MySqlDataReader myReader;
                //Forma.Connection();

                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                    string testes = myReader.GetString("titulo");
                    int id = myReader.GetInt32("Teste");
                    idtestes.Add(id);
                    Console.WriteLine("testes" + testes);
                    forma.dashFormador1.ComboTeste.Items.Add(testes);

                }
                myReader.Close();

                ComboTeste.Enabled = true;
                Forma.ComboboxTurma();
            }
        }

        private void ComboTurma_SelectedValueChanged(object sender, EventArgs e)
        {
            VerNotasDaTurma();
        }

        static List<MetroLabel> LabelsTitulo = new List<MetroLabel>();
        static List<MetroLabel> DataTeste = new List<MetroLabel>();
        static List<MetroLabel> ListaTurma = new List<MetroLabel>();
        static List<MetroLabel> ListaUFCD = new List<MetroLabel>();
        static List<MetroLabel> horainicio = new List<MetroLabel>();
        static List<MetroButton> BtnsCancelar = new List<MetroButton>();
        static List<int> idAgenda = new List<int>();
        static MySqlConnection conn = new MySqlConnection();

        public static void VerAgenda(Formador forma)
        {
            if (forma.dashFormador1.PanelTestesAgendados.Controls.Count - 1 > 0)
            {

                for (int ix = forma.dashFormador1.PanelTestesAgendados.Controls.Count - 1; ix >= 0; ix--)
                {

                    forma.dashFormador1.PanelTestesAgendados.Controls[ix].Dispose();

                }

            }

            conn.Close();
            conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            conn.Open();
            cmd.Connection = conn;
            string Query = "SELECT Titulo,inicio AS Inicio, datainicio ,turma AS Turma ,ufcd AS UFCD ,IDAgenda FROM Plataforma.EstadoDosTestes WHERE Formador=@Formador;";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conn);
            MySqlDataReader myReader;
            cmdDataBase.Parameters.AddWithValue("@Formador", Forma.NomeUser);
            myReader = cmdDataBase.ExecuteReader();

            LabelsTitulo.Clear();
            DataTeste.Clear();
            ListaTurma.Clear();
            ListaUFCD.Clear();
            BtnsCancelar.Clear();
            horainicio.Clear();
            while (myReader.Read())
            {
                DataTeste.Add(new MetroLabel());
                ListaTurma.Add(new MetroLabel());
                ListaUFCD.Add(new MetroLabel());
                horainicio.Add(new MetroLabel());
                idAgenda.Add(myReader.GetInt32("IDAgenda"));

                LabelsTitulo.Add(new MetroLabel());
                LabelsTitulo[LabelsTitulo.Count - 1].Width = 150;
                LabelsTitulo[LabelsTitulo.Count - 1].Height = 15;
                LabelsTitulo[LabelsTitulo.Count - 1].Text = myReader.GetString("Titulo");

                BtnsCancelar.Add(new MetroButton());
                BtnsCancelar[BtnsCancelar.Count - 1].Text = "Cancelar";
                BtnsCancelar[BtnsCancelar.Count - 1].Width = 80;
                BtnsCancelar[BtnsCancelar.Count - 1].Height = 20;

                BtnsCancelar[BtnsCancelar.Count - 1].Click += new EventHandler(Cancelar);

                DataTeste[DataTeste.Count - 1].Text = myReader.GetDateTime("datainicio").ToShortDateString();
                DataTeste[DataTeste.Count - 1].Width = 80;
                DataTeste[DataTeste.Count - 1].Height = 20;

                ListaUFCD[ListaUFCD.Count - 1].Text = myReader.GetString("ufcd");
                ListaUFCD[ListaUFCD.Count - 1].Width = 80;
                ListaUFCD[ListaUFCD.Count - 1].Height = 20;

                ListaTurma[ListaTurma.Count - 1].Text = myReader.GetString("turma");
                ListaTurma[ListaTurma.Count - 1].Width = 80;
                ListaTurma[ListaTurma.Count - 1].Height = 20;

                horainicio[horainicio.Count - 1].Text = myReader.GetString("inicio");
                horainicio[horainicio.Count - 1].Height = 20;
                horainicio[horainicio.Count - 1].Width = 80;
                if (LabelsTitulo.Count == 1)
                {
                    LabelsTitulo[LabelsTitulo.Count - 1].Location = new System.Drawing.Point(0, 20);
                    BtnsCancelar[BtnsCancelar.Count - 1].Location = new System.Drawing.Point(LabelsTitulo[LabelsTitulo.Count - 1].Location.X + 200, LabelsTitulo[LabelsTitulo.Count - 1].Location.Y);
                    DataTeste[DataTeste.Count - 1].Location = new Point(LabelsTitulo[LabelsTitulo.Count - 1].Location.X, LabelsTitulo[LabelsTitulo.Count - 1].Location.Y + 35);
                    horainicio[horainicio.Count - 1].Location = new Point(BtnsCancelar[BtnsCancelar.Count - 1].Location.X, DataTeste[DataTeste.Count - 1].Location.Y);

                    ListaTurma[ListaTurma.Count - 1].Location = new Point(LabelsTitulo[LabelsTitulo.Count - 1].Location.X, DataTeste[DataTeste.Count - 1].Location.Y + 35);
                    ListaUFCD[ListaUFCD.Count - 1].Location = new Point(horainicio[horainicio.Count - 1].Location.X, horainicio[horainicio.Count - 1].Location.Y + 35);

                }
                
                else
                {
                    LabelsTitulo[LabelsTitulo.Count - 1].Location = new Point(LabelsTitulo[LabelsTitulo.Count - 2].Location.X, LabelsTitulo[LabelsTitulo.Count - 2].Location.Y + 150);
                    BtnsCancelar[BtnsCancelar.Count - 1].Location = new System.Drawing.Point(LabelsTitulo[LabelsTitulo.Count - 1].Location.X + 200, LabelsTitulo[LabelsTitulo.Count - 1].Location.Y);
                    DataTeste[DataTeste.Count - 1].Location = new Point(LabelsTitulo[LabelsTitulo.Count - 1].Location.X, LabelsTitulo[LabelsTitulo.Count - 1].Location.Y + 35);
                    horainicio[horainicio.Count - 1].Location = new Point(BtnsCancelar[BtnsCancelar.Count - 1].Location.X, DataTeste[DataTeste.Count - 1].Location.Y);
                    ListaTurma[ListaTurma.Count - 1].Location = new Point(LabelsTitulo[LabelsTitulo.Count - 1].Location.X, DataTeste[DataTeste.Count - 1].Location.Y + 35);
                    ListaUFCD[ListaUFCD.Count - 1].Location = new Point(horainicio[horainicio.Count - 1].Location.X, horainicio[horainicio.Count - 1].Location.Y + 35);

                }
                forma.dashFormador1.PanelTestesAgendados.Controls.Add(LabelsTitulo[LabelsTitulo.Count - 1]);
                forma.dashFormador1.PanelTestesAgendados.Controls.Add(BtnsCancelar[BtnsCancelar.Count - 1]);
                forma.dashFormador1.PanelTestesAgendados.Controls.Add(ListaTurma[ListaTurma.Count - 1]);

                forma.dashFormador1.PanelTestesAgendados.Controls.Add(DataTeste[DataTeste.Count - 1]);
                forma.dashFormador1.PanelTestesAgendados.Controls.Add(horainicio[horainicio.Count - 1]);
                forma.dashFormador1.PanelTestesAgendados.Controls.Add(ListaUFCD[ListaUFCD.Count - 1]);

                forma.dashFormador1.PanelTestesAgendados.Refresh();
            }


        }
        public static int numeroAgenda { get; set; }
        public static void Cancelar(object sender, EventArgs e)
        {
            conn.Close();
            //var forma = Form.ActiveForm as Formador;

            conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            conn.Open();
            cmd.Connection = conn;

            var button = sender as MetroFramework.Controls.MetroButton;
            var index = BtnsCancelar.IndexOf(button);
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;

            DialogResult dialogResult = MessageBox.Show("Tem a certeza que deseja cancelar o teste?", "Atenção!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    //cmd.CommandText = "DELETE FROM Plataforma.TestPerguntas where teste=@idteste;";
                    cmd.CommandText = "DELETE FROM Plataforma.EstadoDosTestes where IDAgenda=@IDAgenda;";
                    cmd.Parameters.AddWithValue("@IDAgenda", idAgenda[index]);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    transaction.Commit();

                    MessageBox.Show("DELETE efectuado com sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                }
                finally
                {
                    conn.Close();
                    var forma = Form.ActiveForm as Formador;
                    VerAgenda(forma);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            
            
        }

        private void ComboTeste_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboTurma.Items.Clear();
            Forma.ComboboxTurma();
        }
    }
}
