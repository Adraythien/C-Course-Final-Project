namespace Projeto_Final
{
    partial class AddSecretaria
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
            this.txt_SUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txt_SAcesso = new MetroFramework.Controls.MetroTextBox();
            this.txt_SNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_SPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.bt_SRegista = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txt_SUsername
            // 
            this.txt_SUsername.Location = new System.Drawing.Point(149, 86);
            this.txt_SUsername.Name = "txt_SUsername";
            this.txt_SUsername.Size = new System.Drawing.Size(292, 23);
            this.txt_SUsername.TabIndex = 22;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(44, 86);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 20);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Username:";
            // 
            // txt_SAcesso
            // 
            this.txt_SAcesso.Enabled = false;
            this.txt_SAcesso.Location = new System.Drawing.Point(149, 180);
            this.txt_SAcesso.Name = "txt_SAcesso";
            this.txt_SAcesso.Size = new System.Drawing.Size(292, 23);
            this.txt_SAcesso.TabIndex = 21;
            this.txt_SAcesso.Text = "Secretaria";
            // 
            // txt_SNome
            // 
            this.txt_SNome.Location = new System.Drawing.Point(149, 44);
            this.txt_SNome.Name = "txt_SNome";
            this.txt_SNome.Size = new System.Drawing.Size(292, 23);
            this.txt_SNome.TabIndex = 19;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(42, 47);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 20);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Nome:";
            // 
            // txt_SPassword
            // 
            this.txt_SPassword.Location = new System.Drawing.Point(149, 128);
            this.txt_SPassword.Name = "txt_SPassword";
            this.txt_SPassword.Size = new System.Drawing.Size(292, 23);
            this.txt_SPassword.TabIndex = 13;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(44, 183);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 20);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Acesso:";
            // 
            // bt_SRegista
            // 
            this.bt_SRegista.Location = new System.Drawing.Point(149, 236);
            this.bt_SRegista.Name = "bt_SRegista";
            this.bt_SRegista.Size = new System.Drawing.Size(292, 23);
            this.bt_SRegista.TabIndex = 15;
            this.bt_SRegista.Text = "Registar";
            this.bt_SRegista.Click += new System.EventHandler(this.bt_SRegista_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(43, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 20);
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Password:";
            // 
            // AddSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_SUsername);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txt_SAcesso);
            this.Controls.Add(this.txt_SNome);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_SPassword);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.bt_SRegista);
            this.Controls.Add(this.metroLabel2);
            this.Name = "AddSecretaria";
            this.Size = new System.Drawing.Size(589, 404);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_SUsername;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txt_SAcesso;
        private MetroFramework.Controls.MetroTextBox txt_SNome;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_SPassword;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton bt_SRegista;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}
