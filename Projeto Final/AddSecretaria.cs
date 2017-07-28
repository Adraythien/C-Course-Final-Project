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
    public partial class AddSecretaria : MetroFramework.Controls.MetroUserControl
    {
        ConnectDB cDB = new ConnectDB();

        public static string txtSNome = string.Empty;       
        public static string txtSUsername = string.Empty;
        public static string txtSPassword = string.Empty;
        public static string txtSAcesso = string.Empty;


        public AddSecretaria()
        {
            InitializeComponent();
        }

        private void bt_SRegista_Click(object sender, EventArgs e)
        {
            txtSNome = txt_SNome.Text;
            txtSUsername = txt_SUsername.Text;
            txtSPassword = txt_SPassword.Text;
            txtSAcesso = txt_SAcesso.Text;

            cDB.Connection();
            cDB.RegistoSecretaria();

        }
    }
}
