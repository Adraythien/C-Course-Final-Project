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
    public partial class AddAluno :MetroFramework.Controls.MetroUserControl
    {
        ConnectDB cDB = new ConnectDB();

        public static string txtANome = string.Empty;
        public static string cbATurma = string.Empty;
        public static string txtAUsername = string.Empty;
        public static string txtAPassword = string.Empty;
        public static string txtAAcesso = string.Empty;

        public AddAluno()
        {
            InitializeComponent();
           
           
        }
       //Mostrar as Turmas existentes na base de dados
        public void ShowTurma()
        {
            string conn= "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            string Query= "SELECT * FROM Plataforma.Turmas";
            MySqlConnection conDatabase = new MySqlConnection(conn);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader ler;

            try
            {
                conDatabase.Open();
                ler = cmdDatabase.ExecuteReader();

                //Faz refresh a cb_ATurma sem repetir dados ja inseridos
                if (cb_ATurma.Items.Count > 0)                
                    cb_ATurma.Items.Clear();
                
              

                    while (ler.Read())
                    {  // Procura na segunda coluna da tabela Turmas
                        cb_ATurma.Items.Add(ler[1].ToString());
                    
                    }
                

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_ARegista_Click(object sender, EventArgs e)
        {
            txtANome = txt_ANome.Text;
            cbATurma = cb_ATurma.Text;
            txtAUsername = txt_AUsername.Text;
            txtAPassword = txt_APassword.Text;
            txtAAcesso = txt_AAcesso.Text;

            cDB.Connection();
            cDB.RegistoAluno();
        }

       
    }
}
