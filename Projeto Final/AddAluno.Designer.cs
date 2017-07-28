namespace Projeto_Final
{
    partial class AddAluno
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_APassword = new MetroFramework.Controls.MetroTextBox();
            this.bt_ARegista = new MetroFramework.Controls.MetroButton();
            this.txt_ANome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_AAcesso = new MetroFramework.Controls.MetroTextBox();
            this.txt_AUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cb_ATurma = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(33, 217);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 20);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Acesso:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 162);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 20);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Password:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 20);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Turma:";
            // 
            // txt_APassword
            // 
            this.txt_APassword.Location = new System.Drawing.Point(138, 162);
            this.txt_APassword.Name = "txt_APassword";
            this.txt_APassword.Size = new System.Drawing.Size(292, 23);
            this.txt_APassword.TabIndex = 0;
            // 
            // bt_ARegista
            // 
            this.bt_ARegista.Location = new System.Drawing.Point(138, 274);
            this.bt_ARegista.Name = "bt_ARegista";
            this.bt_ARegista.Size = new System.Drawing.Size(292, 23);
            this.bt_ARegista.TabIndex = 3;
            this.bt_ARegista.Text = "Registar";
            this.bt_ARegista.Click += new System.EventHandler(this.bt_ARegista_Click);
            // 
            // txt_ANome
            // 
            this.txt_ANome.Location = new System.Drawing.Point(138, 39);
            this.txt_ANome.Name = "txt_ANome";
            this.txt_ANome.Size = new System.Drawing.Size(292, 23);
            this.txt_ANome.TabIndex = 8;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(31, 42);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 20);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Nome:";
            // 
            // txt_AAcesso
            // 
            this.txt_AAcesso.Enabled = false;
            this.txt_AAcesso.Location = new System.Drawing.Point(138, 214);
            this.txt_AAcesso.Name = "txt_AAcesso";
            this.txt_AAcesso.Size = new System.Drawing.Size(292, 23);
            this.txt_AAcesso.TabIndex = 10;
            this.txt_AAcesso.Text = "Aluno";
            // 
            // txt_AUsername
            // 
            this.txt_AUsername.Location = new System.Drawing.Point(138, 120);
            this.txt_AUsername.Name = "txt_AUsername";
            this.txt_AUsername.Size = new System.Drawing.Size(292, 23);
            this.txt_AUsername.TabIndex = 11;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(33, 120);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 20);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Username:";
            // 
            // cb_ATurma
            // 
            this.cb_ATurma.FormattingEnabled = true;
            this.cb_ATurma.ItemHeight = 24;
            this.cb_ATurma.Location = new System.Drawing.Point(138, 76);
            this.cb_ATurma.Name = "cb_ATurma";
            this.cb_ATurma.Size = new System.Drawing.Size(292, 30);
            this.cb_ATurma.TabIndex = 13;
            // 
            // AddAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_ATurma);
            this.Controls.Add(this.txt_AUsername);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txt_AAcesso);
            this.Controls.Add(this.txt_ANome);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_APassword);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.bt_ARegista);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddAluno";
            this.Size = new System.Drawing.Size(589, 404);
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_APassword;
        private MetroFramework.Controls.MetroButton bt_ARegista;
        private MetroFramework.Controls.MetroTextBox txt_ANome;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_AAcesso;
        private MetroFramework.Controls.MetroTextBox txt_AUsername;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cb_ATurma;
    }
}
