namespace Projeto_Final
{
    partial class EditarProfUfcd
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.bt_EPURefresh = new System.Windows.Forms.Button();
            this.bt_EPUDelete = new MetroFramework.Controls.MetroButton();
            this.bt_EPUUpdate = new MetroFramework.Controls.MetroButton();
            this.txt_EPUId = new MetroFramework.Controls.MetroTextBox();
            this.txt_EPUUfcd = new MetroFramework.Controls.MetroTextBox();
            this.txt_EPUNomeProf = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.metroPanel1.Size = new System.Drawing.Size(817, 446);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = false;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 0;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.dataGridView1);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel3.HorizontalScrollbarBarColor = false;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 0;
            this.metroPanel3.Location = new System.Drawing.Point(326, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(491, 446);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = false;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(491, 446);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.bt_EPURefresh);
            this.metroPanel2.Controls.Add(this.bt_EPUDelete);
            this.metroPanel2.Controls.Add(this.bt_EPUUpdate);
            this.metroPanel2.Controls.Add(this.txt_EPUId);
            this.metroPanel2.Controls.Add(this.txt_EPUUfcd);
            this.metroPanel2.Controls.Add(this.txt_EPUNomeProf);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.HorizontalScrollbarBarColor = false;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 0;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(320, 446);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = false;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 0;
            // 
            // bt_EPURefresh
            // 
            this.bt_EPURefresh.Image = global::Projeto_Final.Properties.Resources.ic_launcher2;
            this.bt_EPURefresh.Location = new System.Drawing.Point(121, 142);
            this.bt_EPURefresh.Name = "bt_EPURefresh";
            this.bt_EPURefresh.Size = new System.Drawing.Size(75, 39);
            this.bt_EPURefresh.TabIndex = 13;
            this.bt_EPURefresh.UseVisualStyleBackColor = true;
            this.bt_EPURefresh.Click += new System.EventHandler(this.bt_EPURefresh_Click);
            // 
            // bt_EPUDelete
            // 
            this.bt_EPUDelete.Location = new System.Drawing.Point(204, 142);
            this.bt_EPUDelete.Name = "bt_EPUDelete";
            this.bt_EPUDelete.Size = new System.Drawing.Size(99, 39);
            this.bt_EPUDelete.TabIndex = 12;
            this.bt_EPUDelete.Text = "DELETE";
            this.bt_EPUDelete.Click += new System.EventHandler(this.bt_EPUDelete_Click);
            // 
            // bt_EPUUpdate
            // 
            this.bt_EPUUpdate.Location = new System.Drawing.Point(16, 142);
            this.bt_EPUUpdate.Name = "bt_EPUUpdate";
            this.bt_EPUUpdate.Size = new System.Drawing.Size(99, 39);
            this.bt_EPUUpdate.TabIndex = 11;
            this.bt_EPUUpdate.Text = "UPDATE";
            this.bt_EPUUpdate.Click += new System.EventHandler(this.bt_EPUUpdate_Click);
            // 
            // txt_EPUId
            // 
            this.txt_EPUId.Enabled = false;
            this.txt_EPUId.Location = new System.Drawing.Point(16, 19);
            this.txt_EPUId.Multiline = true;
            this.txt_EPUId.Name = "txt_EPUId";
            this.txt_EPUId.Size = new System.Drawing.Size(287, 35);
            this.txt_EPUId.TabIndex = 10;
            this.txt_EPUId.Text = "ID User";
            // 
            // txt_EPUUfcd
            // 
            this.txt_EPUUfcd.Location = new System.Drawing.Point(16, 101);
            this.txt_EPUUfcd.Multiline = true;
            this.txt_EPUUfcd.Name = "txt_EPUUfcd";
            this.txt_EPUUfcd.Size = new System.Drawing.Size(287, 35);
            this.txt_EPUUfcd.TabIndex = 9;
            this.txt_EPUUfcd.Text = "ID UFCD";
            // 
            // txt_EPUNomeProf
            // 
            this.txt_EPUNomeProf.Enabled = false;
            this.txt_EPUNomeProf.Location = new System.Drawing.Point(16, 60);
            this.txt_EPUNomeProf.Multiline = true;
            this.txt_EPUNomeProf.Name = "txt_EPUNomeProf";
            this.txt_EPUNomeProf.Size = new System.Drawing.Size(287, 35);
            this.txt_EPUNomeProf.TabIndex = 8;
            this.txt_EPUNomeProf.Text = "Nome Formador";
            // 
            // EditarProfUfcd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "EditarProfUfcd";
            this.Size = new System.Drawing.Size(817, 446);
            this.Load += new System.EventHandler(this.EditarProfUfcd_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Button bt_EPURefresh;
        private MetroFramework.Controls.MetroButton bt_EPUDelete;
        private MetroFramework.Controls.MetroButton bt_EPUUpdate;
        private MetroFramework.Controls.MetroTextBox txt_EPUId;
        private MetroFramework.Controls.MetroTextBox txt_EPUUfcd;
        private MetroFramework.Controls.MetroTextBox txt_EPUNomeProf;
    }
}
