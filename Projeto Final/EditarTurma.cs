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
    public partial class EditarTurma : MetroFramework.Controls.MetroUserControl
    {
        ConnectDB cDB = new ConnectDB();
        public static string txtETID = string.Empty;
        public static string txtETSigla = string.Empty;
        public static string txtETNomeTurma = string.Empty;
        DataTable dataET = new DataTable();

        public EditarTurma()
        {
            InitializeComponent();
        }

        public void verTurma()
        {
            string conn = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            string Query = "SELECT * FROM Plataforma.Turmas";
            MySqlConnection conDatabase = new MySqlConnection(conn);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataAdapter da = new MySqlDataAdapter(cmdDatabase);
            dataET.Clear();
            da.Fill(dataET);
            dataGridView1.DataSource = dataET;
        }

        private void EditarTurma_Load(object sender, EventArgs e)
        {
            verTurma();
        }

        private void txt_ETId_Enter(object sender, EventArgs e)
        {
            if (txt_ETId.Text == "ID")
            {
                txt_ETId.Text = "";
            }

        }

        private void txt_ETId_Leave(object sender, EventArgs e)
        {
            if (txt_ETId.Text=="")
            {
                txt_ETId.Text = "ID";
            }

        }

        private void txt_ETSigla_Enter(object sender, EventArgs e)
        {
            if (txt_ETSigla.Text == "Sigla")
            {
                txt_ETSigla.Text = "";
            }
        }

        private void txt_ETSigla_Leave(object sender, EventArgs e)
        {
            if (txt_ETSigla.Text == "")
            {
                txt_ETSigla.Text = "Sigla";
            }
        }

        private void txt_ETNome_Enter(object sender, EventArgs e)
        {
            if(txt_ETNome.Text=="Nome Turma")
            {
                txt_ETNome.Text = "";
                    
            }

        }

        private void txt_ETNome_Leave(object sender, EventArgs e)
        {
            if (txt_ETNome.Text == "")
            {
                txt_ETNome.Text = "Nome Turma";
            }

        }

        private void bt_ETUpdate_Click(object sender, EventArgs e)
        {
            txtETID = txt_ETId.Text;
            txtETNomeTurma = txt_ETNome.Text;
            txtETSigla = txt_ETSigla.Text;
            cDB.Connection();
            cDB.UpdateTurmas();
        }

        private void bt_ETDelete_Click(object sender, EventArgs e)
        {
            txtETID = txt_ETId.Text;
            cDB.Connection();
            cDB.DeleteTurmas();
        }

        private void bt_ETRefresh_Click(object sender, EventArgs e)
        {
            verTurma();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           txt_ETId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           txt_ETSigla.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
           txt_ETNome.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            
        }
    }
}
