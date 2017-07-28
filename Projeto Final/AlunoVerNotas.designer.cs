namespace Projeto_Final
{
    partial class AlunoVerNotas
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
            this.lbl = new System.Windows.Forms.Label();
            this.dataGridNotas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(64, 34);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(150, 55);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Notas";
            // 
            // dataGridNotas
            // 
            this.dataGridNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNotas.Enabled = false;
            this.dataGridNotas.Location = new System.Drawing.Point(75, 116);
            this.dataGridNotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridNotas.Name = "dataGridNotas";
            this.dataGridNotas.Size = new System.Drawing.Size(853, 417);
            this.dataGridNotas.TabIndex = 4;
            // 
            // AlunoVerNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridNotas);
            this.Controls.Add(this.lbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AlunoVerNotas";
            this.Size = new System.Drawing.Size(999, 581);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl;
        public System.Windows.Forms.DataGridView dataGridNotas;
    }
}
