namespace Projeto_Final
{
    partial class AddUFCD
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
            this.txt_UNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_UNome = new MetroFramework.Controls.MetroTextBox();
            this.bt_UInserir = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txt_UNum
            // 
            this.txt_UNum.Location = new System.Drawing.Point(177, 122);
            this.txt_UNum.Name = "txt_UNum";
            this.txt_UNum.Size = new System.Drawing.Size(269, 23);
            this.txt_UNum.TabIndex = 9;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(62, 122);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 20);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Num:";
            // 
            // txt_UNome
            // 
            this.txt_UNome.Location = new System.Drawing.Point(177, 180);
            this.txt_UNome.Name = "txt_UNome";
            this.txt_UNome.Size = new System.Drawing.Size(269, 23);
            this.txt_UNome.TabIndex = 7;
            // 
            // bt_UInserir
            // 
            this.bt_UInserir.Location = new System.Drawing.Point(177, 240);
            this.bt_UInserir.Name = "bt_UInserir";
            this.bt_UInserir.Size = new System.Drawing.Size(269, 23);
            this.bt_UInserir.TabIndex = 6;
            this.bt_UInserir.Text = "Inserir";
            this.bt_UInserir.Click += new System.EventHandler(this.bt_UInserir_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(62, 183);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 20);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Nome UFCD";
            // 
            // AddUFCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_UNum);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_UNome);
            this.Controls.Add(this.bt_UInserir);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddUFCD";
            this.Size = new System.Drawing.Size(589, 404);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_UNum;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_UNome;
        private MetroFramework.Controls.MetroButton bt_UInserir;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
