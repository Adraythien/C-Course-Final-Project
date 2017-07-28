namespace Projeto_Final
{
    partial class AddTurma
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bt_TInserir = new MetroFramework.Controls.MetroButton();
            this.txt_TNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_TSigla = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(78, 153);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nome Turma:";
            // 
            // bt_TInserir
            // 
            this.bt_TInserir.Location = new System.Drawing.Point(193, 210);
            this.bt_TInserir.Name = "bt_TInserir";
            this.bt_TInserir.Size = new System.Drawing.Size(269, 23);
            this.bt_TInserir.TabIndex = 1;
            this.bt_TInserir.Text = "Inserir";
            this.bt_TInserir.Click += new System.EventHandler(this.bt_TInserir_Click);
            // 
            // txt_TNome
            // 
            this.txt_TNome.Location = new System.Drawing.Point(193, 150);
            this.txt_TNome.Name = "txt_TNome";
            this.txt_TNome.Size = new System.Drawing.Size(269, 23);
            this.txt_TNome.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(78, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Sigla:";
            // 
            // txt_TSigla
            // 
            this.txt_TSigla.Location = new System.Drawing.Point(193, 92);
            this.txt_TSigla.Name = "txt_TSigla";
            this.txt_TSigla.Size = new System.Drawing.Size(269, 23);
            this.txt_TSigla.TabIndex = 4;
            // 
            // AddTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_TSigla);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_TNome);
            this.Controls.Add(this.bt_TInserir);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddTurma";
            this.Size = new System.Drawing.Size(589, 404);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton bt_TInserir;
        private MetroFramework.Controls.MetroTextBox txt_TNome;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_TSigla;
    }
}
