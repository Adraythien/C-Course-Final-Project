using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class Formador : MetroFramework.Forms.MetroForm
    {
        public string username { get; set; }
        public string sName { get; set; }


        ConnectDB conn1 = new ConnectDB();
        Form1 frm1 = new Form1();


        private MySqlConnection conn = new MySqlConnection();
        private MySqlCommand cmd = new MySqlCommand();
        

        public Formador()
        {
            InitializeComponent();

        }

        private void Formador_Load(object sender, EventArgs e)
        {
            
            Forma.Informacao();
            lblBemVindo.Text = "Bem vindo, " + Forma.NomeUser;
            criarTeste1.Visible = false;
            editarTeste1.Visible = false;
            realizarTeste1.Visible = false;
            alterPass1.Visible = false;
            editarPerguntas1.Visible = false;
            dashFormador1.Visible = true;
            
        }


        private void metroTile8_Click(object sender, EventArgs e)
        {
            Perguntas frm = new Perguntas();
            frm.Show();
            //frm.UFCDCombo();
        }

        /*public void Utilizador()
        {
            conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            conn.Open();
            cmd.Connection = conn;
            username = conn1.utilizador = Form1.txtU;

            cmd.CommandText = "SELECT * FROM Plataforma.users WHERE username=@username;";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.ExecuteNonQuery();

            MySqlDataReader myReader;

            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                sName = myReader.GetString("Nome");
                lblutilizador.Text = sName;
                Console.WriteLine(sName);
                username = sName;
            }

            myReader.Close();
        }*/

        private void tileCriar_Click(object sender, EventArgs e)
        {
            criarTeste1.Visible = true;
            editarTeste1.Visible = false;
            realizarTeste1.Visible = false;
            alterPass1.Visible = false;
            editarPerguntas1.Visible = false;
            dashFormador1.Visible = false;
        }
        public void metroTile1_Click(object sender, EventArgs e)
        {
            criarTeste1.Visible = false;
            editarTeste1.Visible = true;
            realizarTeste1.Visible = false;
            alterPass1.Visible = false;
            editarPerguntas1.Visible = false;
            dashFormador1.Visible = false;
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            realizarTeste1.Visible = true;
            criarTeste1.Visible = false;
            editarTeste1.Visible = false;
            alterPass1.Visible = false;
            editarPerguntas1.Visible = false;
            dashFormador1.Visible = false;
        }

        private void Formador_Shown(object sender, EventArgs e)
        {
            Forma.UFCDCombo();
            var forma = Form.ActiveForm as Formador;
            DashFormador.VerAgenda(forma);
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            alterPass1.Visible = true;
            realizarTeste1.Visible = false;
            criarTeste1.Visible = false;
            editarTeste1.Visible = false;
            editarPerguntas1.Visible = false;
            dashFormador1.Visible = false;
        }

        private void Formador_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            editarPerguntas1.Visible = true;
            alterPass1.Visible = false;
            realizarTeste1.Visible = false;
            criarTeste1.Visible = false;
            editarTeste1.Visible = false;
            dashFormador1.Visible = false;
        }
        
        private void lblInicio_Click(object sender, EventArgs e)
        {
            editarPerguntas1.Visible = false;
            alterPass1.Visible = false;
            realizarTeste1.Visible = false;
            criarTeste1.Visible = false;
            editarTeste1.Visible = false;
            dashFormador1.Visible = true;
            var forma = Form.ActiveForm as Formador;
            DashFormador.VerAgenda(forma);
        }
    }
}
