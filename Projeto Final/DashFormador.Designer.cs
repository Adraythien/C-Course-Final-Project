namespace Projeto_Final
{
    partial class DashFormador
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
            this.dataGridNotas = new System.Windows.Forms.DataGridView();
            this.ComboUFCD = new MetroFramework.Controls.MetroComboBox();
            this.ComboTurma = new MetroFramework.Controls.MetroComboBox();
            this.lblTurma = new MetroFramework.Controls.MetroLabel();
            this.lblUFCD = new MetroFramework.Controls.MetroLabel();
            this.lblTeste = new MetroFramework.Controls.MetroLabel();
            this.ComboTeste = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PanelTestesAgendados = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridNotas
            // 
            this.dataGridNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNotas.Enabled = false;
            this.dataGridNotas.Location = new System.Drawing.Point(340, 155);
            this.dataGridNotas.Name = "dataGridNotas";
            this.dataGridNotas.Size = new System.Drawing.Size(376, 372);
            this.dataGridNotas.TabIndex = 0;
            // 
            // ComboUFCD
            // 
            this.ComboUFCD.FormattingEnabled = true;
            this.ComboUFCD.ItemHeight = 23;
            this.ComboUFCD.Location = new System.Drawing.Point(472, 37);
            this.ComboUFCD.Name = "ComboUFCD";
            this.ComboUFCD.Size = new System.Drawing.Size(244, 29);
            this.ComboUFCD.TabIndex = 1;
            this.ComboUFCD.SelectedValueChanged += new System.EventHandler(this.ComboUFCD_SelectedValueChanged);
            // 
            // ComboTurma
            // 
            this.ComboTurma.FormattingEnabled = true;
            this.ComboTurma.ItemHeight = 23;
            this.ComboTurma.Location = new System.Drawing.Point(472, 107);
            this.ComboTurma.Name = "ComboTurma";
            this.ComboTurma.Size = new System.Drawing.Size(244, 29);
            this.ComboTurma.TabIndex = 2;
            this.ComboTurma.SelectedValueChanged += new System.EventHandler(this.ComboTurma_SelectedValueChanged);
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(407, 107);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(47, 19);
            this.lblTurma.TabIndex = 3;
            this.lblTurma.Text = "Turma";
            // 
            // lblUFCD
            // 
            this.lblUFCD.AutoSize = true;
            this.lblUFCD.Location = new System.Drawing.Point(409, 37);
            this.lblUFCD.Name = "lblUFCD";
            this.lblUFCD.Size = new System.Drawing.Size(43, 19);
            this.lblUFCD.TabIndex = 4;
            this.lblUFCD.Text = "UFCD";
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Location = new System.Drawing.Point(407, 72);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(39, 19);
            this.lblTeste.TabIndex = 6;
            this.lblTeste.Text = "Teste";
            // 
            // ComboTeste
            // 
            this.ComboTeste.FormattingEnabled = true;
            this.ComboTeste.ItemHeight = 23;
            this.ComboTeste.Location = new System.Drawing.Point(472, 72);
            this.ComboTeste.Name = "ComboTeste";
            this.ComboTeste.Size = new System.Drawing.Size(244, 29);
            this.ComboTeste.TabIndex = 5;
            this.ComboTeste.SelectedIndexChanged += new System.EventHandler(this.ComboTeste_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 128);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Testes Agendados";
            // 
            // PanelTestesAgendados
            // 
            this.PanelTestesAgendados.AutoScroll = true;
            this.PanelTestesAgendados.HorizontalScrollbar = true;
            this.PanelTestesAgendados.HorizontalScrollbarBarColor = true;
            this.PanelTestesAgendados.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelTestesAgendados.HorizontalScrollbarSize = 10;
            this.PanelTestesAgendados.Location = new System.Drawing.Point(11, 155);
            this.PanelTestesAgendados.Name = "PanelTestesAgendados";
            this.PanelTestesAgendados.Size = new System.Drawing.Size(319, 372);
            this.PanelTestesAgendados.TabIndex = 8;
            this.PanelTestesAgendados.VerticalScrollbar = true;
            this.PanelTestesAgendados.VerticalScrollbarBarColor = true;
            this.PanelTestesAgendados.VerticalScrollbarHighlightOnWheel = false;
            this.PanelTestesAgendados.VerticalScrollbarSize = 10;
            // 
            // DashFormador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelTestesAgendados);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblTeste);
            this.Controls.Add(this.ComboTeste);
            this.Controls.Add(this.lblUFCD);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.ComboTurma);
            this.Controls.Add(this.ComboUFCD);
            this.Controls.Add(this.dataGridNotas);
            this.Name = "DashFormador";
            this.Size = new System.Drawing.Size(765, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblTurma;
        private MetroFramework.Controls.MetroLabel lblUFCD;
        private MetroFramework.Controls.MetroLabel lblTeste;
        public MetroFramework.Controls.MetroComboBox ComboTeste;
        public MetroFramework.Controls.MetroComboBox ComboUFCD;
        public MetroFramework.Controls.MetroComboBox ComboTurma;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroPanel PanelTestesAgendados;
        public System.Windows.Forms.DataGridView dataGridNotas;
    }
}
