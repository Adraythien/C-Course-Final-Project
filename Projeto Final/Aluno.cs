using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class Aluno : MetroFramework.Forms.MetroForm
    {

        public Aluno()
        {
            InitializeComponent();
        }
        
        
        private void Aluno_Load(object sender, EventArgs e)
        {
            fazerTeste1.Visible = false;
            alunoVerNotas1.Visible = true;
            alterPass1.Visible = false;
            Forma.InformacaoAluno();
            lblBemVindo.Text = "Bem vindo, " + Forma.NomeUser;

        }

        private void Aluno_Shown(object sender, EventArgs e)
        {
            LerUFCDSComboBox();
        }
        
        private void metroTile1_Click_2(object sender, EventArgs e)
        {
            alunoVerNotas1.Visible = true;
            fazerTeste1.Visible = false;
            alterPass1.Visible = false;
        }

        private void FazerTeste_Click(object sender, EventArgs e)
        {
            alunoVerNotas1.Visible = false;
            fazerTeste1.Visible = true;
            alterPass1.Visible = false;
        }

        private void TileNotas_Click_1(object sender, EventArgs e)
        {
            alunoVerNotas1.Visible = true;
            fazerTeste1.Visible = false;
            alterPass1.Visible = false;
            LerUFCDSComboBox();
        }

        private void OpcoesAluno_Click_1(object sender, EventArgs e)
        {
            fazerTeste1.Visible = false;
            alunoVerNotas1.Visible = false;
            alterPass1.Visible = true;
        }


        public void LerUFCDSComboBox()
        {
            var form3 = Aluno.ActiveForm as Aluno;
            DataTable dataNotas = new DataTable();
            dataNotas.Clear();
            string conn = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            string Query = "SELECT id_Teste AS Teste ,Cotacao,id_ufcd AS UFCD FROM Plataforma.RegistaNotas WHERE id_Aluno=@id_user;";
            MySqlConnection conDatabase = new MySqlConnection(conn);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            cmdDatabase.Parameters.AddWithValue("@id_user", Forma.idUser);
            MySqlDataAdapter da = new MySqlDataAdapter(cmdDatabase);
            dataNotas.Clear();
            da.Fill(dataNotas);
            alunoVerNotas1.dataGridNotas.DataSource = dataNotas;

        }

        private void Aluno_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
