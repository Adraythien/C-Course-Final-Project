using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class Responder : MetroFramework.Forms.MetroForm
    {

        List<MetroFramework.Controls.MetroRadioButton> radioButtons = new List<MetroFramework.Controls.MetroRadioButton>();
        List<MetroFramework.Controls.MetroLabel> Labels = new List<MetroFramework.Controls.MetroLabel>();
        List<GroupBox> groupboxs = new List<GroupBox>();
        List<PictureBox> imagens = new List<PictureBox>();

        TimeSpan horadoAgora = DateTime.Now.TimeOfDay;


        GroupBox gb;

        int countTimer;
        double cotacaoAluno = 0;
        double cotacaoTotal = 0;
        double cotation;
        int selecionou;
        int contadorCertas = 0;
        int contadorErradas = 0;
        static MySqlConnection conn = new MySqlConnection();
        static MySqlCommand cmd = new MySqlCommand();
        


        public Responder()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (countTimer > 0)
            {  
                countTimer--;
                lblTimer.Text = countTimer.ToString() + " Minutos";
            }

           else 
            {
                MessageBox.Show("Acabou o tempo!!");
                TerminareCorrigir();
                InserirNotas();
                this.Close();
            }
        }

        private void Responder_Load(object sender, EventArgs e)
        {
            countTimer = (int)(FazerTeste.horadeFim.TotalMinutes - horadoAgora.TotalMinutes);
            
            timer1.Interval = 60000;
            lblTimer.Text = countTimer + " Minutos";
            timer1.Start();
            TesteResponder();
            this.WindowState = FormWindowState.Maximized;
            this.Size = this.MaximumSize;
            this.Text = FazerTeste.IDTESTE;

        }

        public void TesteResponder()
        {
            try
            {
                //MetroFramework.Controls.MetroScrollBar bar = new MetroFramework.Controls.MetroScrollBar();
                DataTable dataEU = new DataTable();
                conn.Close();
                conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
                conn.Open();
                cmd.Connection = conn;
                string titulo = FazerTeste.IDTESTE;
                string Query = "SELECT * FROM Plataforma.TestPerguntas WHERE Teste=@titulo AND idResposta=0;";
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conn);
                MySqlDataReader myReader;
                cmdDataBase.Parameters.AddWithValue("@titulo", FazerTeste.IDTESTE);
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdDataBase);

                DataTable table = new DataTable();
                da2.Fill(table);
                myReader = cmdDataBase.ExecuteReader();

                int i = 1;
                int index = 0;
                int imagenss = 0;
                bool entraImg = false;
                while (myReader.Read())
                {
                    string perg = myReader.GetString("Descricao");

                    Labels.Add(new MetroFramework.Controls.MetroLabel());
                    Labels[Labels.Count - 1].Text = i + " " + perg;
                    Labels[Labels.Count - 1].Width = 200;
                    Labels[Labels.Count - 1].Height = 15;

                    if (table.Rows[imagenss][8] != DBNull.Value)
                    {
                        imagens.Add(new PictureBox());
                        byte[] img = (byte[])table.Rows[imagenss][8];

                        MemoryStream ms = new MemoryStream(img);
                        imagens[imagens.Count - 1].Image = Image.FromStream(ms);
                        imagens[imagens.Count - 1].Width = Image.FromStream(ms).Width;
                        imagens[imagens.Count - 1].Height = Image.FromStream(ms).Height;
                        Console.WriteLine("Imagame + " + imagens[imagens.Count - 1].Width);

                        if (groupboxs.Count == 0)
                        {
                            imagens[imagens.Count - 1].Location = new Point(0, 0);
                        }
                        else
                        {
                            imagens[imagens.Count - 1].Location = new Point(groupboxs[groupboxs.Count - 1].Location.X, groupboxs[groupboxs.Count - 1].Location.Y + groupboxs[groupboxs.Count - 1].Height + 20);
                        }
                        entraImg = true;
                        panel1.Controls.Add(imagens[imagens.Count - 1]);
                    }
                    gb = new GroupBox();
                    groupboxs.Add(gb);
                    gb.Size = new System.Drawing.Size(0, 0);

                    if (groupboxs.Count == 1 && entraImg == false) // Caso NAO tenha imagem e seja a primeira pergunta
                    {
                        Labels[Labels.Count - 1].Location = new System.Drawing.Point(100, 40);
                        groupboxs[groupboxs.Count - 1].Location = new System.Drawing.Point(100, 65);
                    }
                    else if (groupboxs.Count == 1 && entraImg==true)    // Caso TENHA imagem e seja a primeira pergunta
                    {
                        Labels[Labels.Count - 1].Location = new System.Drawing.Point(imagens[imagens.Count - 1].Location.X, imagens[imagens.Count - 1].Location.Y + imagens[imagens.Count - 1].Height + 10);
                        groupboxs[groupboxs.Count - 1].Location = new System.Drawing.Point(Labels[Labels.Count - 1].Location.X, Labels[Labels.Count - 1].Location.Y + 30);

                    }
                    else if (entraImg == true)  // Caso TENHA imagem
                    {

                        Labels[Labels.Count - 1].Location = new System.Drawing.Point(Labels[Labels.Count - 2].Location.X, imagens[imagens.Count - 1].Location.Y + imagens[imagens.Count - 1].Height + 10);
                        groupboxs[groupboxs.Count - 1].Location = new System.Drawing.Point(Labels[Labels.Count - 1].Location.X, Labels[Labels.Count - 1].Location.Y + 30);

                    }
                    else                    // Caso NAO TENHO imagem
                    {
                        Labels[Labels.Count - 1].Location = new System.Drawing.Point(groupboxs[groupboxs.Count - 2].Location.X, groupboxs[groupboxs.Count - 2].Height+groupboxs[groupboxs.Count - 2].Location.Y + 10);
                        groupboxs[groupboxs.Count - 1].Location = new System.Drawing.Point(Labels[Labels.Count - 1].Location.X, Labels[Labels.Count - 1].Location.Y + 30);

                    }
                    entraImg = false;


                    
                    panel1.Controls.Add(Labels[Labels.Count - 1]);
                    panel1.Controls.Add(groupboxs[groupboxs.Count - 1]);

                    dataEU.Clear();
                    string conn = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
                    string Query1 = "SELECT * FROM Plataforma.TestPerguntas WHERE Teste=@IDTESTE AND idResposta !=0  AND idPergunta=@idPergunta;";
                    MySqlConnection conDatabase = new MySqlConnection(conn);
                    MySqlCommand cmdDatabase = new MySqlCommand(Query1, conDatabase);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdDatabase);
                    cmdDatabase.Parameters.AddWithValue("@IDTESTE", FazerTeste.IDTESTE);
                    cmdDatabase.Parameters.AddWithValue("@idPergunta", i);
                    da.Fill(dataEU);
                    int numeroR = (dataEU.Rows.Count);
                    index = 0;
                    int contadordosradio = 0;
                    foreach (DataRow row in dataEU.Rows)
                    {

                        string resp = row["Descricao"].ToString();
                        gb.Name = Labels.Count.ToString();
                        radioButtons.Add(new MetroFramework.Controls.MetroRadioButton());
                        radioButtons[radioButtons.Count - 1].Name = Labels.Count.ToString();
                        radioButtons[radioButtons.Count - 1].Text = resp;
                        radioButtons[radioButtons.Count - 1].Width = 750;
                        radioButtons[radioButtons.Count - 1].Height = 15;
                        contadordosradio = contadordosradio + radioButtons[radioButtons.Count - 1].Height + 5;

                        if (index == 0)
                        {

                            radioButtons[radioButtons.Count - 1].Location = new System.Drawing.Point(10, 10);
                            index++;
                        }
                        else
                        {
                            radioButtons[radioButtons.Count - 1].Location = new System.Drawing.Point(radioButtons[radioButtons.Count - 2].Location.X, radioButtons[radioButtons.Count - 2].Location.Y + 20);

                            index++;
                        }

                        gb.Controls.Add(radioButtons[radioButtons.Count - 1]);
                        gb.Height = contadordosradio + 8;                             //8 é metade do tamanho Y de um radiobutton
                        gb.Width = 1000;
                        panel1.Controls.Add(gb);
                        panel1.Refresh();

                    }

                    i++;
                    imagenss++;
                }
                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            conn.Close();
        }//Teste Responder

        public void átoa()
        {
            for (int z=0;z< radioButtons.Count; z++)
            {
                if (radioButtons[z].Checked)
                {
                    selecionou++;
                }
            }
        }
        public void TerminareCorrigir()
        {
            DataTable dataRadio = new DataTable();
            conn.Close();
            conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            conn.Open();
            cmd.Connection = conn;
            string Query = "SELECT * FROM Plataforma.TestPerguntas WHERE Teste=@titulo AND idResposta=0 ;";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conn);
            MySqlDataReader reader;
            cmdDataBase.Parameters.AddWithValue("@titulo", FazerTeste.IDTESTE);
            int i = 1;
            int o = 0;
            reader = cmdDataBase.ExecuteReader();

            int p = 0;
            string resp = "";
            int cotacao = 0;
            List<String> ListaResp = new List<string>();
            List<int> ListaCota = new List<int>();
            while (reader.Read())
            {
                o = 0;
                ListaResp.Clear();
                ListaCota.Clear();
                string perg = reader.GetString("Descricao");
                dataRadio.Clear();
                string conn = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
                string Query1 = "SELECT * FROM Plataforma.TestPerguntas WHERE Teste=@IDTESTE AND idResposta !=0 AND idPergunta=@idPergunta";
                MySqlConnection conDatabase = new MySqlConnection(conn);
                MySqlCommand cmdDatabase = new MySqlCommand(Query1, conDatabase);
                MySqlDataAdapter da = new MySqlDataAdapter(cmdDatabase);
                cmdDatabase.Parameters.AddWithValue("@IDTESTE", FazerTeste.IDTESTE);
                cmdDatabase.Parameters.AddWithValue("@idPergunta", i);
                da.Fill(dataRadio);
                Console.WriteLine("Pergunta : " + perg);
                int numeroR = (dataRadio.Rows.Count);

                foreach (DataRow row in dataRadio.Rows)
                {
                    resp = row["Descricao"].ToString();
                    ListaResp.Add(resp);
                    cotacao = (int)row["cotacao"];
                    ListaCota.Add(cotacao);
                    cotacaoTotal += cotacao;

                }

                foreach (RadioButton rb in groupboxs[p].Controls)
                {

                    if (rb.Checked && rb.Text == ListaResp[o].ToString() && (ListaCota[o] > 0))
                    {
                        bool state = rb.Checked;
                        resp = rb.Text;
                        Console.WriteLine("Resposta selecionada foi : " + rb.Text);
                        Console.WriteLine("Resposta selecionada asdadadasd : " + ListaResp[o].ToString());
                        Console.WriteLine("Cotacao foi : " + ListaCota[o].ToString());

                        cotacaoAluno = cotacaoAluno + ListaCota[o];
                        contadorCertas++;
                    }
                    else if (rb.Checked && rb.Text == ListaResp[o].ToString() && (ListaCota[o] == 0))
                    {
                        contadorErradas++;
                    }

                    o++;
                }
                p++;
                i++;

            }
            Console.WriteLine("Cotacao do aluno : " + cotacaoAluno);
            Console.WriteLine("Certas : " + contadorCertas);
            Console.WriteLine("Erradas : " + contadorErradas);
            Console.WriteLine("Cotacao Total : " + cotacaoTotal);

        }//Terminar e Corrigir

        private void btn_Terminar_Click(object sender, EventArgs e)
        {
            if (selecionou != groupboxs.Count)
            {
                
                DialogResult dialogresult = MessageBox.Show("Tem a certeza que pretende terminar?", "Existem respostas por responder!", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    TerminareCorrigir();
                    this.Close();
                    InserirNotas();
                }
                else if (dialogresult == DialogResult.No)
                {

                }
            }
            else
            {
                TerminareCorrigir();
                this.Close();
                InserirNotas();
            }
        }


        public void InserirNotas()
        {
            cotation = (cotacaoAluno * 20) / cotacaoTotal;
            conn.Close();
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;
            try
            {
                cmd.CommandText = "INSERT INTO Plataforma.RegistaNotas(id_Teste, id_Turma, id_Aluno, id_UFCD,Nome, Cotacao) values(@id_Teste, @id_Turma, @id_Aluno, @id_UFCD,@Nome, @Cotacao );";
                cmd.Parameters.AddWithValue("@id_Teste", FazerTeste.IDTESTE);
                cmd.Parameters.AddWithValue("@id_Turma", Forma.TurmaAluno);
                cmd.Parameters.AddWithValue("@id_Aluno", Forma.idUser);
                cmd.Parameters.AddWithValue("@id_UFCD", FazerTeste.IDUFCD);
                cmd.Parameters.AddWithValue("@Nome", Forma.NomeUser);
                cmd.Parameters.AddWithValue("@Cotacao", cotation);
                cmd.ExecuteNonQuery();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "UPDATE Plataforma.EstadoDosTestes SET TestesFeitos=@TestesFeitos WHERE idTeste=@idTeste AND ufcd=@ufcd AND Turma=@id_Turma;";
                cmd.Parameters.AddWithValue("@TestesFeitos", FazerTeste.contadorTestes + 1);
                cmd.Parameters.AddWithValue("@idTeste", FazerTeste.IDdoTESTE);
                cmd.Parameters.AddWithValue("@ufcd", FazerTeste.IDUFCD);


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                cmd.Parameters.Clear();

            }
            catch (Exception ex)
            {
                cmd.Parameters.Clear();
                transaction.Rollback();
                MessageBox.Show(ex.Message);
            }

        }

    }
}






