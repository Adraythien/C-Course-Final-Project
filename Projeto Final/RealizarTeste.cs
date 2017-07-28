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
    public partial class RealizarTeste : MetroFramework.Controls.MetroUserControl
    {
        public RealizarTeste()
        {
            InitializeComponent();
        }

        public void DateTimers()
        {
            DataInicio.Value = DateTime.Now;
            dataFim.Value = DateTime.Now;
            PickerInicio.Format = DateTimePickerFormat.Custom;
            PickerInicio.CustomFormat = "HH:mm";
            PickerInicio.ShowUpDown = true;

            PickerFim.Format = DateTimePickerFormat.Custom;
            PickerFim.CustomFormat = "HH:mm";
            PickerFim.ShowUpDown = true;

            DataInicio.Format = DateTimePickerFormat.Custom;
            dataFim.Format = DateTimePickerFormat.Custom;
            DataInicio.CustomFormat = "yyyy-MM-dd";
            dataFim.CustomFormat = "yyyy-MM-dd";

        }

        private void RealizarTeste_Load(object sender, EventArgs e)
        {
            DateTimers();

        }
        static MySqlConnection conn = new MySqlConnection();
        static MySqlCommand cmd = new MySqlCommand();

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            if (duracao <= 0 || txtdura.Text=="")
            {
                MessageBox.Show("Insira um tempo válido em minutos!");
            }
            else if (ComboTurma.SelectedItem==null)
            {
                MessageBox.Show("Escolha uma turma!");
            }
            else
            {
                Forma.AgendarTestes();
            }
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (duracao > 0)
            {
                dataFim.Value = DataInicio.Value.AddMinutes(duracao);
            }
            else
            {
                dataFim.Value = DataInicio.Value;
            }
            
        }
        double duracao = 0;
        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            DateTime currentTime = new DateTime();
            if (txtdura.Text != "" && txtdura.Text.Length <= 5)
            {
                duracao = Convert.ToDouble(txtdura.Text);
                currentTime = PickerInicio.Value;
                currentTime = currentTime.AddMinutes(duracao);
                PickerFim.Value = currentTime;
                Console.WriteLine("Nuværende tid: " + currentTime);
                dataFim.Value = DataInicio.Value.AddMinutes(duracao);
            }


        }

        private void PickerInicio_ValueChanged(object sender, EventArgs e)
        {
            double duracao = 0;
            DateTime currentTime = new DateTime();
            if (txtdura.Text != "" && txtdura.Text.Length <= 5)
            {
                duracao = Convert.ToDouble(txtdura.Text);
            }
            if (PickerInicio.Value != null)
            {
                currentTime = PickerInicio.Value;
                currentTime = currentTime.AddMinutes(duracao);
                PickerFim.Value = PickerInicio.Value.AddMinutes(duracao);
                dataFim.Value = DataInicio.Value.AddMinutes(duracao);
            }
            else
            {
                MessageBox.Show("Insira um tempo válido");
            }


        }


        List<int> idtestes = new List<int>();
        public static int idteste { get; set; }
        private void ComboUFCD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MySqlConnection conn2 = new MySqlConnection();
            comboTestes.Items.Clear();
            comboTestes.ResetText();

            ComboTurma.Items.Clear();
            ComboTurma.ResetText();

            comboTestes.Refresh();
            ComboTurma.Refresh();
            idtestes.Clear();
            if (ComboUFCD.SelectedItem != null)
            {
                var forma = Form.ActiveForm as Formador;
                Console.WriteLine("wtf");
                forma.realizarTeste1.comboTestes.Items.Clear();
                conn2.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
                conn2.Open();
                string Query = "SELECT Teste,titulo FROM Plataforma.testes INNER JOIN Plataforma.UFCD ON ufcd=Num  WHERE NomeUFCD=@ufcd;";

                //MySqlConnection conDatabase = new MySqlConnection(conn);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conn2);
                cmdDataBase.Parameters.AddWithValue("@ufcd", ComboUFCD.SelectedItem);
                MySqlDataReader myReader;
                //Forma.Connection();

                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                    string testes = myReader.GetString("titulo");
                    int id = myReader.GetInt32("Teste");
                    idtestes.Add(id);
                    Console.WriteLine("testes" + testes);
                    forma.realizarTeste1.comboTestes.Items.Add(testes);

                }
                myReader.Close();

                



                comboTestes.Enabled = true;
                Forma.ComboboxTurma();
            }
        }

        private void comboTestes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTIT.Text = comboTestes.SelectedItem.ToString();
        }

        private void comboTestes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idteste = idtestes.ElementAt(comboTestes.SelectedIndex);
            Console.WriteLine("idteste selecionado" + idteste);
            //idteste é o id do teste na base de dados
        }

        
    }
}
