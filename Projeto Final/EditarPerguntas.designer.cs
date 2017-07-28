namespace Projeto_Final
{
    partial class EditarPerguntas
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
            this.ComboUFCD = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.PanelPerguntas = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboUFCD
            // 
            this.ComboUFCD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboUFCD.FormattingEnabled = true;
            this.ComboUFCD.ItemHeight = 23;
            this.ComboUFCD.Location = new System.Drawing.Point(292, 27);
            this.ComboUFCD.Name = "ComboUFCD";
            this.ComboUFCD.Size = new System.Drawing.Size(160, 29);
            this.ComboUFCD.TabIndex = 0;
            this.ComboUFCD.SelectedValueChanged += new System.EventHandler(this.ComboUFCD_SelectedValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(225, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "UFCD :";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.ComboUFCD);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(686, 83);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // PanelPerguntas
            // 
            this.PanelPerguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPerguntas.HorizontalScrollbarBarColor = true;
            this.PanelPerguntas.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelPerguntas.HorizontalScrollbarSize = 10;
            this.PanelPerguntas.Location = new System.Drawing.Point(0, 83);
            this.PanelPerguntas.Name = "PanelPerguntas";
            this.PanelPerguntas.Size = new System.Drawing.Size(686, 439);
            this.PanelPerguntas.TabIndex = 3;
            this.PanelPerguntas.VerticalScrollbarBarColor = true;
            this.PanelPerguntas.VerticalScrollbarHighlightOnWheel = false;
            this.PanelPerguntas.VerticalScrollbarSize = 10;
            // 
            // EditarPerguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelPerguntas);
            this.Controls.Add(this.metroPanel1);
            this.Name = "EditarPerguntas";
            this.Size = new System.Drawing.Size(686, 522);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroComboBox ComboUFCD;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroPanel metroPanel1;
        public MetroFramework.Controls.MetroPanel PanelPerguntas;
    }
}
