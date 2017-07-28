namespace Projeto_Final
{
    partial class RealizarTeste
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblTitulo = new MetroFramework.Controls.MetroLabel();
            this.comboTestes = new MetroFramework.Controls.MetroComboBox();
            this.PickerInicio = new System.Windows.Forms.DateTimePicker();
            this.PickerFim = new System.Windows.Forms.DateTimePicker();
            this.dataFim = new System.Windows.Forms.DateTimePicker();
            this.DataInicio = new System.Windows.Forms.DateTimePicker();
            this.txtdura = new MetroFramework.Controls.MetroTextBox();
            this.ComboTurma = new MetroFramework.Controls.MetroComboBox();
            this.btnAgendar = new MetroFramework.Controls.MetroButton();
            this.ComboUFCD = new MetroFramework.Controls.MetroComboBox();
            this.lblTIT = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(66, 269);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(47, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Turma";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(66, 240);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(31, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Fim";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(66, 210);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Inicio";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(264, 271);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Duracao";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(66, 110);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(41, 19);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Titulo";
            // 
            // comboTestes
            // 
            this.comboTestes.Enabled = false;
            this.comboTestes.FormattingEnabled = true;
            this.comboTestes.ItemHeight = 23;
            this.comboTestes.Location = new System.Drawing.Point(351, 56);
            this.comboTestes.Name = "comboTestes";
            this.comboTestes.Size = new System.Drawing.Size(382, 29);
            this.comboTestes.TabIndex = 6;
            this.comboTestes.SelectedIndexChanged += new System.EventHandler(this.comboTestes_SelectedIndexChanged);
            this.comboTestes.SelectionChangeCommitted += new System.EventHandler(this.comboTestes_SelectionChangeCommitted);
            // 
            // PickerInicio
            // 
            this.PickerInicio.Location = new System.Drawing.Point(111, 210);
            this.PickerInicio.Name = "PickerInicio";
            this.PickerInicio.Size = new System.Drawing.Size(149, 20);
            this.PickerInicio.TabIndex = 12;
            this.PickerInicio.ValueChanged += new System.EventHandler(this.PickerInicio_ValueChanged);
            // 
            // PickerFim
            // 
            this.PickerFim.Enabled = false;
            this.PickerFim.Location = new System.Drawing.Point(111, 239);
            this.PickerFim.Name = "PickerFim";
            this.PickerFim.Size = new System.Drawing.Size(149, 20);
            this.PickerFim.TabIndex = 13;
            // 
            // dataFim
            // 
            this.dataFim.CustomFormat = "yyyy-MM-dd";
            this.dataFim.Enabled = false;
            this.dataFim.Location = new System.Drawing.Point(266, 239);
            this.dataFim.MinDate = new System.DateTime(2017, 1, 24, 0, 0, 0, 0);
            this.dataFim.Name = "dataFim";
            this.dataFim.Size = new System.Drawing.Size(231, 20);
            this.dataFim.TabIndex = 14;
            this.dataFim.Value = new System.DateTime(2017, 1, 26, 0, 0, 0, 0);
            // 
            // DataInicio
            // 
            this.DataInicio.CustomFormat = "dd-mm-yyyy";
            this.DataInicio.Location = new System.Drawing.Point(266, 210);
            this.DataInicio.MinDate = new System.DateTime(2017, 1, 24, 0, 0, 0, 0);
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.Size = new System.Drawing.Size(231, 20);
            this.DataInicio.TabIndex = 15;
            this.DataInicio.Value = new System.DateTime(2017, 1, 26, 0, 0, 0, 0);
            this.DataInicio.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txtdura
            // 
            this.txtdura.Location = new System.Drawing.Point(328, 269);
            this.txtdura.Name = "txtdura";
            this.txtdura.Size = new System.Drawing.Size(89, 21);
            this.txtdura.TabIndex = 16;
            this.txtdura.Text = "Minutos";
            this.txtdura.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // ComboTurma
            // 
            this.ComboTurma.FormattingEnabled = true;
            this.ComboTurma.ItemHeight = 23;
            this.ComboTurma.Location = new System.Drawing.Point(116, 265);
            this.ComboTurma.Name = "ComboTurma";
            this.ComboTurma.Size = new System.Drawing.Size(102, 29);
            this.ComboTurma.TabIndex = 17;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(66, 321);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(199, 41);
            this.btnAgendar.TabIndex = 18;
            this.btnAgendar.Text = "Agendar Teste";
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // ComboUFCD
            // 
            this.ComboUFCD.FormattingEnabled = true;
            this.ComboUFCD.ItemHeight = 23;
            this.ComboUFCD.Location = new System.Drawing.Point(209, 57);
            this.ComboUFCD.Name = "ComboUFCD";
            this.ComboUFCD.Size = new System.Drawing.Size(123, 29);
            this.ComboUFCD.TabIndex = 19;
            this.ComboUFCD.SelectionChangeCommitted += new System.EventHandler(this.ComboUFCD_SelectionChangeCommitted);
            // 
            // lblTIT
            // 
            this.lblTIT.AutoSize = true;
            this.lblTIT.Location = new System.Drawing.Point(116, 110);
            this.lblTIT.Name = "lblTIT";
            this.lblTIT.Size = new System.Drawing.Size(0, 0);
            this.lblTIT.TabIndex = 20;
            // 
            // RealizarTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTIT);
            this.Controls.Add(this.ComboUFCD);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.ComboTurma);
            this.Controls.Add(this.txtdura);
            this.Controls.Add(this.DataInicio);
            this.Controls.Add(this.dataFim);
            this.Controls.Add(this.PickerFim);
            this.Controls.Add(this.PickerInicio);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.comboTestes);
            this.Name = "RealizarTeste";
            this.Size = new System.Drawing.Size(823, 543);
            this.Load += new System.EventHandler(this.RealizarTeste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblTitulo;
        public System.Windows.Forms.DateTimePicker PickerInicio;
        public System.Windows.Forms.DateTimePicker PickerFim;
        private MetroFramework.Controls.MetroButton btnAgendar;
        public MetroFramework.Controls.MetroComboBox ComboUFCD;
        public MetroFramework.Controls.MetroComboBox comboTestes;
        public MetroFramework.Controls.MetroComboBox ComboTurma;
        public System.Windows.Forms.DateTimePicker dataFim;
        public System.Windows.Forms.DateTimePicker DataInicio;
        public MetroFramework.Controls.MetroTextBox txtdura;
        public MetroFramework.Controls.MetroLabel lblTIT;
    }
}
