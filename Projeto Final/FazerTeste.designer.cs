namespace Projeto_Final
{
    partial class FazerTeste
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
            this.ComboBoxTestes = new MetroFramework.Controls.MetroComboBox();
            this.lbltituloTeste = new MetroFramework.Controls.MetroLabel();
            this.lblinicioTeste = new MetroFramework.Controls.MetroLabel();
            this.lblfimTeste = new MetroFramework.Controls.MetroLabel();
            this.btnStartTeste = new MetroFramework.Controls.MetroButton();
            this.lblEscolha = new MetroFramework.Controls.MetroLabel();
            this.lbl_Formador = new MetroFramework.Controls.MetroLabel();
            this.lblDuracao = new MetroFramework.Controls.MetroLabel();
            this.lblData = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // ComboBoxTestes
            // 
            this.ComboBoxTestes.FormattingEnabled = true;
            this.ComboBoxTestes.ItemHeight = 23;
            this.ComboBoxTestes.Location = new System.Drawing.Point(36, 98);
            this.ComboBoxTestes.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxTestes.Name = "ComboBoxTestes";
            this.ComboBoxTestes.Size = new System.Drawing.Size(228, 29);
            this.ComboBoxTestes.TabIndex = 0;
            this.ComboBoxTestes.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTestes_SelectedIndexChanged);
            // 
            // lbltituloTeste
            // 
            this.lbltituloTeste.AutoSize = true;
            this.lbltituloTeste.Location = new System.Drawing.Point(38, 152);
            this.lbltituloTeste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltituloTeste.Name = "lbltituloTeste";
            this.lbltituloTeste.Size = new System.Drawing.Size(44, 19);
            this.lbltituloTeste.TabIndex = 1;
            this.lbltituloTeste.Text = "Titulo:";
            // 
            // lblinicioTeste
            // 
            this.lblinicioTeste.AutoSize = true;
            this.lblinicioTeste.Location = new System.Drawing.Point(38, 216);
            this.lblinicioTeste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblinicioTeste.Name = "lblinicioTeste";
            this.lblinicioTeste.Size = new System.Drawing.Size(42, 19);
            this.lblinicioTeste.TabIndex = 2;
            this.lblinicioTeste.Text = "Inicio:";
            // 
            // lblfimTeste
            // 
            this.lblfimTeste.AutoSize = true;
            this.lblfimTeste.Location = new System.Drawing.Point(38, 246);
            this.lblfimTeste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfimTeste.Name = "lblfimTeste";
            this.lblfimTeste.Size = new System.Drawing.Size(34, 19);
            this.lblfimTeste.TabIndex = 3;
            this.lblfimTeste.Text = "Fim:";
            // 
            // btnStartTeste
            // 
            this.btnStartTeste.Enabled = false;
            this.btnStartTeste.Location = new System.Drawing.Point(243, 360);
            this.btnStartTeste.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartTeste.Name = "btnStartTeste";
            this.btnStartTeste.Size = new System.Drawing.Size(70, 34);
            this.btnStartTeste.TabIndex = 4;
            this.btnStartTeste.Text = "Start";
            this.btnStartTeste.Click += new System.EventHandler(this.btnStartTeste_Click);
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEscolha.ForeColor = System.Drawing.Color.Black;
            this.lblEscolha.Location = new System.Drawing.Point(36, 32);
            this.lblEscolha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(198, 25);
            this.lblEscolha.TabIndex = 5;
            this.lblEscolha.Text = "Escolha o teste a realizar";
            // 
            // lbl_Formador
            // 
            this.lbl_Formador.AutoSize = true;
            this.lbl_Formador.Location = new System.Drawing.Point(36, 316);
            this.lbl_Formador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Formador.Name = "lbl_Formador";
            this.lbl_Formador.Size = new System.Drawing.Size(76, 19);
            this.lbl_Formador.TabIndex = 6;
            this.lbl_Formador.Text = "Formador: ";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(36, 279);
            this.lblDuracao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(61, 19);
            this.lblDuracao.TabIndex = 7;
            this.lblDuracao.Text = "Duração:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(39, 183);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(43, 19);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "Data: ";
            // 
            // FazerTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.lbl_Formador);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.btnStartTeste);
            this.Controls.Add(this.lblfimTeste);
            this.Controls.Add(this.lblinicioTeste);
            this.Controls.Add(this.lbltituloTeste);
            this.Controls.Add(this.ComboBoxTestes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FazerTeste";
            this.Size = new System.Drawing.Size(721, 480);
            this.Load += new System.EventHandler(this.FazerTeste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ComboBoxTestes;
        private MetroFramework.Controls.MetroLabel lbltituloTeste;
        private MetroFramework.Controls.MetroLabel lblinicioTeste;
        private MetroFramework.Controls.MetroLabel lblfimTeste;
        private MetroFramework.Controls.MetroButton btnStartTeste;
        private MetroFramework.Controls.MetroLabel lblEscolha;
        private MetroFramework.Controls.MetroLabel lbl_Formador;
        private MetroFramework.Controls.MetroLabel lblDuracao;
        private MetroFramework.Controls.MetroLabel lblData;
    }
}
