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
    public partial class EditarUFCD : MetroFramework.Controls.MetroUserControl
    {
        ConnectDB cDB = new ConnectDB();
        public static string txtEUFCDID = string.Empty;
        public static string txtEUFCDNum = string.Empty;
        public static string txtEUFCDNomeUFCD = string.Empty;
        DataTable dataEUFCD = new DataTable();

        public EditarUFCD()
        {
            InitializeComponent();
        }
        
        public void verUFCD()
        {
            string conn = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            string Query = "SELECT * FROM Plataforma.UFCD";
            MySqlConnection conDatabase = new MySqlConnection(conn);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataAdapter da = new MySqlDataAdapter(cmdDatabase);
            dataEUFCD.Clear();
            da.Fill(dataEUFCD);
            dataGridView1.DataSource = dataEUFCD;
        }

        private void EditarUFCD_Load(object sender, EventArgs e)
        {
            verUFCD();

        }

        private void bt_EUFCDUpdate_Click(object sender, EventArgs e)
        {
            txtEUFCDID = txt_EUFCDId.Text;
            txtEUFCDNum = txt_EUFCDNum.Text;
            txtEUFCDNomeUFCD = txt_EUFCDNomeUFCD.Text;
            cDB.Connection();
            cDB.UpdateUFCD();
        }

        private void bt_EUFCDRefresh_Click(object sender, EventArgs e)
        {
            verUFCD();

        }

        private void bt_EUFCDDelete_Click(object sender, EventArgs e)
        {
            txtEUFCDID = txt_EUFCDId.Text;
            cDB.Connection();
            cDB.DeleteUFCD();

        }

        private void txt_EUFCDId_Enter(object sender, EventArgs e)
        {
            if (txt_EUFCDId.Text == "ID")
            {
                txt_EUFCDId.Text = "";
            }

        }

        private void txt_EUFCDId_Leave(object sender, EventArgs e)
        {
            if (txt_EUFCDId.Text == "")
            {
                txt_EUFCDId.Text = "ID";
            }
        }

        private void txt_EUFCDNum_Enter(object sender, EventArgs e)
        {
            if(txt_EUFCDNum.Text=="Numero UFCD")
            {
                txt_EUFCDNum.Text = "";
            }

        }

        private void txt_EUFCDNum_Leave(object sender, EventArgs e)
        {
            if (txt_EUFCDNum.Text == "")
            {
                txt_EUFCDNum.Text = "Numero UFCD";
            }

        }

        private void txt_EUFCDNomeUFCD_Enter(object sender, EventArgs e)
        {
            if(txt_EUFCDNomeUFCD.Text=="Nome UFCD")
            {
                txt_EUFCDNomeUFCD.Text = "";
            }

        }

        private void txt_EUFCDNomeUFCD_Leave(object sender, EventArgs e)
        {
            if (txt_EUFCDNomeUFCD.Text == "")
            {
                txt_EUFCDNomeUFCD.Text = "Nome UFCD";
            }

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_EUFCDId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_EUFCDNum.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_EUFCDNomeUFCD.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
