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
    public partial class AddTurma : MetroFramework.Controls.MetroUserControl
    {
        ConnectDB cDB = new ConnectDB();

        public static string txtTNome = string.Empty;
        public static string txtTSigla = string.Empty;

        public AddTurma()
        {
            InitializeComponent();
        }

        private void bt_TInserir_Click(object sender, EventArgs e)
        {
            txtTNome = txt_TNome.Text;
            txtTSigla = txt_TSigla.Text;

            cDB.Connection();
            cDB.RegistoTurma();
        }
    }
}
