namespace Projeto_Final
{
    partial class EditarUFCD
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
            this.bt_EUFCDRefresh = new System.Windows.Forms.Button();
            this.bt_EUFCDDelete = new MetroFramework.Controls.MetroButton();
            this.bt_EUFCDUpdate = new MetroFramework.Controls.MetroButton();
            this.txt_EUFCDId = new MetroFramework.Controls.MetroTextBox();
            this.txt_EUFCDNomeUFCD = new MetroFramework.Controls.MetroTextBox();
            this.txt_EUFCDNum = new MetroFramework.Controls.MetroTextBox();
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
            this.metroPanel1.Size = new System.Drawing.Size(906, 528);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = false;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 0;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.dataGridView1);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = false;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 0;
            this.metroPanel3.Location = new System.Drawing.Point(337, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(569, 528);
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
            this.dataGridView1.Size = new System.Drawing.Size(569, 528);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.bt_EUFCDRefresh);
            this.metroPanel2.Controls.Add(this.bt_EUFCDDelete);
            this.metroPanel2.Controls.Add(this.bt_EUFCDUpdate);
            this.metroPanel2.Controls.Add(this.txt_EUFCDId);
            this.metroPanel2.Controls.Add(this.txt_EUFCDNomeUFCD);
            this.metroPanel2.Controls.Add(this.txt_EUFCDNum);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.HorizontalScrollbarBarColor = false;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 0;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(337, 528);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = false;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 0;
            // 
            // bt_EUFCDRefresh
            // 
            this.bt_EUFCDRefresh.Image = global::Projeto_Final.Properties.Resources.ic_launcher2;
            this.bt_EUFCDRefresh.Location = new System.Drawing.Point(128, 140);
            this.bt_EUFCDRefresh.Name = "bt_EUFCDRefresh";
            this.bt_EUFCDRefresh.Size = new System.Drawing.Size(75, 39);
            this.bt_EUFCDRefresh.TabIndex = 13;
            this.bt_EUFCDRefresh.UseVisualStyleBackColor = true;
            this.bt_EUFCDRefresh.Click += new System.EventHandler(this.bt_EUFCDRefresh_Click);
            // 
            // bt_EUFCDDelete
            // 
            this.bt_EUFCDDelete.Location = new System.Drawing.Point(211, 140);
            this.bt_EUFCDDelete.Name = "bt_EUFCDDelete";
            this.bt_EUFCDDelete.Size = new System.Drawing.Size(99, 39);
            this.bt_EUFCDDelete.TabIndex = 12;
            this.bt_EUFCDDelete.Text = "DELETE";
            this.bt_EUFCDDelete.Click += new System.EventHandler(this.bt_EUFCDDelete_Click);
            // 
            // bt_EUFCDUpdate
            // 
            this.bt_EUFCDUpdate.Location = new System.Drawing.Point(23, 140);
            this.bt_EUFCDUpdate.Name = "bt_EUFCDUpdate";
            this.bt_EUFCDUpdate.Size = new System.Drawing.Size(99, 39);
            this.bt_EUFCDUpdate.TabIndex = 11;
            this.bt_EUFCDUpdate.Text = "UPDATE";
            this.bt_EUFCDUpdate.Click += new System.EventHandler(this.bt_EUFCDUpdate_Click);
            // 
            // txt_EUFCDId
            // 
            this.txt_EUFCDId.Enabled = false;
            this.txt_EUFCDId.Location = new System.Drawing.Point(23, 17);
            this.txt_EUFCDId.Multiline = true;
            this.txt_EUFCDId.Name = "txt_EUFCDId";
            this.txt_EUFCDId.Size = new System.Drawing.Size(287, 35);
            this.txt_EUFCDId.TabIndex = 10;
            this.txt_EUFCDId.Text = "ID";
            this.txt_EUFCDId.Enter += new System.EventHandler(this.txt_EUFCDId_Enter);
            this.txt_EUFCDId.Leave += new System.EventHandler(this.txt_EUFCDId_Leave);
            // 
            // txt_EUFCDNomeUFCD
            // 
            this.txt_EUFCDNomeUFCD.Location = new System.Drawing.Point(23, 99);
            this.txt_EUFCDNomeUFCD.Multiline = true;
            this.txt_EUFCDNomeUFCD.Name = "txt_EUFCDNomeUFCD";
            this.txt_EUFCDNomeUFCD.Size = new System.Drawing.Size(287, 35);
            this.txt_EUFCDNomeUFCD.TabIndex = 9;
            this.txt_EUFCDNomeUFCD.Text = "Nome UFCD";
            this.txt_EUFCDNomeUFCD.Enter += new System.EventHandler(this.txt_EUFCDNomeUFCD_Enter);
            this.txt_EUFCDNomeUFCD.Leave += new System.EventHandler(this.txt_EUFCDNomeUFCD_Leave);
            // 
            // txt_EUFCDNum
            // 
            this.txt_EUFCDNum.Location = new System.Drawing.Point(23, 58);
            this.txt_EUFCDNum.Multiline = true;
            this.txt_EUFCDNum.Name = "txt_EUFCDNum";
            this.txt_EUFCDNum.Size = new System.Drawing.Size(287, 35);
            this.txt_EUFCDNum.TabIndex = 8;
            this.txt_EUFCDNum.Text = "Numero UFCD";
            this.txt_EUFCDNum.Enter += new System.EventHandler(this.txt_EUFCDNum_Enter);
            this.txt_EUFCDNum.Leave += new System.EventHandler(this.txt_EUFCDNum_Leave);
            // 
            // EditarUFCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "EditarUFCD";
            this.Size = new System.Drawing.Size(906, 528);
            this.Load += new System.EventHandler(this.EditarUFCD_Load);
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
        private System.Windows.Forms.Button bt_EUFCDRefresh;
        private MetroFramework.Controls.MetroButton bt_EUFCDDelete;
        private MetroFramework.Controls.MetroButton bt_EUFCDUpdate;
        private MetroFramework.Controls.MetroTextBox txt_EUFCDId;
        private MetroFramework.Controls.MetroTextBox txt_EUFCDNomeUFCD;
        private MetroFramework.Controls.MetroTextBox txt_EUFCDNum;
    }
}
