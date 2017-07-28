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
    public partial class AddUFCD : MetroFramework.Controls.MetroUserControl
    {
        ConnectDB cDB = new ConnectDB();

        public static string txtUNum = string.Empty;
        public static string txtUNome = string.Empty;

        public AddUFCD()
        {
            InitializeComponent();
        }

        private void bt_UInserir_Click(object sender, EventArgs e)
        {
            txtUNum = txt_UNum.Text;
            txtUNome = txt_UNome.Text;

            cDB.Connection();
            cDB.RegistoUFCD();
        }
    }
}
