namespace Projeto_Final
{
    partial class AlterPass
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
            this.bt_EUFCDUpdate = new MetroFramework.Controls.MetroButton();
            this.txt_ALTERPassAntiga = new MetroFramework.Controls.MetroTextBox();
            this.txt_ALTERPassNova1 = new MetroFramework.Controls.MetroTextBox();
            this.txt_ALTERUser = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // bt_EUFCDUpdate
            // 
            this.bt_EUFCDUpdate.Location = new System.Drawing.Point(60, 102);
            this.bt_EUFCDUpdate.Name = "bt_EUFCDUpdate";
            this.bt_EUFCDUpdate.Size = new System.Drawing.Size(99, 39);
            this.bt_EUFCDUpdate.TabIndex = 15;
            this.bt_EUFCDUpdate.Text = "ALTERAR";
            this.bt_EUFCDUpdate.Click += new System.EventHandler(this.bt_EUFCDUpdate_Click);
            // 
            // txt_ALTERPassAntiga
            // 
            this.txt_ALTERPassAntiga.Location = new System.Drawing.Point(71, 162);
            this.txt_ALTERPassAntiga.Multiline = true;
            this.txt_ALTERPassAntiga.Name = "txt_ALTERPassAntiga";
            this.txt_ALTERPassAntiga.Size = new System.Drawing.Size(287, 35);
            this.txt_ALTERPassAntiga.TabIndex = 14;
            this.txt_ALTERPassAntiga.Text = "Password Antiga";
            this.txt_ALTERPassAntiga.Visible = false;
            // 
            // txt_ALTERPassNova1
            // 
            this.txt_ALTERPassNova1.Location = new System.Drawing.Point(60, 61);
            this.txt_ALTERPassNova1.Multiline = true;
            this.txt_ALTERPassNova1.Name = "txt_ALTERPassNova1";
            this.txt_ALTERPassNova1.Size = new System.Drawing.Size(287, 35);
            this.txt_ALTERPassNova1.TabIndex = 12;
            this.txt_ALTERPassNova1.Text = "Password Nova";
            this.txt_ALTERPassNova1.Enter += new System.EventHandler(this.txt_ALTERPassNova1_Enter);
            this.txt_ALTERPassNova1.Leave += new System.EventHandler(this.txt_ALTERPassNova1_Leave);
            // 
            // txt_ALTERUser
            // 
            this.txt_ALTERUser.Enabled = false;
            this.txt_ALTERUser.Location = new System.Drawing.Point(71, 203);
            this.txt_ALTERUser.Multiline = true;
            this.txt_ALTERUser.Name = "txt_ALTERUser";
            this.txt_ALTERUser.Size = new System.Drawing.Size(287, 35);
            this.txt_ALTERUser.TabIndex = 16;
            this.txt_ALTERUser.Text = "User";
            this.txt_ALTERUser.Visible = false;
            // 
            // AlterPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_ALTERUser);
            this.Controls.Add(this.bt_EUFCDUpdate);
            this.Controls.Add(this.txt_ALTERPassAntiga);
            this.Controls.Add(this.txt_ALTERPassNova1);
            this.Name = "AlterPass";
            this.Size = new System.Drawing.Size(415, 269);
            this.Load += new System.EventHandler(this.AlterPass_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton bt_EUFCDUpdate;
        private MetroFramework.Controls.MetroTextBox txt_ALTERPassAntiga;
        private MetroFramework.Controls.MetroTextBox txt_ALTERPassNova1;
        private MetroFramework.Controls.MetroTextBox txt_ALTERUser;
    }
}
