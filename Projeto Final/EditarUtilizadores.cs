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
    public partial class EditarUtilizadores : MetroFramework.Controls.MetroUserControl
    {
        ConnectDB cDB = new ConnectDB();

        public static string txtEUID = string.Empty; 
        public static string txtEUNome = string.Empty;
        public static string txtEUUfcd = string.Empty;
        public static string txtEUTurma = string.Empty;
        public static string txtEUUsername = string.Empty;
        public static string txtEUPassword = string.Empty;
        public static string txtEUAcesso = string.Empty;
        DataTable dataEU = new DataTable();

        public EditarUtilizadores()
        {
            InitializeComponent();
            
        }

        public void VerUtilizadores()
        {
            
            string conn = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            string Query = "SELECT * FROM Plataforma.users";
            MySqlConnection conDatabase = new MySqlConnection(conn);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataAdapter da = new MySqlDataAdapter(cmdDatabase);
            dataEU.Clear();
            da.Fill(dataEU);                           
            dataGridEU.DataSource = dataEU;
            

        }

        private void EU_Nome_Enter(object sender, EventArgs e)
        {
            if (EU_Nome.Text == "Nome")
            {
                EU_Nome.Text = "";
            }

        }

        private void EU_Nome_Leave(object sender, EventArgs e)
        {
            if (EU_Nome.Text == "")
            {
                EU_Nome.Text = "Nome";
            }

        }

        private void EU_Ufcd_Enter(object sender, EventArgs e)
        {
            if (EU_Ufcd.Text == "UFCD")
            {
                EU_Ufcd.Text = "";
            }

        }

        private void EU_Ufcd_Leave(object sender, EventArgs e)
        {
            if (EU_Ufcd.Text == "")
            {
                EU_Ufcd.Text = "UFCD";
            }

        }

        private void EU_Turma_Enter(object sender, EventArgs e)
        {
            if (EU_Turma.Text=="Turma")
            {
                EU_Turma.Text = "";
            }

        }

        private void EU_Turma_Leave(object sender, EventArgs e)
        {
            if (EU_Turma.Text == "")
            {
                EU_Turma.Text = "Turma";
            }

        }

        private void EU_Username_Enter(object sender, EventArgs e)
        {
            if (EU_Username.Text == "Username")
            {
                EU_Username.Text = "";
            }

        }

        private void EU_Username_Leave(object sender, EventArgs e)
        {
            if (EU_Username.Text == "")
            {
                EU_Username.Text = "Username";
            }
        }

        private void EU_Password_Enter(object sender, EventArgs e)
        {
            if (EU_Password.Text == "Password")
            {
                EU_Password.Text = "";
            }

        }

        private void EU_Password_Leave(object sender, EventArgs e)
        {
            if (EU_Password.Text == "")
            {
                EU_Password.Text = "Password";
            }
        }

        private void EU_Level_Enter(object sender, EventArgs e)
        {
            if (EU_Level.Text == "Level")
            {
                EU_Level.Text = "";
            }
        }

        private void EU_Level_Leave(object sender, EventArgs e)
        {
            if (EU_Level.Text == "")
            {
                EU_Level.Text = "Level";
            }

        }

        private void bt_EUUpdate_Click(object sender, EventArgs e)
        {
            txtEUID = EU_Id.Text;
            txtEUNome = EU_Nome.Text;
            txtEUUfcd = EU_Ufcd.Text;
            txtEUTurma = EU_Turma.Text;
            txtEUUsername = EU_Username.Text;
            txtEUPassword = EU_Password.Text;
            txtEUAcesso = EU_Level.Text;

            cDB.Connection();
            cDB.UpdateUtilizadores();

        }

        private void bt_EUDelete_Click(object sender, EventArgs e)
        {
            txtEUID = EU_Id.Text;
            cDB.Connection();
            cDB.DeleteUtilzadores();
        }

        private void EditarUtilizadores_Load(object sender, EventArgs e)
        {
            VerUtilizadores();
        }

        private void dataGridEU_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EU_Id.Text = dataGridEU.SelectedRows[0].Cells[0].Value.ToString();
            EU_Nome.Text = dataGridEU.SelectedRows[0].Cells[1].Value.ToString();
            EU_Ufcd.Text = dataGridEU.SelectedRows[0].Cells[2].Value.ToString();
            EU_Turma.Text = dataGridEU.SelectedRows[0].Cells[3].Value.ToString();
            EU_Username.Text = dataGridEU.SelectedRows[0].Cells[4].Value.ToString();
            EU_Password.Text = dataGridEU.SelectedRows[0].Cells[5].Value.ToString();
            EU_Level.Text = dataGridEU.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void bt_EURefresh_Click(object sender, EventArgs e)
        {
            VerUtilizadores();
        }

        
    }
}
