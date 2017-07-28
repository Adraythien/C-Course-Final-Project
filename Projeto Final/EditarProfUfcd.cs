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
    public partial class EditarProfUfcd :MetroFramework.Controls.MetroUserControl
    {
        ConnectDB cDB = new ConnectDB();
        DataTable dataET = new DataTable();
        public static string txtEPUID = string.Empty;
        public static string txtEPUNome = string.Empty;
        public static string txtEPUidufcd = string.Empty;

        public static string ufcdAntiga = string.Empty;
        public static string nomeAntigo = string.Empty;
       



        public EditarProfUfcd()
        {
            InitializeComponent();
        }

        public void verProfUfcd()
        {
            string conn = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            string Query = "SELECT * FROM Plataforma.ProfUFCD";
            MySqlConnection conDatabase = new MySqlConnection(conn);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataAdapter da = new MySqlDataAdapter(cmdDatabase);
            dataET.Clear();
            da.Fill(dataET);
            dataGridView1.DataSource = dataET;
        }

        private void EditarProfUfcd_Load(object sender, EventArgs e)
        {
            verProfUfcd();
        }

        private void bt_EPUUpdate_Click(object sender, EventArgs e)
        {
            txtEPUID = txt_EPUId.Text;
            txtEPUNome = txt_EPUNomeProf.Text;
            txtEPUidufcd = txt_EPUUfcd.Text;
            cDB.Connection();
            cDB.UpdateProfUFCD();


        }

        private void bt_EPURefresh_Click(object sender, EventArgs e)
        {
            verProfUfcd();
        }

        private void bt_EPUDelete_Click(object sender, EventArgs e)
        {
            txtEPUID = txt_EPUId.Text;
            cDB.Connection();
            cDB.DeleteProfUFCD();

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_EPUId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_EPUNomeProf.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_EPUUfcd.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            ufcdAntiga = txt_EPUUfcd.Text;
            nomeAntigo = txt_EPUNomeProf.Text;
        }
    }
}
