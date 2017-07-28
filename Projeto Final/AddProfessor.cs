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
using System.Text.RegularExpressions;
using System.Collections;

namespace Projeto_Final
{
    public partial class AddProfessor : MetroFramework.Controls.MetroUserControl
    {
        ConnectDB cDB = new ConnectDB();

        public static string txtPNome = string.Empty;
        //VER
        public static StringBuilder listaPUFCD = new StringBuilder();
        public static ArrayList ArrayUFCD = new ArrayList();       
        public static string txtPUsername = string.Empty;
        public static string txtPPassword = string.Empty;
        public static string txtPAcesso = string.Empty;

        public AddProfessor()
        {
            InitializeComponent();
        }

        private void bt_PRegista_Click(object sender, EventArgs e)
        {
            txtPNome = txt_PNome.Text;            
            txtPUsername = txt_PUsername.Text;
            txtPPassword = txt_PPassword.Text;
            txtPAcesso = txt_PAcesso.Text;

            
           
            lista_PUFCD.Items.Clear();
            foreach(string s in checkedListBox1.CheckedItems)
            {
                //Vai só buscar os numeros presentes na string
                string[] numbers = Regex.Split(s, @"\D+");
                foreach(string value in numbers)
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        //VERRRRRRR

                        lista_PUFCD.Items.Add(value);
                        
                    }
                }
                
            }
            //Procura o objeto selecionado na listBox e guarda no array
            foreach (object selectedItem in lista_PUFCD.Items)
            {
                ArrayUFCD.Add(selectedItem.ToString());
            }
            cDB.Connection();

            cDB.RegistoProfessor();
        }
        //Mostra as UFCD presentes na base de dados
        public void ShowUFCD()
        {
            string conn = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            string Query = "SELECT * FROM Plataforma.UFCD";
            MySqlConnection conDatabase = new MySqlConnection(conn);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader ler;

            try
            {
                conDatabase.Open();
                ler = cmdDatabase.ExecuteReader();


                if (checkedListBox1.Items.Count > 0)
                    checkedListBox1.Items.Clear();
                
                while (ler.Read())
                {  
                    // Procura na segunda coluna da tabela Turmas
                    checkedListBox1.Items.Add(ler[1].ToString()+"-"+ler[2].ToString());
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
