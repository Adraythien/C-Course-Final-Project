using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class AlterPass : MetroFramework.Controls.MetroUserControl
    {
        ConnectDB cDB = new ConnectDB();
       
        public static string txtALTERUser = string.Empty;
        public static string txtALTERPassAntiga = string.Empty;
        public static string txtALTERPassNova1 = string.Empty;
       

        public AlterPass()
        {
            InitializeComponent();
           
        }

        private void bt_EUFCDUpdate_Click(object sender, EventArgs e)
        {
            txtALTERUser = ConnectDB.ut;
            txtALTERPassAntiga = ConnectDB.up;
           
            txtALTERPassNova1 = txt_ALTERPassNova1.Text;            
            cDB.Connection();
            cDB.AlterPassword();
        }

        private void AlterPass_Load(object sender, EventArgs e)
        {
            txt_ALTERPassAntiga.Text = txtALTERPassAntiga.ToString();
        }

        private void txt_ALTERPassNova1_Enter(object sender, EventArgs e)
        {
            if(txt_ALTERPassNova1.Text =="Password Nova")
            {
                txt_ALTERPassNova1.Text = "";
            }
        }

        private void txt_ALTERPassNova1_Leave(object sender, EventArgs e)
        {
            if (txt_ALTERPassNova1.Text == "")
            {
                txt_ALTERPassNova1.Text = "Password Nova";
            }
        }
    }
}
