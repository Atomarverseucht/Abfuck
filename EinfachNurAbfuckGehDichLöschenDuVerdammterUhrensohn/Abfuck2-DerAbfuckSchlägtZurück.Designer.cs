namespace EinfachNurAbfuckGehDichLöschenDuVerdammterUhrensohn
{
    partial class Abfuck2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.loop = new System.Windows.Forms.Timer(this.components);
            this.lbProgress = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(800, 138);
            this.progressBar.TabIndex = 0;
            // 
            // loop
            // 
            this.loop.Enabled = true;
            this.loop.Tick += new System.EventHandler(this.loop_Tick);
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Location = new System.Drawing.Point(13, 166);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(70, 25);
            this.lbProgress.TabIndex = 1;
            this.lbProgress.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(104, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Abfuck2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.progressBar);
            this.Name = "Abfuck2";
            this.Text = "Abfuck2_DerAbfuckSchlägtZurück";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Abfuck2_DerAbfuckSchlägtZurück_FormClosed);
            this.Load += new System.EventHandler(this.Abfuck2_DerAbfuckSchlägtZurück_Load);
            this.SizeChanged += new System.EventHandler(this.Abfuck2_DerAbfuckSchlägtZurück_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer loop;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}