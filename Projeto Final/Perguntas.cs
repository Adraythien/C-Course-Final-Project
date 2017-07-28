using MetroFramework.Controls;
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
    public partial class Perguntas : MetroFramework.Forms.MetroForm
    {
        CriarTeste cri = new CriarTeste();
        private MySqlConnection conn = new MySqlConnection();
        private MySqlCommand cmd = new MySqlCommand();

        public List<MetroRadioButton> radioButtons = new List<MetroRadioButton>();
        public List<MetroTextBox> Textboxes = new List<MetroTextBox>();
        public List<MetroButton> btnRmv = new List<MetroButton>();
        public static int numeroP { get; set; }
        public static int numP { get; set; }
        bool isChecked;
        public static int selecionou { get; set; }
        
        public Perguntas()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1070, 650);
        }

        public void UFCDCombo()
        {
            conn.Close();
            conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            conn.Open();
            cmd.Connection = conn;

            string Query = "SELECT NomeUFCD FROM Plataforma.UFCD INNER JOIN Plataforma.ProfUFCD ON Num=ufcd WHERE idForm = @idForm; ";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conn);
            MySqlDataReader myReader;
            cmdDataBase.Parameters.AddWithValue("@idForm", Forma.idUser);
            myReader = cmdDataBase.ExecuteReader();
            while (myReader.Read())
            {
                string sName = myReader.GetString("NomeUFCD");
                comboufcd.Items.Add(sName);
            }
            myReader.Close();


        }

        public void RemoverResposta(object sender, EventArgs e)
        {
            int i;
            var button = sender as MetroFramework.Controls.MetroButton;
            var index = btnRmv.IndexOf(button);
            Console.WriteLine("remove resposta " + index);

            for (i = index; i < Textboxes.Count - 1; i++)
            {
                Textboxes[i].Text = Textboxes[i + 1].Text;

            }

            PanelCentro.Controls.Remove(btnRmv[btnRmv.Count - 1]);
            PanelCentro.Controls.Remove(Textboxes[Textboxes.Count - 1]);
            PanelCentro.Controls.Remove(radioButtons[radioButtons.Count - 1]);
            PanelCentro.Refresh();

            Textboxes.RemoveAt(Textboxes.Count - 1);
            btnRmv.RemoveAt(btnRmv.Count - 1);
            radioButtons.RemoveAt(radioButtons.Count - 1);
            if (Textboxes.Count == 0)
            {
                BtnAdd.Location = new Point(BtnAdd.Location.X, txtPergunta.Location.Y + txtPergunta.Height + 25);
            }
            else
            {
                BtnAdd.Location = new Point(BtnAdd.Location.X, Textboxes[i - 1].Location.Y + 25);
            }
            BtnAdd.Visible = true;
            PanelCentro.Refresh();
            //MUDA O TEXTO PARA O TEXTO DA TXT SEGUINTE
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            selecionou = 0;
            if (Forma.editarpergnoteste == 1)
            {
                Forma.AdicioncarRespostanoEdit(sender, e);
            }
            else if (Forma.editarpergnoteste == 0 && Textboxes.Count < 10)
            {

                radioButtons.Add(new MetroFramework.Controls.MetroRadioButton());
                btnRmv.Add(new MetroFramework.Controls.MetroButton());
                Textboxes.Add(new MetroFramework.Controls.MetroTextBox());

                Textboxes[Textboxes.Count - 1].Height = 20;
                Textboxes[Textboxes.Count - 1].Width = 580;
                Textboxes[Textboxes.Count - 1].Anchor = (System.Windows.Forms.AnchorStyles.Top);
                Textboxes[Textboxes.Count - 1].Location = new System.Drawing.Point(txtPergunta.Location.X - 25, txtPergunta.Location.Y + txtPergunta.Height + (Textboxes.Count - 1) * 25);
                PanelCentro.Controls.Add(Textboxes[Textboxes.Count - 1]);
                BtnAdd.Location = new System.Drawing.Point(BtnAdd.Location.X, Textboxes[Textboxes.Count - 1].Location.Y + 25);
                // Adicionar a lista um RadioButton
                radioButtons[radioButtons.Count - 1].Anchor = (System.Windows.Forms.AnchorStyles.Top);
                radioButtons[radioButtons.Count - 1].Location = new System.Drawing.Point(Textboxes[Textboxes.Count - 1].Location.X - 20, Textboxes[Textboxes.Count - 1].Location.Y);  // Configurar a localização
                radioButtons[radioButtons.Count - 1].CheckedChanged += new EventHandler(Mudou);

                PanelCentro.Controls.Add(radioButtons[radioButtons.Count - 1]); // Desenha

                btnRmv[Textboxes.Count - 1].Height = 20;
                btnRmv[Textboxes.Count - 1].Width = 60;
                btnRmv[Textboxes.Count - 1].Anchor = (System.Windows.Forms.AnchorStyles.Top);
                btnRmv[Textboxes.Count - 1].Text = "Apagar";
                btnRmv[Textboxes.Count - 1].Location = new System.Drawing.Point(Textboxes[Textboxes.Count - 1].Location.X + Textboxes[Textboxes.Count - 1].Width + 20, Textboxes[Textboxes.Count - 1].Location.Y);
                btnRmv[Textboxes.Count - 1].Click += new EventHandler(this.RemoverResposta); //RemoverResposta;
                PanelCentro.Controls.Add(btnRmv[Textboxes.Count - 1]);
            }
            if (Textboxes.Count == 10)
            {
                BtnAdd.Visible = false;
            }


        }

        public static void Mudou(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton.Checked)
            {
                selecionou++;
            }
        }

        DataTable dataP = new DataTable();

        DataTable Conjunto = new DataTable();
        
        public void AdicionarPerguntasTeste()
        {
            int parsedValue = 0;
            

            if (txtPergunta.Text == "")
            {
                MessageBox.Show("Insira uma Pergunta.");
            }
            else if (txtCotacao.Text == "" || (!int.TryParse(txtCotacao.Text, out parsedValue)) || (int.Parse(txtCotacao.Text) <= 0))
            {
                MessageBox.Show("Insira uma cotação válida");
                return;
            }
            else if (radioButtons.Count < 2)
            {
                MessageBox.Show("Insira pelo menos 2(duas) respostas.");
            }

            else if (selecionou == 0)
            {
                MessageBox.Show("Selecione uma resposta correcta");
            }
            else
            {
                conn.Close();
                conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
                conn.Open();
                cmd.Connection = conn;

                MySqlTransaction transaction = conn.BeginTransaction();
                cmd.Transaction = transaction;
                int idC = 0;
                try
                {
                    conn.Close();
                    conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
                    conn.Open();
                    cmd.Connection = conn;

                    string Query = "SELECT MAX(IDConjunto) FROM Plataforma.TestPerguntas WHERE idResposta=0;";
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conn);
                    MySqlDataReader myReader;
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdDataBase);
                    da.Fill(Conjunto);
                    cmdDataBase.Parameters.AddWithValue("@idForm", Forma.idUser);
                    myReader = cmdDataBase.ExecuteReader();
                    myReader.Close();
                    string der = Conjunto.Rows[0][0].ToString();
                    if (der == null || der == string.Empty)
                    {
                        idC = 1;
                    }
                    else
                    {
                        idC = (Int32.Parse(Conjunto.Rows[0][0].ToString())) + 1;
                    }

                    numP = Perguntas.TesteOuNao();

                    //inser pergunta
                    cmd.Parameters.AddWithValue("@Teste", CriarTeste.IDTESTE.ToString());
                    cmd.Parameters.AddWithValue("@idPergunta", numP);
                    cmd.Parameters.AddWithValue("@idResposta", 0);
                    cmd.Parameters.AddWithValue("@Descricao", txtPergunta.Text);
                    cmd.Parameters.AddWithValue("@IDConjunto", idC);
                    cmd.Parameters.AddWithValue("@Imagem", idC);
                    if (im == 1)
                    {
                        cmd.Parameters.Add("@img", MySqlDbType.Blob);
                        cmd.Parameters["@img"].Value = img;
                    }
                    else
                    {
                        cmd.Parameters.Add("@img", MySqlDbType.Blob);
                        cmd.Parameters["@img"].Value = null;
                    }
                    
                    cmd.CommandText = "INSERT INTO Plataforma.TestPerguntas(Teste,idPergunta,idResposta,Descricao,IDConjunto,Imagem) VALUES(@Teste,@idPergunta,@idResposta,@Descricao,@IDConjunto,@img);";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();

                    int value = 0;
                    for (int i = 1; i <= Textboxes.Count; i++)
                    {

                        cmd.Parameters.AddWithValue("@Teste", CriarTeste.IDTESTE.ToString());
                        cmd.Parameters.AddWithValue("@idPergunta", numP);
                        cmd.Parameters.AddWithValue("@idResposta", i);
                        cmd.Parameters.AddWithValue("@Descricao", Textboxes[i - 1].Text);
                        cmd.Parameters.AddWithValue("@IDConjunto", idC);
                        isChecked = radioButtons[i - 1].Checked;
                        
                        if (isChecked == true)
                        {
                            value = i;
                            cmd.Parameters.AddWithValue("@value", i);
                            cmd.Parameters.AddWithValue("@cotacao", txtCotacao.Text);
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
                    selecionou = 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    im = 0;
                    cmd.Parameters.Clear();
                    TesteOuNao();
                    MessageBox.Show("Sucesso!");
                    this.Close();

                }
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            

            if (Forma.editarpergnoteste == 1)
            {
                Forma.AdicionarPerguntasEditar(sender, e);
            }
            else
            {
                AdicionarPerguntasTeste();
            }
            

        }

        public static int TesteOuNao()
        {
            if (CriarTeste.IDTESTE != "")
            {
                DataTable dataEU = new DataTable();
                //forma.LBLNumP.Text = EditarTeste.NUMP.ToString();
                string conn = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
                string Query = "SELECT COUNT(idPergunta) FROM Plataforma.TestPerguntas Where Teste=@IDTESTE AND idResposta=0 GROUP BY idPergunta;";
                MySqlConnection conDatabase = new MySqlConnection(conn);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
                MySqlDataAdapter da = new MySqlDataAdapter(cmdDatabase);
                cmdDatabase.Parameters.AddWithValue("@IDTESTE", CriarTeste.IDTESTE);
                da.Fill(dataEU);

                numeroP = (dataEU.Rows.Count) + 1;
                return numeroP;
            }
            return 0;

        }

        private void Perguntas_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = Form.ActiveForm as Formador;

            Form lastOpenedForm = Application.OpenForms[Application.OpenForms.Count - 1];
            form = (Formador)lastOpenedForm;
            Forma.MostrarTestePR(form);
            Forma.editarpergnoteste = 0;

        }

        private void Perguntas_Load(object sender, EventArgs e)
        {
            UFCDCombo();
        }
        public static byte[] img;
        public static int im { get; set; }
        private void AdicionarImagem_Click(object sender, EventArgs e)
        {

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "JPEG Files (*.jpeg) | *.jpeg | PNG Files(*.png) | *.png | JPG Files(*.jpg) | *.jpg";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                imagemPerg.Visible = true;
                imagemPerg.Image = Image.FromFile(opf.FileName);

                MemoryStream ms = new MemoryStream();
                label1.Text = opf.SafeFileName;
                label1.Visible = true;
                imagemPerg.Image.Save(ms, imagemPerg.Image.RawFormat);
                img = ms.ToArray();
                im = 1;
            }
            else
            {
                im = 0;
            }

            

        }
    }
}

