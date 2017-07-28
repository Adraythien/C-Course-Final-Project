using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_Final
{
    
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        ConnectDB cDB = new ConnectDB();

        public static string txtU = string.Empty;
        public static string txtP = string.Empty;

        public Form1()
        {
           
            InitializeComponent();
            
           
        }
        

       

       

        private void Form1_Load(object sender, EventArgs e)
        {
            //Focus form (txtUsername)
            this.BringToFront();
            this.Activate();
            txtUsername.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin.PerformClick();
                
                    
            }
        }
        
        private void btLogin_Click(object sender, EventArgs e)
        {
            txtU = txtUsername.Text;
            txtP = txtPassword.Text;

            cDB.Connection();
            cDB.Login();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
