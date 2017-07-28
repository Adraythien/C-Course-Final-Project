namespace Projeto_Final
{
    partial class CriarTeste
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
            this.lableUFCD = new MetroFramework.Controls.MetroLabel();
            this.txtTitle = new MetroFramework.Controls.MetroTextBox();
            this.boxUFCD = new MetroFramework.Controls.MetroComboBox();
            this.btncriarTeste = new MetroFramework.Controls.MetroButton();
            this.lblteste = new MetroFramework.Controls.MetroLabel();
            this.PanelTestes = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // lableUFCD
            // 
            this.lableUFCD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lableUFCD.AutoSize = true;
            this.lableUFCD.Location = new System.Drawing.Point(135, 55);
            this.lableUFCD.Name = "lableUFCD";
            this.lableUFCD.Size = new System.Drawing.Size(43, 19);
            this.lableUFCD.TabIndex = 11;
            this.lableUFCD.Text = "UFCD";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTitle.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTitle.Location = new System.Drawing.Point(256, 55);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(378, 60);
            this.txtTitle.TabIndex = 8;
            this.txtTitle.Text = "Titulo do Teste";
            // 
            // boxUFCD
            // 
            this.boxUFCD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.boxUFCD.FormattingEnabled = true;
            this.boxUFCD.ItemHeight = 23;
            this.boxUFCD.Location = new System.Drawing.Point(92, 86);
            this.boxUFCD.Name = "boxUFCD";
            this.boxUFCD.Size = new System.Drawing.Size(134, 29);
            this.boxUFCD.TabIndex = 7;
            // 
            // btncriarTeste
            // 
            this.btncriarTeste.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncriarTeste.Location = new System.Drawing.Point(303, 135);
            this.btncriarTeste.Name = "btncriarTeste";
            this.btncriarTeste.Size = new System.Drawing.Size(258, 40);
            this.btncriarTeste.TabIndex = 13;
            this.btncriarTeste.Text = "Criar Teste";
            this.btncriarTeste.Click += new System.EventHandler(this.btncriarTeste_Click_1);
            // 
            // lblteste
            // 
            this.lblteste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblteste.AutoSize = true;
            this.lblteste.Location = new System.Drawing.Point(361, 265);
            this.lblteste.Name = "lblteste";
            this.lblteste.Size = new System.Drawing.Size(91, 19);
            this.lblteste.TabIndex = 14;
            this.lblteste.Text = "Testes Criados";
            // 
            // PanelTestes
            // 
            this.PanelTestes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PanelTestes.AutoScroll = true;
            this.PanelTestes.HorizontalScrollbar = true;
            this.PanelTestes.HorizontalScrollbarBarColor = true;
            this.PanelTestes.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelTestes.HorizontalScrollbarSize = 10;
            this.PanelTestes.Location = new System.Drawing.Point(92, 297);
            this.PanelTestes.Name = "PanelTestes";
            this.PanelTestes.Size = new System.Drawing.Size(670, 210);
            this.PanelTestes.TabIndex = 15;
            this.PanelTestes.VerticalScrollbar = true;
            this.PanelTestes.VerticalScrollbarBarColor = true;
            this.PanelTestes.VerticalScrollbarHighlightOnWheel = false;
            this.PanelTestes.VerticalScrollbarSize = 20;
            // 
            // CriarTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.PanelTestes);
            this.Controls.Add(this.lblteste);
            this.Controls.Add(this.btncriarTeste);
            this.Controls.Add(this.lableUFCD);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.boxUFCD);
            this.Name = "CriarTeste";
            this.Size = new System.Drawing.Size(823, 543);
            this.VisibleChanged += new System.EventHandler(this.CriarTeste_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lableUFCD;
        private MetroFramework.Controls.MetroTextBox txtTitle;
        private MetroFramework.Controls.MetroButton btncriarTeste;
        private MetroFramework.Controls.MetroLabel lblteste;
        private MetroFramework.Controls.MetroPanel PanelTestes;
        public MetroFramework.Controls.MetroComboBox boxUFCD;
    }
}
