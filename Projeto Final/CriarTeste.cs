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
    public partial class CriarTeste : MetroFramework.Controls.MetroUserControl
    {
        static MySqlConnection conn = new MySqlConnection();
        static MySqlCommand cmd = new MySqlCommand();
        static ConnectDB conn1 = new ConnectDB();

        static DataTable dataEU = new DataTable();

        public static string usernameCT { get; set; }
        public static string IDTESTE { get; set; }
        public static int idT { get; set; }
        static List<MetroLabel> lblID = new List<MetroLabel>();
        static List<MetroLabel> lblT = new List<MetroLabel>();
        static List<MetroButton> btnEdit = new List<MetroButton>();
        static List<MetroButton> btnRemover = new List<MetroButton>();

        public CriarTeste()
        {
            InitializeComponent();

        }


        private void btncriarTeste_Click(object sender, EventArgs e)
        {

            /*conn.ConnectionString = "datasource=192.168.1.62;port=3306;username=root;password=cinel123";
            conn.Open();
            cmd.Connection = conn;*/

            string username = conn1.utilizador = Form1.txtU;

            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;

            try
            {
                Console.WriteLine("Nome do user no click" + usernameCT);
                cmd.CommandText = "INSERT INTO Plataforma.testes(titulo,ufcd,formador) VALUES(@titulo,@ufcd,@formador)";
                cmd.Parameters.AddWithValue("@titulo", txtTitle.Text);
                cmd.Parameters.AddWithValue("@ufcd", boxUFCD.SelectedIndex.ToString());
                cmd.Parameters.AddWithValue("@formador", usernameCT.ToString());

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                MessageBox.Show("Teste criado com sucesso!");
                txtTitle.Text = "Insira o Titulo do teste.";
                cmd.Parameters.Clear();


            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
        }



        //Mostra os testes que estao criados pelo utilizador
        public  void MostrarTestes()
        {
            try
            {
                
                dataEU.Clear();
                PanelTestes.Controls.Clear();
                string conn = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
                string Query = "SELECT * FROM Plataforma.testes WHERE formador=@FormandoNome;";
                MySqlConnection conDatabase = new MySqlConnection(conn);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
                MySqlDataAdapter da = new MySqlDataAdapter(cmdDatabase);
                cmdDatabase.Parameters.AddWithValue("@FormandoNome", Forma.NomeUser);
                da.Fill(dataEU);

                int i = 0;

                lblID.Clear();
                lblT.Clear();
                btnEdit.Clear();
                btnRemover.Clear();

                Console.WriteLine("Numero de rows na dataeu  " + dataEU.Rows.Count);
                foreach (DataRow row in dataEU.Rows)
                {
                    string idteste = row["teste"].ToString();
                    string titulo = row["titulo"].ToString();

                    lblID.Add(new MetroLabel());
                    lblT.Add(new MetroLabel());
                    btnEdit.Add(new MetroButton());
                    btnRemover.Add(new MetroButton());


                    lblID[i].Height = 20;
                    lblID[i].Width = 30;
                    if (i == 0)
                    {
                        lblID[i].Location = new System.Drawing.Point(0, 10);
                    }
                    else
                    {
                        lblID[i].Location = new System.Drawing.Point(0, lblID[i - 1].Location.Y + 25);
                    }

                    lblID[i].Text = idteste;
                    PanelTestes.Controls.Add(lblID[i]);
                    lblID[i].Visible = false;

                    lblT[i].Height = 20;
                    lblT[i].Width = 300;
                    if (i == 0)
                    {
                        lblT[i].Location = new System.Drawing.Point(20, 10);
                    }
                    else
                    {
                        lblT[i].Location = new System.Drawing.Point(20, lblT[i - 1].Location.Y + 25);
                    }
                    // Configurar a localização
                    lblT[i].Text = titulo;
                    PanelTestes.Controls.Add(lblT[i]); // Desenha

                    btnEdit[i].Height = 20;
                    btnEdit[i].Text = "Editar";
                    btnEdit[i].Width = 60;
                    if (i == 0)
                    {
                        btnEdit[i].Location = new System.Drawing.Point(350, 10);
                    }
                    else
                    {
                        btnEdit[i].Location = new System.Drawing.Point(350, btnEdit[i - 1].Location.Y + 25);
                    }

                    btnRemover[i].Height = 20;
                    btnRemover[i].Width = 60;
                    btnRemover[i].Text = "Remover";

                    if (i == 0)
                    {
                        btnRemover[i].Location = new System.Drawing.Point(420, 10);
                    }
                    else
                    {
                        btnRemover[i].Location = new System.Drawing.Point(420, btnRemover[i - 1].Location.Y + 25);
                    }
                    btnEdit[i].Click += EditarTeste2;
                    btnRemover[i].Click += RemoverTeste;

                    PanelTestes.Controls.Add(btnEdit[i]);
                    PanelTestes.Controls.Add(btnRemover[i]);
                    i++;
                }
            }
            catch
            {
                Console.WriteLine("OLSDFAFSDFS");
            }

        }
        static EditarTeste wat = new EditarTeste();

        public static void EditarTeste2(object sender, EventArgs e)
        {
            var forma = Form.ActiveForm as Formador;


            var button = sender as MetroFramework.Controls.MetroButton;
            var index = btnEdit.IndexOf(button);

            IDTESTE = lblT[index].Text.ToString();

            Forma.MostrarTestePR(forma);
            forma.editarTeste1.Visible = true;
            forma.criarTeste1.Visible = false;

        }


        public void RemoverTeste(object sender, EventArgs e)
        {
            conn.Close();
            //var forma = Form.ActiveForm as Formador;

            conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            conn.Open();
            cmd.Connection = conn;

            var button = sender as MetroFramework.Controls.MetroButton;
            var index = btnRemover.IndexOf(button);
            idT = Int32.Parse(lblID[index].Text);
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;
            try
            {
                //cmd.CommandText = "DELETE FROM Plataforma.TestPerguntas where teste=@idteste;";
                cmd.CommandText = "DELETE FROM Plataforma.testes where teste=@idteste;";
                cmd.Parameters.AddWithValue("@idteste",idT);
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
                //MostrarTestes();
                conn.Close();
                MostrarTestes();
            }
        }



        //FUNCIONA
        private void btncriarTeste_Click_1(object sender, EventArgs e)
        {

            if(boxUFCD.SelectedItem != null && txtTitle.Text != null)
            {
                int ufcd = 0;
                string username = conn1.utilizador = Form1.txtU;
                conn.Close();
                conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
                conn.Open();
                cmd.Connection = conn;
                string Query = "SELECT Num FROM Plataforma.UFCD WHERE NomeUFCD=@UFCD;";
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conn);
                MySqlDataReader myReader;
                cmdDataBase.Parameters.AddWithValue("@UFCD", boxUFCD.SelectedItem.ToString());
                Console.WriteLine("UFCD : " + boxUFCD.SelectedItem.ToString());
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    ufcd = myReader.GetInt32("Num");

                }
                myReader.Close();
                MySqlTransaction transaction = conn.BeginTransaction();
                cmd.Transaction = transaction;

                try
                {
                    cmd.CommandText = "INSERT INTO Plataforma.testes(titulo,ufcd,formador) VALUES(@titulo,@ufcd,@formador)";
                    cmd.Parameters.AddWithValue("@titulo", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@ufcd", ufcd);
                    cmd.Parameters.AddWithValue("@formador", Forma.NomeUser);

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Teste criado com sucesso!");
                    txtTitle.Text = "Insira o Titulo do teste.";
                    cmd.Parameters.Clear();


                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Insira outro titulo para o teste.");
                }

            }
            else
            {
                MessageBox.Show("Insira toda a informação");
            }


            MostrarTestes();
        }
        

        private void CriarTeste_VisibleChanged(object sender, EventArgs e)
        {
            MostrarTestes();
        }
    }
}
