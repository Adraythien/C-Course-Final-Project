using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Projeto_Final
{
    class ConnectDB
    {


        private MySqlConnection conn = new MySqlConnection();
        private MySqlConnection conn2 = new MySqlConnection();
        private MySqlConnection conn3 = new MySqlConnection();

        private MySqlCommand cmd = new MySqlCommand();
        private MySqlCommand cmd2 = new MySqlCommand();
        private MySqlCommand cmd3 = new MySqlCommand();

        public string utilizador { get; set; }

        //Get Editar Utilizadores
        string getxtEUID = string.Empty;
        string getxtEUNome = string.Empty;
        string getxtEUUfcd = string.Empty;
        string getxtEUTurma = string.Empty;
        string getxtEUUsername = string.Empty;
        string getxtEUPassword = string.Empty;
        string getxtEULevel = string.Empty;

        //Get Alter Password
        string getxtALTERUser = string.Empty;
        string getxtALTERPassAntiga = up;
        string getxtALTERPassNova1 = string.Empty;

        //Login
        string getxtU = string.Empty;
        string getxtP = string.Empty;


        public void Connection()
        {
            //Root
            //conn.ConnectionString = "datasource=localhost;port=3306;username=root;password=";

            //Servidor Mysql Ubunto
            conn.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            conn2.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            conn3.ConnectionString = "datasource=192.168.1.99;port=3306;username=cinel;password=cinel123";
            conn.Open();
            conn2.Open();
            conn3.Open();
            cmd.Connection = conn;
            cmd2.Connection = conn2;
            cmd3.Connection = conn3;

        }

        public void RegistoAluno()
        {
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;

            try
            {
                //Root
                // cmd.CommandText = "INSERT INTO plataforma.users(nome,turma,username,password,level) VALUES(@username,@password,@level)";

                //Servidor Mysql Ubunto
                cmd.CommandText = "INSERT INTO Plataforma.users(Nome,Turma,username,password,level) VALUES(@Nome,@Turma,@username,@password,@level)";
                cmd.Parameters.AddWithValue("@Nome", AddAluno.txtANome);
                cmd.Parameters.AddWithValue("@Turma", AddAluno.cbATurma);
                cmd.Parameters.AddWithValue("@username", AddAluno.txtAUsername);
                cmd.Parameters.AddWithValue("@password", AddAluno.txtAPassword);
                cmd.Parameters.AddWithValue("@level", AddAluno.txtAAcesso);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                MessageBox.Show("Registo efectuado com sucesso!");


                cmd.Parameters.Clear();


            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn2.Close();
                conn3.Close();
            }

        }

        public void RegistoProfessor()
        {


            MySqlTransaction transaction = conn.BeginTransaction();
            MySqlTransaction transaction2 = conn2.BeginTransaction();
            MySqlTransaction transaction3 = conn3.BeginTransaction();

            cmd.Transaction = transaction;
            cmd2.Transaction = transaction2;
            cmd3.Transaction = transaction3;


            try
            {


                //Servidor Mysql Ubunto

                cmd.CommandText = "INSERT INTO Plataforma.users(Nome,username,password,level) VALUES(@Nome,@username,@password,@level)";
                cmd.Parameters.AddWithValue("@Nome", AddProfessor.txtPNome);
                cmd.Parameters.AddWithValue("@username", AddProfessor.txtPUsername);
                cmd.Parameters.AddWithValue("@password", AddProfessor.txtPPassword);
                cmd.Parameters.AddWithValue("@level", AddProfessor.txtPAcesso);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                cmd.Parameters.Clear();


                //VAI BUSCAR ID inserido anteriormente 
                long idForm = cmd.LastInsertedId;


                for (int x = 0; x < AddProfessor.ArrayUFCD.Count; x++)
                {



                    cmd2.CommandText = "INSERT INTO Plataforma.ProfUFCD(idForm,nomeForm,ufcd) VALUES(@idForm,@nomeForm,@ufcd)";
                    cmd2.Parameters.AddWithValue("@idForm", idForm);
                    cmd2.Parameters.AddWithValue("@nomeForm", AddProfessor.txtPNome);
                    cmd2.Parameters.AddWithValue("@ufcd", AddProfessor.ArrayUFCD[x].ToString());

                    cmd2.CommandType = CommandType.Text;
                    cmd2.ExecuteNonQuery();
                    cmd2.Parameters.Clear();


                }
                //Faz a transac do ciclo 
                transaction2.Commit();

                cmd3.CommandText = "UPDATE Plataforma.users SET UFCD_U=@UFCD_U WHERE id_user=@UFCD_U";
                cmd3.Parameters.AddWithValue("@UFCD_U", idForm);

                cmd3.CommandType = CommandType.Text;
                cmd3.ExecuteNonQuery();
                transaction3.Commit();
                cmd3.Parameters.Clear();

                MessageBox.Show("Registo efectuado com sucesso!");



            }
            catch (Exception ex)
            {
                // transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn2.Close();
                conn3.Close();
            }

        }

        public void RegistoSecretaria()
        {
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;

            try
            {


                //Servidor Mysql Ubunto
                cmd.CommandText = "INSERT INTO Plataforma.users(Nome,username,password,level) VALUES(@Nome,@username,@password,@level)";
                cmd.Parameters.AddWithValue("@Nome", AddSecretaria.txtSNome);
                cmd.Parameters.AddWithValue("@username", AddSecretaria.txtSUsername);
                cmd.Parameters.AddWithValue("@password", AddSecretaria.txtSPassword);
                cmd.Parameters.AddWithValue("@level", AddSecretaria.txtSAcesso);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                cmd.Parameters.Clear();
                MessageBox.Show("Registo efectuado com sucesso!");

            }
            catch (Exception ex)
            {
                cmd.Parameters.Clear();
                transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn2.Close();
                conn3.Close();
            }

        }

        public void RegistoTurma()
        {
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;

            try
            {


                //Servidor Mysql Ubunto
                cmd.CommandText = "INSERT INTO Plataforma.Turmas(Sigla,Nome) VALUES(@Sigla,@Nome)";
                cmd.Parameters.AddWithValue("@Sigla", AddTurma.txtTSigla);
                cmd.Parameters.AddWithValue("@Nome", AddTurma.txtTNome);


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
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
                conn2.Close();
                conn3.Close();

            }

        }

        public void RegistoUFCD()
        {
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;

            try
            {


                //Servidor Mysql Ubunto
                cmd.CommandText = "INSERT INTO Plataforma.UFCD(Num,NomeUFCD) VALUES(@Num,@NomeUFCD)";
                cmd.Parameters.AddWithValue("@Num", AddUFCD.txtUNum);
                cmd.Parameters.AddWithValue("@NomeUFCD", AddUFCD.txtUNome);


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
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
                conn2.Close();
                conn3.Close();
            }

        }

        public void UpdateUtilizadores()
        {
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;
            try
            {

                cmd.CommandText = "UPDATE Plataforma.users SET Nome=@Nome,UFCD_U=@UFCD,Turma=@Turma,username=@username,password=@password,level=@level WHERE id_user=@id_user";
                cmd.Parameters.AddWithValue("@Nome", getxtEUNome = EditarUtilizadores.txtEUNome);
                if (getxtEUUfcd == "")
                {
                    cmd.Parameters.AddWithValue("@UFCD", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@UFCD", getxtEUUfcd = EditarUtilizadores.txtEUUfcd);
                }
                if (getxtEUTurma == "")
                {
                    cmd.Parameters.AddWithValue("@Turma", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Turma", getxtEUTurma = EditarUtilizadores.txtEUTurma);
                }

                cmd.Parameters.AddWithValue("@username", getxtEUUsername = EditarUtilizadores.txtEUUsername);
                cmd.Parameters.AddWithValue("@password", getxtEUPassword = EditarUtilizadores.txtEUPassword);
                cmd.Parameters.AddWithValue("@level", getxtEULevel = EditarUtilizadores.txtEUAcesso);
                cmd.Parameters.AddWithValue("@id_user", getxtEUID = EditarUtilizadores.txtEUID);



                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                cmd.Parameters.Clear();

                MessageBox.Show("UPDATE efectuado com sucesso!");



            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
                transaction.Rollback();
            }
            finally
            {
                conn.Close();
                conn2.Close();
                conn3.Close();
            }

        }

        public void DeleteUtilzadores()
        {
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;
            try
            {
                cmd.CommandText = "DELETE FROM Plataforma.users where id_user=@id_user";
                cmd.Parameters.AddWithValue("@id_user", EditarUtilizadores.txtEUID);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                cmd.Parameters.Clear();

                MessageBox.Show("DELETE efectuado com sucesso!");


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            finally
            {
                conn.Close();
                conn2.Close();
                conn3.Close();
            }

        }
        public void UpdateTurmas()
        {
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;
            try
            {

                cmd.CommandText = "UPDATE Plataforma.Turmas SET Nome=@Nome,Sigla=@Sigla WHERE idTurmas=@idTurmas";
                cmd.Parameters.AddWithValue("@Nome", EditarTurma.txtETNomeTurma);
                cmd.Parameters.AddWithValue("@idTurmas", EditarTurma.txtETID);
                cmd.Parameters.AddWithValue("@Sigla", EditarTurma.txtETSigla);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                cmd.Parameters.Clear();

                MessageBox.Show("UPDATE efectuado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
                transaction.Rollback();
            }
            finally
            {
                conn.Close();
                conn2.Close();
                conn3.Close();
            }
        }
        public void DeleteTurmas()
        {
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;
            try
            {
                cmd.CommandText = "DELETE FROM Plataforma.Turmas where idTurmas=@idTurmas";
                cmd.Parameters.AddWithValue("@idTurmas", EditarTurma.txtETID);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                transaction.Commit();

                MessageBox.Show("DELETE efectuado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            finally
            {
                conn.Close();
                conn2.Close();
                conn3.Close();
            }
        }
        public void UpdateUFCD()
        {
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;
            try
            {

                cmd.CommandText = "UPDATE Plataforma.UFCD SET Num=@Num,NomeUFCD=@NomeUFCD WHERE idUFCD=@idUFCD";
                cmd.Parameters.AddWithValue("@Num", EditarUFCD.txtEUFCDNum);
                cmd.Parameters.AddWithValue("@idUFCD", EditarUFCD.txtEUFCDID);
                cmd.Parameters.AddWithValue("@NomeUFCD", EditarUFCD.txtEUFCDNomeUFCD);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                cmd.Parameters.Clear();

                MessageBox.Show("UPDATE efectuado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
                transaction.Rollback();
            }
            finally
            {
                conn.Close();
                conn2.Close();
                conn3.Close();
            }
        }

        public void DeleteUFCD()
        {
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;
            try
            {
                cmd.CommandText = "DELETE FROM Plataforma.UFCD where idUFCD=@idUFCD";
                cmd.Parameters.AddWithValue("@idUFCD", EditarUFCD.txtEUFCDID);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                cmd.Parameters.Clear();

                MessageBox.Show("DELETE efectuado com sucesso!");


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            finally
            {
                conn.Close();
                conn2.Close();
                conn3.Close();
            }

        }

        public void AlterPassword()
        {
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;

            try
            {
                cmd.CommandText = "UPDATE Plataforma.users SET password=@password where username=@username";

                cmd.Parameters.AddWithValue("@username", ut = Form1.txtU);
                cmd.Parameters.AddWithValue("@password", getxtALTERPassNova1 = AlterPass.txtALTERPassNova1);



                if (up == getxtALTERPassNova1)
                {
                    MessageBox.Show("Password nova não pode ser igual à Passsword antiga!");
                    cmd.Parameters.Clear();
                    conn.Close();
                    conn2.Close();
                    conn3.Close();
                }
                else
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    cmd.Parameters.Clear();
                    MessageBox.Show("Password alterada com sucesso!");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
                conn.Close();
            }
            finally
            {
                conn.Close();
                conn2.Close();
                conn3.Close();
            }
        }

        public void UpdateProfUFCD()
        {
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;



            try
            {
                cmd.CommandText = "UPDATE Plataforma.ProfUFCD SET ufcd=@ufcd WHERE ufcd=@ufcdAntiga AND idForm=@idForm";
                cmd.Parameters.AddWithValue("@ufcdAntiga", EditarProfUfcd.ufcdAntiga);
                cmd.Parameters.AddWithValue("@ufcd", EditarProfUfcd.txtEPUidufcd);
                cmd.Parameters.AddWithValue("@idForm", EditarProfUfcd.txtEPUID);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                transaction.Commit();

                MessageBox.Show("UPDATE efectuado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
                transaction.Rollback();

            }
            finally
            {
                conn.Close();
                conn2.Close();
                conn3.Close();
            }
        }

        public void DeleteProfUFCD()
        {
            MySqlTransaction transaction = conn.BeginTransaction();
            cmd.Transaction = transaction;
            try
            {
                cmd.CommandText = "DELETE FROM Plataforma.ProfUFCD where ufcd=@ufcdAntiga AND idForm=@idForm";
                cmd.Parameters.AddWithValue("@idForm", EditarProfUfcd.txtEPUID);
                cmd.Parameters.AddWithValue("@ufcdAntiga", EditarProfUfcd.ufcdAntiga);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                transaction.Commit();
                cmd.Parameters.Clear();

                MessageBox.Show("DELETE efectuado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
            finally
            {
                conn.Close();
                conn2.Close();
                conn3.Close();
            }
        }

        public void KillConnection()
        {
            try
            {
                conn.Close();
                conn2.Close();
                conn3.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        public static string ut { get; set; }
        public static string up { get; set; }
        public void Login()
        {

            MySqlDataReader row;

            try
            {
                //Root
                // cmd.CommandText = "SELECT * FROM plataforma.users WHERE username=@username AND password=@password";

                //Servidor Mysql Ubunto

                cmd.CommandText = "SELECT * FROM Plataforma.users WHERE username=@username AND password=@password";
                cmd.Parameters.AddWithValue("@username", getxtU = Form1.txtU);
                cmd.Parameters.AddWithValue("@password", getxtP = Form1.txtP);



                cmd.CommandType = CommandType.Text;
                row = cmd.ExecuteReader();
                row.Read();


                if (row.HasRows)
                {
                    switch (row["level"].ToString())
                    {
                        case "Aluno":
                            //form do aluno
                            Forma.username = getxtU;
                            Forma.InformacaoAluno();
                            var form3 = Form1.ActiveForm as Form1;
                            form3.Visible = false;
                            Aluno forma = new Aluno();
                            forma.Show();

                            

                            break;
                        case "Professor":
                            utilizador = getxtU;
                            Forma.username = getxtU;
                            var form2 = Form1.ActiveForm as Form1;
                            form2.Visible = false;
                            Formador frm = new Formador();
                            frm.Show();
                            break;
                        case "Secretaria":
                            //form da Secretaria
                            Secretaria FormSecretaria = new Secretaria();
                            ut = Form1.txtU;
                            up = Form1.txtP;

                            var form = Form1.ActiveForm as Form1;
                            form.Visible = false;

                            FormSecretaria.Show();


                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Username/Password invalid!");
                    cmd.Parameters.Clear();

                    conn.Close();
                    conn2.Close();
                    conn3.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            finally
            {

            }


        }
    }
}
