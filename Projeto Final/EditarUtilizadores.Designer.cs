namespace Projeto_Final
{
    partial class EditarUtilizadores
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.dataGridEU = new System.Windows.Forms.DataGridView();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.bt_EURefresh = new System.Windows.Forms.Button();
            this.bt_EUDelete = new MetroFramework.Controls.MetroButton();
            this.bt_EUUpdate = new MetroFramework.Controls.MetroButton();
            this.EU_Level = new MetroFramework.Controls.MetroTextBox();
            this.EU_Password = new MetroFramework.Controls.MetroTextBox();
            this.EU_Username = new MetroFramework.Controls.MetroTextBox();
            this.EU_Turma = new MetroFramework.Controls.MetroTextBox();
            this.EU_Ufcd = new MetroFramework.Controls.MetroTextBox();
            this.EU_Nome = new MetroFramework.Controls.MetroTextBox();
            this.EU_Id = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEU)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = false;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 0;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1388, 526);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = false;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 0;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.dataGridEU);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel3.HorizontalScrollbarBarColor = false;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 0;
            this.metroPanel3.Location = new System.Drawing.Point(369, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1019, 526);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = false;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 0;
            // 
            // dataGridEU
            // 
            this.dataGridEU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridEU.Location = new System.Drawing.Point(0, 0);
            this.dataGridEU.Name = "dataGridEU";
            this.dataGridEU.RowTemplate.Height = 24;
            this.dataGridEU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEU.Size = new System.Drawing.Size(1019, 526);
            this.dataGridEU.TabIndex = 2;
            this.dataGridEU.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridEU_MouseDoubleClick);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.bt_EURefresh);
            this.metroPanel2.Controls.Add(this.bt_EUDelete);
            this.metroPanel2.Controls.Add(this.bt_EUUpdate);
            this.metroPanel2.Controls.Add(this.EU_Level);
            this.metroPanel2.Controls.Add(this.EU_Password);
            this.metroPanel2.Controls.Add(this.EU_Username);
            this.metroPanel2.Controls.Add(this.EU_Turma);
            this.metroPanel2.Controls.Add(this.EU_Ufcd);
            this.metroPanel2.Controls.Add(this.EU_Nome);
            this.metroPanel2.Controls.Add(this.EU_Id);
            this.metroPanel2.HorizontalScrollbarBarColor = false;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 0;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(363, 526);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = false;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 0;
            // 
            // bt_EURefresh
            // 
            this.bt_EURefresh.Image = global::Projeto_Final.Properties.Resources.ic_launcher2;
            this.bt_EURefresh.Location = new System.Drawing.Point(122, 329);
            this.bt_EURefresh.Name = "bt_EURefresh";
            this.bt_EURefresh.Size = new System.Drawing.Size(78, 40);
            this.bt_EURefresh.TabIndex = 11;
            this.bt_EURefresh.UseVisualStyleBackColor = true;
            this.bt_EURefresh.Click += new System.EventHandler(this.bt_EURefresh_Click);
            // 
            // bt_EUDelete
            // 
            this.bt_EUDelete.Location = new System.Drawing.Point(206, 329);
            this.bt_EUDelete.Name = "bt_EUDelete";
            this.bt_EUDelete.Size = new System.Drawing.Size(93, 40);
            this.bt_EUDelete.TabIndex = 10;
            this.bt_EUDelete.Text = "DELETE";
            this.bt_EUDelete.Click += new System.EventHandler(this.bt_EUDelete_Click);
            // 
            // bt_EUUpdate
            // 
            this.bt_EUUpdate.Location = new System.Drawing.Point(23, 329);
            this.bt_EUUpdate.Name = "bt_EUUpdate";
            this.bt_EUUpdate.Size = new System.Drawing.Size(93, 40);
            this.bt_EUUpdate.TabIndex = 9;
            this.bt_EUUpdate.Text = "UPDATE";
            this.bt_EUUpdate.Click += new System.EventHandler(this.bt_EUUpdate_Click);
            // 
            // EU_Level
            // 
            this.EU_Level.Location = new System.Drawing.Point(23, 270);
            this.EU_Level.Multiline = true;
            this.EU_Level.Name = "EU_Level";
            this.EU_Level.Size = new System.Drawing.Size(276, 35);
            this.EU_Level.TabIndex = 8;
            this.EU_Level.Text = "Level";
            this.EU_Level.Enter += new System.EventHandler(this.EU_Level_Enter);
            this.EU_Level.Leave += new System.EventHandler(this.EU_Level_Leave);
            // 
            // EU_Password
            // 
            this.EU_Password.Location = new System.Drawing.Point(23, 229);
            this.EU_Password.Multiline = true;
            this.EU_Password.Name = "EU_Password";
            this.EU_Password.Size = new System.Drawing.Size(276, 35);
            this.EU_Password.TabIndex = 7;
            this.EU_Password.Text = "Password";
            this.EU_Password.Enter += new System.EventHandler(this.EU_Password_Enter);
            this.EU_Password.Leave += new System.EventHandler(this.EU_Password_Leave);
            // 
            // EU_Username
            // 
            this.EU_Username.Location = new System.Drawing.Point(23, 188);
            this.EU_Username.Multiline = true;
            this.EU_Username.Name = "EU_Username";
            this.EU_Username.Size = new System.Drawing.Size(276, 35);
            this.EU_Username.TabIndex = 6;
            this.EU_Username.Text = "Username";
            this.EU_Username.Enter += new System.EventHandler(this.EU_Username_Enter);
            this.EU_Username.Leave += new System.EventHandler(this.EU_Username_Leave);
            // 
            // EU_Turma
            // 
            this.EU_Turma.Location = new System.Drawing.Point(23, 147);
            this.EU_Turma.Multiline = true;
            this.EU_Turma.Name = "EU_Turma";
            this.EU_Turma.Size = new System.Drawing.Size(276, 35);
            this.EU_Turma.TabIndex = 5;
            this.EU_Turma.Text = "Turma";
            this.EU_Turma.Enter += new System.EventHandler(this.EU_Turma_Enter);
            this.EU_Turma.Leave += new System.EventHandler(this.EU_Turma_Leave);
            // 
            // EU_Ufcd
            // 
            this.EU_Ufcd.Location = new System.Drawing.Point(23, 106);
            this.EU_Ufcd.Multiline = true;
            this.EU_Ufcd.Name = "EU_Ufcd";
            this.EU_Ufcd.Size = new System.Drawing.Size(276, 35);
            this.EU_Ufcd.TabIndex = 4;
            this.EU_Ufcd.Text = "UFCD";
            this.EU_Ufcd.Enter += new System.EventHandler(this.EU_Ufcd_Enter);
            this.EU_Ufcd.Leave += new System.EventHandler(this.EU_Ufcd_Leave);
            // 
            // EU_Nome
            // 
            this.EU_Nome.Location = new System.Drawing.Point(23, 65);
            this.EU_Nome.Multiline = true;
            this.EU_Nome.Name = "EU_Nome";
            this.EU_Nome.Size = new System.Drawing.Size(276, 35);
            this.EU_Nome.TabIndex = 3;
            this.EU_Nome.Text = "Nome";
            this.EU_Nome.Enter += new System.EventHandler(this.EU_Nome_Enter);
            this.EU_Nome.Leave += new System.EventHandler(this.EU_Nome_Leave);
            // 
            // EU_Id
            // 
            this.EU_Id.Enabled = false;
            this.EU_Id.Location = new System.Drawing.Point(23, 24);
            this.EU_Id.Multiline = true;
            this.EU_Id.Name = "EU_Id";
            this.EU_Id.Size = new System.Drawing.Size(276, 35);
            this.EU_Id.TabIndex = 2;
            this.EU_Id.Text = "ID";
            // 
            // EditarUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "EditarUtilizadores";
            this.Size = new System.Drawing.Size(1388, 526);
            this.Load += new System.EventHandler(this.EditarUtilizadores_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEU)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.DataGridView dataGridEU;
        private MetroFramework.Controls.MetroTextBox EU_Level;
        private MetroFramework.Controls.MetroTextBox EU_Password;
        private MetroFramework.Controls.MetroTextBox EU_Username;
        private MetroFramework.Controls.MetroTextBox EU_Turma;
        private MetroFramework.Controls.MetroTextBox EU_Ufcd;
        private MetroFramework.Controls.MetroTextBox EU_Nome;
        private MetroFramework.Controls.MetroTextBox EU_Id;
        private MetroFramework.Controls.MetroButton bt_EUDelete;
        private MetroFramework.Controls.MetroButton bt_EUUpdate;
        private System.Windows.Forms.Button bt_EURefresh;
    }
}
