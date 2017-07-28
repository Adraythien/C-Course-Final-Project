using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Final
{
    class Forma
    {
        static MySqlConnection conn = new MySqlConnection();
        static MySqlCommand cmd = new MySqlCommand();
        static MySqlCommand cmd2 = new MySqlCommand();
        static DataTable dataEU = new DataTable();
        //static Perguntas perg = new Perguntas();

        static DataTable DTEditPerg = new DataTable();
        //static List<MetroLabel> LPerguntas = new List<MetroLabel>();
        static List<MetroButton> LEditar = new List<MetroButton>();
        static List<MetroButton> LRemover = new List<MetroButton>();

        static List<int> LIDS = new List<int>();
        public static List<MetroRadioButton> radioButtons = new List<MetroRadioButton>(); // radio para mostrar Perg e Resp TODAAAS NO EDITAR TESTE
        public static List<MetroTextBox> Textboxes = new List<MetroTextBox>();
        public static List<MetroButton> btnRmv = new List<MetroButton>();
        public static List<MetroLabel> Labels = new List<MetroLabel>();
        public static List<MetroRadioButton> radioEdit = new List<MetroRadioButton>();      //RADIOBUTTONS NA PERGUNTA
        public static string NomeUser { get; set; }
        public static int idUser { get; set; }
        public static string username { get; set; }
        public static string titulo { get; set; }
        public static int numeroP { get; set; }
        public static string TurmaAluno { get; set; }
        public static int editarPerg { get; set; }
        public static int editarpergnoteste { get; set; }
        public static int idC { get; set; }

        public static void Connection()
        {
            conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            conn.Open();
            cmd.Connection = conn;

        }

        public static void Informacao()
        {
            conn.Close();
            Forma.Connection();
            cmd.Connection = conn;

            string Query = "SELECT * FROM Plataforma.users WHERE username=@username;";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conn);
            cmdDataBase.Parameters.AddWithValue("@username", username);
            MySqlDataReader myReader;

            myReader = cmdDataBase.ExecuteReader();
            while (myReader.Read())
            {
                NomeUser = myReader.GetString("Nome");
                idUser = myReader.GetInt32("id_user");
            }
            myReader.Close();
        }  //Buscar informação dos utilizadores
        public static void InformacaoAluno()
        {
            conn.Close();
            Forma.Connection();
            cmd.Connection = conn;

            string Query = "SELECT * FROM Plataforma.users WHERE username=@username;";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conn);
            cmdDataBase.Parameters.AddWithValue("@username", username);
            MySqlDataReader myReader;

            myReader = cmdDataBase.ExecuteReader();
            while (myReader.Read())
            {
                NomeUser = myReader.GetString("Nome");
                idUser = myReader.GetInt32("id_user");
                TurmaAluno = myReader.GetString("Turma");
            }
            myReader.Close();
        }  //Buscar informação do Aluno

        public static void UFCDCombo()
        {
            conn.Close();
            Forma.Connection();
            cmd.Connection = conn;
            var forma = Form.ActiveForm as Formador;
            string Query = "SELECT NomeUFCD FROM Plataforma.UFCD INNER JOIN Plataforma.ProfUFCD ON Num=ufcd WHERE idForm = @idForm; ";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conn);
            cmdDataBase.Parameters.AddWithValue("@idForm", idUser);
            MySqlDataReader myReader;

            myReader = cmdDataBase.ExecuteReader();
            while (myReader.Read())
            {
                string ufcd = myReader.GetString("NomeUFCD");
                Console.WriteLine(ufcd);
                if (forma.Visible == true)
                {
                    forma.realizarTeste1.ComboUFCD.Items.Add(ufcd);
                    forma.criarTeste1.boxUFCD.Items.Add(ufcd);
                    forma.editarPerguntas1.ComboUFCD.Items.Add(ufcd);
                    forma.dashFormador1.ComboUFCD.Items.Add(ufcd);
                }

            }
            myReader.Close();



        }   //Encher as Combobox com as ufcds do Formador

        public static void ComboboxTurma()
        {
            conn.Close();
            Forma.Connection();
            cmd.Connection = conn;
            var forma = Form.ActiveForm as Formador;
            string Query = "SELECT * FROM Plataforma.Turmas;";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conn);
            MySqlDataReader myReader;

            forma.realizarTeste1.ComboTurma.Items.Clear();
            forma.dashFormador1.ComboTurma.Items.Clear();
            myReader = cmdDataBase.ExecuteReader();
            while (myReader.Read())
            {

                string turma = myReader.GetString("Sigla");
                forma.realizarTeste1.ComboTurma.Items.Add(turma);
                forma.dashFormador1.ComboTurma.Items.Add(turma);

            }
            myReader.Close();
        }  //Encher a Combobox com as Turmas existentes

        public static void AgendarTestes()
        {
            var forma = Form.ActiveForm as Formador;
            conn.Close();
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;

            try
            {
                cmd.Parameters.Clear();
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //Servidor Mysql Ubunto
                cmd.CommandText = "INSERT INTO Plataforma.EstadoDosTestes(idTeste,Titulo,Formador,inicio,fim,duracao,datainicio,datafim,Turma,ufcd,TestesFeitos) VALUES(@idTeste,@Titulo,@Formador,@inicio,@fim,@duracao,@datainicio,@datafim,@Turma,@ufcd,@TestesFeitos);";

                cmd.Parameters.AddWithValue("@idTeste", RealizarTeste.idteste);
                cmd.Parameters.AddWithValue("@Titulo", forma.realizarTeste1.lblTIT.Text);
                cmd.Parameters.AddWithValue("@Formador", Forma.NomeUser);
                cmd.Parameters.AddWithValue("@inicio", forma.realizarTeste1.PickerInicio.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@fim", forma.realizarTeste1.PickerFim.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@datainicio", forma.realizarTeste1.DataInicio.Text);
                cmd.Parameters.AddWithValue("@datafim", forma.realizarTeste1.dataFim.Text);
                cmd.Parameters.AddWithValue("@duracao", forma.realizarTeste1.txtdura.Text);
                cmd.Parameters.AddWithValue("@Turma", forma.realizarTeste1.ComboTurma.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ufcd", forma.realizarTeste1.ComboUFCD.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@TestesFeitos", 0);
                cmd.ExecuteNonQuery();

                cmd.CommandType = CommandType.Text;
                transaction.Commit();
                cmd.Parameters.Clear();
                MessageBox.Show("Registo efectuado com sucesso!");

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }
        }   //Agendar os testes, mandando a informaçao para a DB.

        public static void MostrarTestePR(Formador edit)
        {
            try
            {
                if (edit.editarTeste1.metroPanel1.Controls.Count> 0)
                {

                    for (int ix = edit.editarTeste1.metroPanel1.Controls.Count-1; ix >= 0; ix--)
                    {

                        edit.editarTeste1.metroPanel1.Controls[ix].Dispose();

                    }

                }
                edit.editarTeste1.metroPanel1.Refresh();
                dataEU.Clear();
                conn.Close();
                conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
                conn.Open();
                cmd.Connection = conn;
                titulo = CriarTeste.IDTESTE;
                edit.editarTeste1.lblTitulo.Text = titulo;
                string Query = "SELECT * FROM Plataforma.TestPerguntas WHERE Teste=@titulo AND idResposta=0;";
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conn);
                MySqlDataReader myReader;
                cmdDataBase.Parameters.AddWithValue("@titulo", titulo);
                myReader = cmdDataBase.ExecuteReader();

                Labels.Clear();
                radioButtons.Clear();
                LEditar.Clear();
                LRemover.Clear();
                radioButtons.Clear();
                LIDS.Clear();


                int i = 1;
                int index = 0;
                int numeroR = 0;
                while (myReader.Read())
                {
                    int idConjunto = myReader.GetInt32("IDConjunto");
                    LIDS.Add(idConjunto);

                    string perg = myReader.GetString("Descricao");          // Vai buscar a pergunta
                    Labels.Add(new MetroLabel());
                    Labels[Labels.Count - 1].Text = perg;
                    Labels[Labels.Count - 1].Width = 300;
                    Labels[Labels.Count - 1].Height = 15;

                    LEditar.Add(new MetroButton());
                    LRemover.Add(new MetroButton());
                    LEditar[LEditar.Count - 1].Text = "Editar";
                    LEditar[LEditar.Count - 1].Width = 80;
                    LEditar[LEditar.Count - 1].Height = 20;
                    LRemover[LRemover.Count - 1].Text = "Remover";
                    LRemover[LRemover.Count - 1].Width = 80;
                    LRemover[LRemover.Count - 1].Height = 20;

                    LEditar[LEditar.Count - 1].Click += new EventHandler(EditPerg);
                    LRemover[LRemover.Count - 1].Click += new EventHandler(RemoverPergunta);
                    if (radioButtons.Count == 0)
                    {
                        Labels[Labels.Count - 1].Location = new System.Drawing.Point(100, 40);
                        LEditar[LEditar.Count - 1].Location = new System.Drawing.Point(Labels[Labels.Count - 1].Location.X + Labels[Labels.Count - 1].Width + 50, Labels[Labels.Count - 1].Location.Y);
                        LRemover[LRemover.Count - 1].Location = new System.Drawing.Point(LEditar[LEditar.Count - 1].Location.X + 100, LEditar[LEditar.Count - 1].Location.Y);

                    }
                    else
                    {
                        Labels[Labels.Count - 1].Location = new System.Drawing.Point(Labels[Labels.Count - 2].Location.X, radioButtons[radioButtons.Count - 1].Location.Y + 25);
                        LEditar[LEditar.Count - 1].Location = new System.Drawing.Point(Labels[Labels.Count - 1].Location.X + Labels[Labels.Count - 1].Width + 50, Labels[Labels.Count - 1].Location.Y);
                        LRemover[LRemover.Count - 1].Location = new System.Drawing.Point(LEditar[LEditar.Count - 1].Location.X + 100, LEditar[LEditar.Count - 1].Location.Y);

                    }
                    edit.editarTeste1.metroPanel1.Controls.Add(Labels[Labels.Count - 1]);
                    edit.editarTeste1.metroPanel1.Controls.Add(LEditar[LEditar.Count - 1]);
                    edit.editarTeste1.metroPanel1.Controls.Add(LRemover[LRemover.Count - 1]);

                    dataEU.Clear();
                    numeroR = 0;
                    while (numeroR == 0)
                    {
                        string conn = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
                        string Query1 = "SELECT * FROM Plataforma.TestPerguntas WHERE Teste=@IDTESTE AND idResposta !=0  AND idPergunta=@idPergunta;";
                        MySqlConnection conDatabase = new MySqlConnection(conn);
                        MySqlCommand cmdDatabase = new MySqlCommand(Query1, conDatabase);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmdDatabase);
                        cmdDatabase.Parameters.AddWithValue("@IDTESTE", CriarTeste.IDTESTE);
                        cmdDatabase.Parameters.AddWithValue("@idPergunta", i);
                        da.Fill(dataEU);
                        numeroR = (dataEU.Rows.Count);
                        index = 0;
                        i++;
                    }

                    foreach (DataRow row in dataEU.Rows)
                    {


                        string resp = row["Descricao"].ToString();          //Vai buscar a resposta
                        radioButtons.Add(new MetroRadioButton());
                        radioButtons[radioButtons.Count - 1].Text = resp;
                        radioButtons[radioButtons.Count - 1].Width = 250;
                        radioButtons[radioButtons.Count - 1].Height = 15;
                        radioButtons[radioButtons.Count - 1].Enabled = false;

                        if (index == 0)
                        {
                            radioButtons[radioButtons.Count - 1].Location = new System.Drawing.Point(Labels[Labels.Count - 1].Location.X + 25, Labels[Labels.Count - 1].Location.Y + 20);
                            index++;
                        }
                        else
                        {
                            radioButtons[radioButtons.Count - 1].Location = new System.Drawing.Point(radioButtons[radioButtons.Count - 2].Location.X, radioButtons[radioButtons.Count - 2].Location.Y + 20);
                            index++;
                        }

                        edit.editarTeste1.metroPanel1.Controls.Add(radioButtons[radioButtons.Count - 1]);


                    }
                    // i++;

                }
                myReader.Close();
                MetroButton addp = new MetroButton();


                addp.Height = 30;
                addp.Width = 463;
                addp.Text = "Criar Pergunta";
                addp.Click += new EventHandler(EditarTeste.ADDP_Click);
                if (radioButtons.Count == 0)
                {
                    addp.Location = new System.Drawing.Point(((edit.editarTeste1.metroPanel1.Width) / 2) - (addp.Width / 2), 50);
                    edit.editarTeste1.metroPanel1.Controls.Add(addp);

                }
                else
                {
                    addp.Location = new System.Drawing.Point(((edit.editarTeste1.metroPanel1.Width) / 2) - (addp.Width / 2), radioButtons[radioButtons.Count - 1].Location.Y + 35);
                    edit.editarTeste1.metroPanel1.Controls.Add(addp);
                }


                edit.editarTeste1.metroPanel1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Contacte o Suporte");
                conn.Close();
            }

            conn.Close();
        }   //Mostrar as Perguntas e Respostas quando se clica em Editar Teste
        


        public static void EditPerg(object sender, EventArgs e)
        {
            editarpergnoteste = 1;
            var button = sender as MetroButton;
            var index = LEditar.IndexOf(button);
            idC = LIDS[index];

            Textboxes.Clear();
            btnRmv.Clear();
            radioEdit.Clear();
            DTEditPerg.Clear();
            try
            {
                Perguntas editP = new Perguntas();
                editP.Show();
                conn.Close();

                conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
                conn.Open();
                cmd.Connection = conn;


                editP.txtPergunta.Text = (Labels[index].Text);


                string Query2 = "SELECT * FROM Plataforma.TestPerguntas where IDConjunto=@IDConjunto and idResposta=0";
                MySqlCommand cmdDataBase2 = new MySqlCommand(Query2, conn);
                cmdDataBase2.Parameters.AddWithValue("@IDConjunto", LIDS[index]);
                MySqlDataReader myReader;

                myReader = cmdDataBase2.ExecuteReader();
                while (myReader.Read())
                {

                    editP.LBLNumP.Text = myReader.GetUInt32("idPergunta").ToString();
                    editP.label1.Text = myReader. GetByte("Imagem").ToString();
                }
                myReader.Close();

                string Query = "SELECT * FROM Plataforma.TestPerguntas where IDConjunto=@IDConjunto and idResposta!=0;";

                MySqlCommand cmdDataBase = new MySqlCommand(Query, conn);
                cmdDataBase.Parameters.AddWithValue("@IDConjunto", LIDS[index]);
                MySqlDataAdapter da = new MySqlDataAdapter(cmdDataBase);
                da.Fill(DTEditPerg);
                int i = 0;
                int contar = 0;



                foreach (DataRow row in DTEditPerg.Rows)
                {
                    if (contar < 10)
                    {
                        i++;
                        if (int.Parse(row["Cotacao"].ToString()) > 0)
                        {
                            editP.txtCotacao.Text = row["Cotacao"].ToString();
                        }


                        radioEdit.Add(new MetroRadioButton());
                        btnRmv.Add(new MetroButton());
                        Textboxes.Add(new MetroTextBox());
                        Textboxes[Textboxes.Count - 1].Text = row["Descricao"].ToString();
                        Textboxes[Textboxes.Count - 1].Height = 20;
                        Textboxes[Textboxes.Count - 1].Width = 580;

                        btnRmv[btnRmv.Count - 1].Height = 20;
                        btnRmv[btnRmv.Count - 1].Width = 60;
                        btnRmv[btnRmv.Count - 1].Text = "Apagar";
                        btnRmv[btnRmv.Count - 1].Click += new EventHandler(RemoverResposta); //RemoverResposta;

                        if (contar == 0)
                        {
                            Textboxes[Textboxes.Count - 1].Location = new System.Drawing.Point(editP.txtPergunta.Location.X - 25, editP.txtPergunta.Location.Y + editP.txtPergunta.Height + (Textboxes.Count - 1) * 25);
                            editP.BtnAdd.Location = new System.Drawing.Point(editP.BtnAdd.Location.X, Textboxes[Textboxes.Count - 1].Location.Y + 25);
                            radioEdit[radioEdit.Count - 1].Location = new System.Drawing.Point(Textboxes[Textboxes.Count - 1].Location.X - 20, Textboxes[Textboxes.Count - 1].Location.Y);  // Configurar a localização
                            btnRmv[btnRmv.Count - 1].Location = new System.Drawing.Point(Textboxes[Textboxes.Count - 1].Location.X + Textboxes[Textboxes.Count - 1].Width + 20, Textboxes[Textboxes.Count - 1].Location.Y);
                            radioEdit[radioEdit.Count - 1].CheckedChanged += new EventHandler(Perguntas.Mudou);
                        }
                        else
                        {
                            Textboxes[Textboxes.Count - 1].Location = new System.Drawing.Point(Textboxes[Textboxes.Count - 2].Location.X, Textboxes[Textboxes.Count - 2].Location.Y + 25);
                            editP.BtnAdd.Location = new System.Drawing.Point(editP.BtnAdd.Location.X, Textboxes[Textboxes.Count - 1].Location.Y + 25);
                            radioEdit[radioEdit.Count - 1].Location = new System.Drawing.Point(Textboxes[Textboxes.Count - 1].Location.X - 20, Textboxes[Textboxes.Count - 1].Location.Y);  // Configurar a localização
                            btnRmv[btnRmv.Count - 1].Location = new System.Drawing.Point(Textboxes[Textboxes.Count - 1].Location.X + Textboxes[Textboxes.Count - 1].Width + 20, Textboxes[Textboxes.Count - 1].Location.Y);
                            radioEdit[radioEdit.Count - 1].CheckedChanged += new EventHandler(Perguntas.Mudou);
                        }

                        editarPerg = 1;
                        contar++;
                    }
                    else
                    {
                        editP.BtnAdd.Enabled = false;
                    }

                    editP.PanelCentro.Controls.Add(Textboxes[Textboxes.Count - 1]);
                    editP.PanelCentro.Controls.Add(btnRmv[btnRmv.Count - 1]);
                    editP.PanelCentro.Controls.Add(radioEdit[radioEdit.Count - 1]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            finally
            {
                //MostrarTestes();
                conn.Close();
                editarPerg = 0;

            }

        }  //Editar Perguntas no Teste


        public static void RemoverPergunta(object sender, EventArgs e)
        {
            //FUNCIONA
            conn.Close();
            conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            conn.Open();
            cmd.Connection = conn;

            var button = sender as MetroFramework.Controls.MetroButton;
            var index = LRemover.IndexOf(button);

            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;
            try
            {
                cmd.CommandText = "DELETE FROM Plataforma.TestPerguntas where IDConjunto=@IDConjunto;";
                cmd.Parameters.AddWithValue("@IDConjunto", LIDS[index]);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                transaction.Commit();

            }
            catch (MySqlException ex)
            {
                transaction.Rollback();
            }
            finally
            {
                var forma = Form.ActiveForm as Formador;
                Forma.MostrarTestePR(forma);
                conn.Close();
            }
        }  //Eliminar Perguntas do Teste

        public static void AdicioncarRespostanoEdit(object sender, EventArgs e)
        {

            var forma = Form.ActiveForm as Perguntas;
            int x = radioEdit.Count;
            if (Textboxes.Count < 10)
            {
                radioEdit.Add(new MetroRadioButton());
                btnRmv.Add(new MetroButton());
                Textboxes.Add(new MetroTextBox());


                Textboxes[Textboxes.Count - 1].Height = 20;
                Textboxes[Textboxes.Count - 1].Width = 580;
                Textboxes[Textboxes.Count - 1].Location = new System.Drawing.Point(forma.txtPergunta.Location.X - 25, forma.txtPergunta.Location.Y + forma.txtPergunta.Height + (Textboxes.Count - 1) * 25);

                radioEdit[radioEdit.Count - 1].Location = new System.Drawing.Point(Textboxes[Textboxes.Count - 1].Location.X - 20, Textboxes[Textboxes.Count - 1].Location.Y);  // Configurar a localização
                radioEdit[radioEdit.Count - 1].CheckedChanged += new EventHandler(Perguntas.Mudou);
                btnRmv[btnRmv.Count - 1].Height = 20;
                btnRmv[btnRmv.Count - 1].Width = 60;
                btnRmv[btnRmv.Count - 1].Text = "Apagar";
                btnRmv[btnRmv.Count - 1].Location = new System.Drawing.Point(Textboxes[btnRmv.Count - 1].Location.X + Textboxes[btnRmv.Count - 1].Width + 20, Textboxes[btnRmv.Count - 1].Location.Y);
                btnRmv[btnRmv.Count - 1].Click += new EventHandler(RemoverResposta); //RemoverResposta;

                forma.BtnAdd.Location = new System.Drawing.Point(forma.BtnAdd.Location.X, Textboxes[Textboxes.Count - 1].Location.Y + 25);
                forma.PanelCentro.Controls.Add(Textboxes[Textboxes.Count - 1]);
                forma.PanelCentro.Controls.Add(radioEdit[radioEdit.Count - 1]);
                forma.PanelCentro.Controls.Add(btnRmv[btnRmv.Count - 1]);

                forma.PanelCentro.Refresh();
            }
            if (Textboxes.Count == 10)
            {
                forma.BtnAdd.Visible = false;
            }





        }     //Metodo para aparecer mais respostas para  apergunta


        public static void RemoverResposta(object sender, EventArgs e)
        {
            var forma = Form.ActiveForm as Perguntas;
            var button = sender as MetroFramework.Controls.MetroButton;
            var index = btnRmv.IndexOf(button);

            Console.WriteLine("remove resposta " + index);
            int i;
            for (i = index; i < Textboxes.Count - 1; i++)
            {
                Textboxes[i].Text = Textboxes[i + 1].Text;

            }

            forma.PanelCentro.Controls.Remove(btnRmv[btnRmv.Count - 1]);
            forma.PanelCentro.Controls.Remove(Textboxes[Textboxes.Count - 1]);
            forma.PanelCentro.Controls.Remove(radioEdit[radioEdit.Count - 1]);
            forma.PanelCentro.Refresh();

            Textboxes.RemoveAt(Textboxes.Count - 1);
            btnRmv.RemoveAt(btnRmv.Count - 1);
            radioEdit.RemoveAt(radioEdit.Count - 1);

            if (Textboxes.Count == 0)
            {
                forma.BtnAdd.Location = new Point(forma.BtnAdd.Location.X, forma.txtPergunta.Location.Y + forma.txtPergunta.Height + 25);
            }
            else
            {
                forma.BtnAdd.Location = new Point(forma.BtnAdd.Location.X, Textboxes[i - 1].Location.Y + 25);
            }
            forma.BtnAdd.Visible = true;
            forma.PanelCentro.Refresh();
        }       //Remover Respostas da pergunta


        public static void AdicionarPerguntasEditar(object sender, EventArgs e)
        {
            int parsedValue;
            var forma = Form.ActiveForm as Perguntas;
            if (forma.txtPergunta.Text == "")
            {
                MessageBox.Show("Insira uma Pergunta.");
            }
            else if (forma.txtCotacao.Text == "" || (!int.TryParse(forma.txtCotacao.Text, out parsedValue)) || (int.Parse(forma.txtCotacao.Text) <= 0))
            {
                MessageBox.Show("Insira uma cotação válida");
                return;
            }
            else if (radioButtons.Count < 2)
            {
                MessageBox.Show("Insira pelo menos 2(duas) respostas.");
            }
            else if (Perguntas.selecionou == 0)
            {
                MessageBox.Show("Selecione uma resposta correcta");
            }
            else
            {
                DataTable Conjunto = new DataTable();
                conn.Close();
                conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
                conn.Open();
                cmd.Connection = conn;


                MySqlTransaction transaction = conn.BeginTransaction();
                cmd.Transaction = transaction;
                DataTable NUMP = new DataTable();
                try
                {
                    cmd.CommandText = " DELETE FROM Plataforma.TestPerguntas where IDConjunto=@IDConjunto AND Teste=@Titulo;";
                    cmd.Parameters.AddWithValue("@IDConjunto", idC);
                    cmd.Parameters.AddWithValue("@Titulo", titulo);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    transaction.Commit();
                    conn.Close();
                    conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
                    conn.Open();
                    cmd.Connection = conn;

                    transaction = conn.BeginTransaction();

                    string Query = "SELECT MAX(IDConjunto) FROM Plataforma.TestPerguntas;";
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conn);
                    MySqlDataReader myReader;
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdDataBase);
                    da.Fill(NUMP);
                    cmdDataBase.Parameters.AddWithValue("@idForm", Forma.idUser);
                    myReader = cmdDataBase.ExecuteReader();
                    myReader.Close();
                    string der = NUMP.Rows[0][0].ToString();
                    if (der == null || der == string.Empty)
                    {
                        idC = 1;
                    }
                    else
                    {
                        idC = (Int32.Parse(NUMP.Rows[0][0].ToString())) + 1;
                    }

                    
                    cmd.Parameters.AddWithValue("@Teste", CriarTeste.IDTESTE.ToString());
                    cmd.Parameters.AddWithValue("@idPergunta", forma.LBLNumP.Text);
                    cmd.Parameters.AddWithValue("@idResposta", 0);
                    cmd.Parameters.AddWithValue("@Descricao", forma.txtPergunta.Text);
                    cmd.Parameters.AddWithValue("@ufcd", forma.comboufcd.SelectedItem);
                    cmd.Parameters.AddWithValue("@IDConjunto", idC);
                    if (Perguntas.im == 1)
                    {
                        cmd.Parameters.Add("@img", MySqlDbType.Blob);
                        cmd.Parameters["@img"].Value = Perguntas.img;
                    }
                    else
                    {
                        cmd.Parameters.Add("@img", MySqlDbType.Blob);
                        cmd.Parameters["@img"].Value = null;
                    }
                    cmd.CommandText = "INSERT INTO Plataforma.TestPerguntas(Teste,idPergunta,idResposta,Descricao,ufcd,IDConjunto,Imagem) VALUES(@Teste,@idPergunta,@idResposta,@Descricao,@ufcd,@IDConjunto,@img);";

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();

                    int value = 0;

                    for (int i = 1; i <= Textboxes.Count; i++)
                    {

                        cmd.Parameters.AddWithValue("@Teste", CriarTeste.IDTESTE.ToString());
                        cmd.Parameters.AddWithValue("@idPergunta", forma.LBLNumP.Text);
                        cmd.Parameters.AddWithValue("@idResposta", i);
                        cmd.Parameters.AddWithValue("@Descricao", Textboxes[i - 1].Text);
                        cmd.Parameters.AddWithValue("@IDConjunto", idC);
                        bool isChecked = radioEdit[i - 1].Checked;
                        if (isChecked == true)
                        {
                            value = i;
                            cmd.Parameters.AddWithValue("@value", i);
                            cmd.Parameters.AddWithValue("@cotacao", forma.txtCotacao.Text);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@value", i);
                            cmd.Parameters.AddWithValue("@cotacao", 0);

                        }


                        cmd.CommandText = "INSERT INTO Plataforma.TestPerguntas(Teste,idPergunta,idResposta,Descricao,IDConjunto,cotacao) VALUES(@Teste,@idPergunta,@idResposta,@Descricao,@IDConjunto,@cotacao);";

                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    cmd.Parameters.Clear();
                    MessageBox.Show("Sucesso!");
                    editarpergnoteste = 0;
                    forma.Close();

                }
            }

        }  //Adicionar Perguntas após Editar

    }

}
