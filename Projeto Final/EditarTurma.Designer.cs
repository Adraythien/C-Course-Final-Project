namespace Projeto_Final
{
    partial class EditarTurma
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
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_ETSigla = new MetroFramework.Controls.MetroTextBox();
            this.txt_ETNome = new MetroFramework.Controls.MetroTextBox();
            this.txt_ETId = new MetroFramework.Controls.MetroTextBox();
            this.bt_ETUpdate = new MetroFramework.Controls.MetroButton();
            this.bt_ETDelete = new MetroFramework.Controls.MetroButton();
            this.bt_ETRefresh = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.bt_ETRefresh);
            this.metroPanel2.Controls.Add(this.bt_ETDelete);
            this.metroPanel2.Controls.Add(this.bt_ETUpdate);
            this.metroPanel2.Controls.Add(this.txt_ETId);
            this.metroPanel2.Controls.Add(this.txt_ETNome);
            this.metroPanel2.Controls.Add(this.txt_ETSigla);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.HorizontalScrollbarBarColor = false;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 0;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(321, 528);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = false;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 0;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.dataGridView1);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = false;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 0;
            this.metroPanel3.Location = new System.Drawing.Point(321, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(585, 528);
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
            this.dataGridView1.Size = new System.Drawing.Size(585, 528);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // txt_ETSigla
            // 
            this.txt_ETSigla.Location = new System.Drawing.Point(15, 75);
            this.txt_ETSigla.Multiline = true;
            this.txt_ETSigla.Name = "txt_ETSigla";
            this.txt_ETSigla.Size = new System.Drawing.Size(287, 35);
            this.txt_ETSigla.TabIndex = 2;
            this.txt_ETSigla.Text = "Sigla";
            this.txt_ETSigla.Enter += new System.EventHandler(this.txt_ETSigla_Enter);
            this.txt_ETSigla.Leave += new System.EventHandler(this.txt_ETSigla_Leave);
            // 
            // txt_ETNome
            // 
            this.txt_ETNome.Location = new System.Drawing.Point(15, 116);
            this.txt_ETNome.Multiline = true;
            this.txt_ETNome.Name = "txt_ETNome";
            this.txt_ETNome.Size = new System.Drawing.Size(287, 35);
            this.txt_ETNome.TabIndex = 3;
            this.txt_ETNome.Text = "Nome Turma";
            this.txt_ETNome.Enter += new System.EventHandler(this.txt_ETNome_Enter);
            this.txt_ETNome.Leave += new System.EventHandler(this.txt_ETNome_Leave);
            // 
            // txt_ETId
            // 
            this.txt_ETId.Enabled = false;
            this.txt_ETId.Location = new System.Drawing.Point(15, 34);
            this.txt_ETId.Multiline = true;
            this.txt_ETId.Name = "txt_ETId";
            this.txt_ETId.Size = new System.Drawing.Size(287, 35);
            this.txt_ETId.TabIndex = 4;
            this.txt_ETId.Text = "ID";
            this.txt_ETId.Enter += new System.EventHandler(this.txt_ETId_Enter);
            this.txt_ETId.Leave += new System.EventHandler(this.txt_ETId_Leave);
            // 
            // bt_ETUpdate
            // 
            this.bt_ETUpdate.Location = new System.Drawing.Point(15, 157);
            this.bt_ETUpdate.Name = "bt_ETUpdate";
            this.bt_ETUpdate.Size = new System.Drawing.Size(99, 39);
            this.bt_ETUpdate.TabIndex = 5;
            this.bt_ETUpdate.Text = "UPDATE";
            this.bt_ETUpdate.Click += new System.EventHandler(this.bt_ETUpdate_Click);
            // 
            // bt_ETDelete
            // 
            this.bt_ETDelete.Location = new System.Drawing.Point(203, 157);
            this.bt_ETDelete.Name = "bt_ETDelete";
            this.bt_ETDelete.Size = new System.Drawing.Size(99, 39);
            this.bt_ETDelete.TabIndex = 6;
            this.bt_ETDelete.Text = "DELETE";
            this.bt_ETDelete.Click += new System.EventHandler(this.bt_ETDelete_Click);
            // 
            // bt_ETRefresh
            // 
            this.bt_ETRefresh.Image = global::Projeto_Final.Properties.Resources.ic_launcher2;
            this.bt_ETRefresh.Location = new System.Drawing.Point(120, 157);
            this.bt_ETRefresh.Name = "bt_ETRefresh";
            this.bt_ETRefresh.Size = new System.Drawing.Size(75, 39);
            this.bt_ETRefresh.TabIndex = 7;
            this.bt_ETRefresh.UseVisualStyleBackColor = true;
            this.bt_ETRefresh.Click += new System.EventHandler(this.bt_ETRefresh_Click);
            // 
            // EditarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "EditarTurma";
            this.Size = new System.Drawing.Size(906, 528);
            this.Load += new System.EventHandler(this.EditarTurma_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txt_ETId;
        private MetroFramework.Controls.MetroTextBox txt_ETNome;
        private MetroFramework.Controls.MetroTextBox txt_ETSigla;
        private System.Windows.Forms.Button bt_ETRefresh;
        private MetroFramework.Controls.MetroButton bt_ETDelete;
        private MetroFramework.Controls.MetroButton bt_ETUpdate;
    }
}
