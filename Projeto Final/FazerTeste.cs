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

namespace Projeto_Final
{
    public partial class FazerTeste : MetroFramework.Controls.MetroUserControl
    {
        static MySqlConnection conn = new MySqlConnection();
        static MySqlCommand cmd = new MySqlCommand();

        public static string IDTESTE { get; set; }
        public static string IDUFCD { get; set; }
        public static int IDdoTESTE { get; set; }
        public static int DURACAO { get; set; }
        public static int result{ get; set; }
        public static int contadorTestes { get; set; }
        public static TimeSpan horadeInicio { get; set; }
        public static TimeSpan horadeFim { get; set; }
    
        DateTime dataRecebida;
        DateTime datadeHoje = DateTime.Today;
        


        public FazerTeste()
        {
            InitializeComponent();
            
        }


        public void LerTitulo()
        {
            lbl_Formador.Text = "Formador: ";
            lblData.Text = "Data: ";
            lblinicioTeste.Text = "Inicio: ";
            lblfimTeste.Text = "Fim: " ;
            lblDuracao.Text = "Duracao: ";

            lbltituloTeste.Text = "Titulo: " + ComboBoxTestes.SelectedItem.ToString();
            IDTESTE = ComboBoxTestes.SelectedItem.ToString();

            
            String stringLerTitulo = lbltituloTeste.Text;
            conn.Close();
            conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            conn.Open();
            cmd.Connection = conn;

           

            string Query = "SELECT * from Plataforma.EstadoDosTestes WHERE titulo=@titulo;";
            
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conn);
            MySqlDataReader myReader;
            cmdDataBase.Parameters.AddWithValue("@titulo", ComboBoxTestes.SelectedItem.ToString());
            myReader = cmdDataBase.ExecuteReader();

            
            while (myReader.Read())
            {
                lbl_Formador.Text = "Formador: " + myReader.GetString("Formador");
                lblData.Text = "Data: " + myReader.GetDateTime("datainicio").ToShortDateString();
                lblinicioTeste.Text = "Inicio: " + myReader.GetString("inicio");
                lblfimTeste.Text = "Fim: " + myReader.GetString("fim");
                lblDuracao.Text= "Duracao: "+ myReader.GetString("duracao")+ " minutos";
                DURACAO = myReader.GetInt32("duracao");
                IDUFCD = myReader.GetString("ufcd");
                horadeInicio = myReader.GetTimeSpan("inicio");
                horadeFim = myReader.GetTimeSpan("fim");
                contadorTestes= myReader.GetInt32("TestesFeitos");
                IDdoTESTE = myReader.GetInt32("idTeste");
            }
            myReader.Close();
            VerificarFazerTestes();

            if (TimeBetween(DateTime.Now, horadeInicio, horadeFim) == true && result<1)
            {
                btnStartTeste.Enabled = true;

            }
            else
            {
                btnStartTeste.Enabled = false;
            }
            
            
        }
        public void VerificarFazerTestes()
        {

            string conn = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            
            string Query = "SELECT COUNT(*) FROM Plataforma.RegistaNotas WHERE id_Aluno=@id_Aluno AND id_Teste=@id_Teste AND id_Turma=@id_Turma AND Nome=@Nome;";
            MySqlConnection conDatabase = new MySqlConnection(conn);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            conDatabase.Open();
            cmdDatabase.Parameters.AddWithValue("@id_Teste", FazerTeste.IDTESTE);
            cmdDatabase.Parameters.AddWithValue("@id_Turma", Forma.TurmaAluno);
            cmdDatabase.Parameters.AddWithValue("@id_Aluno", Forma.idUser);
            cmdDatabase.Parameters.AddWithValue("@id_UFCD", FazerTeste.IDUFCD);
            cmdDatabase.Parameters.AddWithValue("@Nome", Forma.NomeUser);
            MySqlDataReader reader;
            reader = cmdDatabase.ExecuteReader();

            while (reader.Read())
            {

               //result = reader.GetInt32("COUNT(*)");
                result = reader.GetInt32(0);
                Console.WriteLine(result+ "");
            }

            reader.Close();
            conDatabase.Close();
        }
        private void ComboBoxTestes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LerTitulo();

        }

        private void btnStartTeste_Click(object sender, EventArgs e)
        {
            Responder responder = new Responder();
            responder.Show();
            btnStartTeste.Enabled = false;    //Quando carrega para fazer o teste, não poderá fazer mais nenhuma vez, caso tenha terminado o teste
        }

        public void LerTestesComboBox()
        {
            conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            conn.Open();
            cmd.Connection = conn;
            string Query = "SELECT * from Plataforma.EstadoDosTestes;";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conn);
            MySqlDataReader myReader;
            myReader = cmdDataBase.ExecuteReader();
            while (myReader.Read())
            {
                IDTESTE = myReader.GetString("titulo");
                dataRecebida = myReader.GetDateTime("datainicio");
                if (dataRecebida >= datadeHoje)
                {
                    ComboBoxTestes.Items.Add(IDTESTE);
                }
            }
            myReader.Close();
        }

        

        private void FazerTeste_Load(object sender, EventArgs e)
        {
            LerTestesComboBox();
            
        }

        bool TimeBetween(DateTime datetime, TimeSpan start, TimeSpan end)
        {
            // converte o datetime para TimeSpan
            TimeSpan now = datetime.TimeOfDay;
            // ve se as horas do sistema estão inseridas no intervalo entre a data de inicio e a data de fim
            if (start <= now && now <= end)
                return true;
            
            return false;
        }
    }
}
