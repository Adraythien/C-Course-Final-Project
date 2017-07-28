namespace Projeto_Final
{
    partial class DashSecretaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashSecretaria));
            this.pb_CPU = new CircularProgressBar.CircularProgressBar();
            this.pb_RAM = new CircularProgressBar.CircularProgressBar();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbSeconds = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_Users = new CircularProgressBar.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_CPU
            // 
            this.pb_CPU.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("pb_CPU.AnimationFunction")));
            this.pb_CPU.AnimationSpeed = 500;
            this.pb_CPU.BackColor = System.Drawing.Color.Transparent;
            this.pb_CPU.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pb_CPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pb_CPU.InnerColor = System.Drawing.Color.White;
            this.pb_CPU.InnerMargin = 2;
            this.pb_CPU.InnerWidth = -1;
            this.pb_CPU.Location = new System.Drawing.Point(749, 436);
            this.pb_CPU.MarqueeAnimationSpeed = 2000;
            this.pb_CPU.Name = "pb_CPU";
            this.pb_CPU.OuterColor = System.Drawing.Color.Maroon;
            this.pb_CPU.OuterMargin = -25;
            this.pb_CPU.OuterWidth = 26;
            this.pb_CPU.ProgressColor = System.Drawing.Color.Blue;
            this.pb_CPU.ProgressWidth = 25;
            this.pb_CPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pb_CPU.Size = new System.Drawing.Size(200, 200);
            this.pb_CPU.StartAngle = 270;
            this.pb_CPU.SubscriptColor = System.Drawing.Color.Blue;
            this.pb_CPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pb_CPU.SubscriptText = "";
            this.pb_CPU.SuperscriptColor = System.Drawing.Color.Blue;
            this.pb_CPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pb_CPU.SuperscriptText = "";
            this.pb_CPU.TabIndex = 0;
            this.pb_CPU.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pb_CPU.Value = 68;
            // 
            // pb_RAM
            // 
            this.pb_RAM.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("pb_RAM.AnimationFunction")));
            this.pb_RAM.AnimationSpeed = 500;
            this.pb_RAM.BackColor = System.Drawing.Color.Transparent;
            this.pb_RAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pb_RAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pb_RAM.InnerColor = System.Drawing.Color.White;
            this.pb_RAM.InnerMargin = 2;
            this.pb_RAM.InnerWidth = -1;
            this.pb_RAM.Location = new System.Drawing.Point(1004, 436);
            this.pb_RAM.MarqueeAnimationSpeed = 2000;
            this.pb_RAM.Name = "pb_RAM";
            this.pb_RAM.OuterColor = System.Drawing.Color.Maroon;
            this.pb_RAM.OuterMargin = -25;
            this.pb_RAM.OuterWidth = 26;
            this.pb_RAM.ProgressColor = System.Drawing.Color.Blue;
            this.pb_RAM.ProgressWidth = 25;
            this.pb_RAM.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pb_RAM.Size = new System.Drawing.Size(200, 200);
            this.pb_RAM.StartAngle = 270;
            this.pb_RAM.SubscriptColor = System.Drawing.Color.Blue;
            this.pb_RAM.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pb_RAM.SubscriptText = "";
            this.pb_RAM.SuperscriptColor = System.Drawing.Color.Blue;
            this.pb_RAM.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pb_RAM.SuperscriptText = "";
            this.pb_RAM.TabIndex = 1;
            this.pb_RAM.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pb_RAM.Value = 68;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(825, 408);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 25);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "CPU";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(1078, 408);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 25);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "RAM";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(764, 32);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 140);
            this.lbTime.TabIndex = 12;
            // 
            // lbSeconds
            // 
            this.lbSeconds.AutoSize = true;
            this.lbSeconds.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeconds.Location = new System.Drawing.Point(1145, 99);
            this.lbSeconds.Name = "lbSeconds";
            this.lbSeconds.Size = new System.Drawing.Size(0, 56);
            this.lbSeconds.TabIndex = 13;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(35, 32);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(0, 81);
            this.lbDate.TabIndex = 14;
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.Location = new System.Drawing.Point(37, 124);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(0, 81);
            this.lbDay.TabIndex = 15;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(64, 352);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(145, 25);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "UTILIZADORES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_Final.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(64, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pb_Users
            // 
            this.pb_Users.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("pb_Users.AnimationFunction")));
            this.pb_Users.AnimationSpeed = 500;
            this.pb_Users.BackColor = System.Drawing.Color.Transparent;
            this.pb_Users.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pb_Users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pb_Users.InnerColor = System.Drawing.Color.White;
            this.pb_Users.InnerMargin = 2;
            this.pb_Users.InnerWidth = -1;
            this.pb_Users.Location = new System.Drawing.Point(215, 380);
            this.pb_Users.MarqueeAnimationSpeed = 2000;
            this.pb_Users.Name = "pb_Users";
            this.pb_Users.OuterColor = System.Drawing.Color.Maroon;
            this.pb_Users.OuterMargin = -28;
            this.pb_Users.OuterWidth = 26;
            this.pb_Users.ProgressColor = System.Drawing.Color.Silver;
            this.pb_Users.ProgressWidth = 5;
            this.pb_Users.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pb_Users.Size = new System.Drawing.Size(155, 155);
            this.pb_Users.StartAngle = 270;
            this.pb_Users.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pb_Users.SubscriptColor = System.Drawing.Color.Blue;
            this.pb_Users.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pb_Users.SubscriptText = "";
            this.pb_Users.SuperscriptColor = System.Drawing.Color.Blue;
            this.pb_Users.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pb_Users.SuperscriptText = "";
            this.pb_Users.TabIndex = 18;
            this.pb_Users.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pb_Users.Value = 68;
            // 
            // DashSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_Users);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lbDay);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbSeconds);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.pb_RAM);
            this.Controls.Add(this.pb_CPU);
            this.Name = "DashSecretaria";
            this.Size = new System.Drawing.Size(1235, 677);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar pb_CPU;
        private CircularProgressBar.CircularProgressBar pb_RAM;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbSeconds;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbDay;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularProgressBar.CircularProgressBar pb_Users;
    }
}
