namespace Projeto_Final
{
    partial class AddProfessor
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
            this.txt_PUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_PAcesso = new MetroFramework.Controls.MetroTextBox();
            this.txt_PNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_PPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.bt_PRegista = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lista_PUFCD = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txt_PUsername
            // 
            this.txt_PUsername.Location = new System.Drawing.Point(152, 351);
            this.txt_PUsername.Name = "txt_PUsername";
            this.txt_PUsername.Size = new System.Drawing.Size(799, 23);
            this.txt_PUsername.TabIndex = 22;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(47, 351);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 20);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Username:";
            // 
            // txt_PAcesso
            // 
            this.txt_PAcesso.Enabled = false;
            this.txt_PAcesso.Location = new System.Drawing.Point(152, 445);
            this.txt_PAcesso.Name = "txt_PAcesso";
            this.txt_PAcesso.Size = new System.Drawing.Size(799, 23);
            this.txt_PAcesso.TabIndex = 21;
            this.txt_PAcesso.Text = "Professor";
            // 
            // txt_PNome
            // 
            this.txt_PNome.Location = new System.Drawing.Point(153, 46);
            this.txt_PNome.Name = "txt_PNome";
            this.txt_PNome.Size = new System.Drawing.Size(798, 23);
            this.txt_PNome.TabIndex = 19;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(46, 49);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 20);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Nome:";
            // 
            // txt_PPassword
            // 
            this.txt_PPassword.Location = new System.Drawing.Point(152, 393);
            this.txt_PPassword.Name = "txt_PPassword";
            this.txt_PPassword.Size = new System.Drawing.Size(799, 23);
            this.txt_PPassword.TabIndex = 13;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(47, 448);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 20);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Acesso:";
            // 
            // bt_PRegista
            // 
            this.bt_PRegista.Location = new System.Drawing.Point(152, 505);
            this.bt_PRegista.Name = "bt_PRegista";
            this.bt_PRegista.Size = new System.Drawing.Size(799, 23);
            this.bt_PRegista.TabIndex = 15;
            this.bt_PRegista.Text = "Registar";
            this.bt_PRegista.Click += new System.EventHandler(this.bt_PRegista_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(46, 393);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 20);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Password:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(47, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 20);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "UFCD:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(152, 93);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(406, 225);
            this.checkedListBox1.TabIndex = 24;
            // 
            // lista_PUFCD
            // 
            this.lista_PUFCD.FormattingEnabled = true;
            this.lista_PUFCD.ItemHeight = 16;
            this.lista_PUFCD.Location = new System.Drawing.Point(564, 93);
            this.lista_PUFCD.Name = "lista_PUFCD";
            this.lista_PUFCD.Size = new System.Drawing.Size(406, 228);
            this.lista_PUFCD.TabIndex = 25;
            // 
            // AddProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lista_PUFCD);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txt_PUsername);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txt_PAcesso);
            this.Controls.Add(this.txt_PNome);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_PPassword);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.bt_PRegista);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddProfessor";
            this.Size = new System.Drawing.Size(1048, 557);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_PUsername;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_PAcesso;
        private MetroFramework.Controls.MetroTextBox txt_PNome;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_PPassword;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton bt_PRegista;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox lista_PUFCD;
    }
}
