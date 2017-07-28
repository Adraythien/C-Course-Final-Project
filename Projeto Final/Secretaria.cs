using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class Secretaria : MetroFramework.Forms.MetroForm
    {
        ConnectDB cDB = new ConnectDB();

        
        public string username { get; set; }
        public string sName { get; set; }

        private MySqlConnection conn = new MySqlConnection();
        private MySqlCommand cmd = new MySqlCommand();


        public Secretaria()
        {
            InitializeComponent();
        }

        private void Secretaria_Load(object sender, EventArgs e)
        {
            NomeUtilizador();
            timer.Stop();
            timer.Start();
            dashSecretaria1.ContaUsers();

        }

        public void NomeUtilizador()
        {
            conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            conn.Open();
            cmd.Connection = conn;
            username = cDB.utilizador = Form1.txtU;

            cmd.CommandText = "SELECT * FROM Plataforma.users WHERE username=@username;";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.ExecuteNonQuery();

            MySqlDataReader myReader;

            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                sName = myReader.GetString("Nome");
                lbNomeUser.Text = "Bem Vindo, "+sName;
                Console.WriteLine(sName);
                username = sName;
            }

            myReader.Close();
        }

        private void tile_AddAluno_Click(object sender, EventArgs e)
        {
            dashSecretaria1.Visible = false;
            editarProfUfcd1.Visible = false;
            alterPass1.Visible = false;
            editarUFCD1.Visible = false;
            editarTurma1.Visible = false;
            editarUtilizadores1.Visible = false;
            addUFCD1.Visible = false;
            addTurma1.Visible = false;
            addProfessor1.Visible = false;
            addSecretaria1.Visible = false;
            addAluno1.Visible = true;
            addAluno1.ShowTurma();
        }

        private void tile_AddProf_Click(object sender, EventArgs e)
        {
            dashSecretaria1.Visible = false;
            editarProfUfcd1.Visible = false;
            alterPass1.Visible = false;
            editarUFCD1.Visible = false;
            editarTurma1.Visible = false;
            editarUtilizadores1.Visible = false;
            addUFCD1.Visible = false;
            addTurma1.Visible = false;
            addAluno1.Visible = false;
            addSecretaria1.Visible = false;
            addProfessor1.Visible = true;
            addProfessor1.ShowUFCD();
        }

        private void tile_AddSecretaria_Click(object sender, EventArgs e)
        {
            dashSecretaria1.Visible = false;
            editarProfUfcd1.Visible = false;
            alterPass1.Visible = false;
            editarUFCD1.Visible = false;
            editarTurma1.Visible = false;
            editarUtilizadores1.Visible = false;
            addUFCD1.Visible = false;
            addTurma1.Visible = false;
            addAluno1.Visible = false;
            addProfessor1.Visible = false;
            addSecretaria1.Visible = true;
        }

        private void tile_AddTurma_Click(object sender, EventArgs e)
        {
            dashSecretaria1.Visible = false;
            editarProfUfcd1.Visible = false;
            alterPass1.Visible = false;
            editarUFCD1.Visible = false;
            editarTurma1.Visible = false;
            editarUtilizadores1.Visible = false;
            addUFCD1.Visible = false;
            addAluno1.Visible = false;
            addSecretaria1.Visible = false;
            addProfessor1.Visible = false;
            addTurma1.Visible = true;
        }

        private void tile_AddUFCD_Click(object sender, EventArgs e)
        {
            dashSecretaria1.Visible = false;
            editarProfUfcd1.Visible = false;
            alterPass1.Visible = false;
            editarUFCD1.Visible = false;
            editarTurma1.Visible = false;
            editarUtilizadores1.Visible = false;
            addAluno1.Visible = false;
            addSecretaria1.Visible = false;
            addProfessor1.Visible = false;
            addTurma1.Visible = false;
            addUFCD1.Visible = true;
        }

        private void tile_EditarUtilizadores_Click(object sender, EventArgs e)
        {
            dashSecretaria1.Visible = false;
            editarProfUfcd1.Visible = false;
            alterPass1.Visible = false;
            editarUFCD1.Visible = false;
            editarTurma1.Visible = false;
            addAluno1.Visible = false;
            addSecretaria1.Visible = false;
            addProfessor1.Visible = false;
            addTurma1.Visible = false;
            addUFCD1.Visible = false;
            editarUtilizadores1.Visible = true;
            
        }

        private void tile_EditarTurma_Click(object sender, EventArgs e)
        {
            dashSecretaria1.Visible = false;
            editarProfUfcd1.Visible = false;
            alterPass1.Visible = false;
            editarUFCD1.Visible = false;
            addAluno1.Visible = false;
            addSecretaria1.Visible = false;
            addProfessor1.Visible = false;
            addTurma1.Visible = false;
            addUFCD1.Visible = false;
            editarUtilizadores1.Visible = false;
            editarTurma1.Visible = true;
            
        }

        private void tile_EditarUFCD_Click(object sender, EventArgs e)
        {
            dashSecretaria1.Visible = false;
            editarProfUfcd1.Visible = false;
            alterPass1.Visible = false;
            addAluno1.Visible = false;
            addSecretaria1.Visible = false;
            addProfessor1.Visible = false;
            addTurma1.Visible = false;
            addUFCD1.Visible = false;
            editarUtilizadores1.Visible = false;
            editarTurma1.Visible = false;
            editarUFCD1.Visible = true;
            

        }

        private void tile_DefenicoeAltPass_Click(object sender, EventArgs e)
        {
            dashSecretaria1.Visible = false;
            editarProfUfcd1.Visible = false;
            addAluno1.Visible = false;
            addSecretaria1.Visible = false;
            addProfessor1.Visible = false;
            addTurma1.Visible = false;
            addUFCD1.Visible = false;
            editarUtilizadores1.Visible = false;
            editarTurma1.Visible = false;
            editarUFCD1.Visible = false;
            alterPass1.Visible = true;
            
        }

        private void Secretaria_FormClosing(object sender, FormClosingEventArgs e)
        {


            System.Environment.Exit(0);
            /*
            timer.Dispose();
            cDB.KillConnection();
            FormLogin.Show();
            */
          


        }

        private void Tile_EditarProfUFCD_Click(object sender, EventArgs e)
        {
            dashSecretaria1.Visible = false;
            addAluno1.Visible = false;
            addSecretaria1.Visible = false;
            addProfessor1.Visible = false;
            addTurma1.Visible = false;
            addUFCD1.Visible = false;
            editarUtilizadores1.Visible = false;
            editarTurma1.Visible = false;
            editarUFCD1.Visible = false;
            alterPass1.Visible = false;
            editarProfUfcd1.Visible = true;
           
        }

        private void Tile_Inicio_Click(object sender, EventArgs e)
        {
            addAluno1.Visible = false;
            addSecretaria1.Visible = false;
            addProfessor1.Visible = false;
            addTurma1.Visible = false;
            addUFCD1.Visible = false;
            editarUtilizadores1.Visible = false;
            editarTurma1.Visible = false;
            editarUFCD1.Visible = false;
            alterPass1.Visible = false;
            editarProfUfcd1.Visible = false;
            dashSecretaria1.ContaUsers();
            dashSecretaria1.Visible = true;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
           
            dashSecretaria1.ShowTime();
            dashSecretaria1.ShowCPURAM();
           
        }
    }
}
