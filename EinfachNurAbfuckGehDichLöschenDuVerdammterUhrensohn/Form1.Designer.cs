namespace EinfachNurAbfuckGehDichLöschenDuVerdammterUhrensohn
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.amogusTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // amogusTimer
            // 
            this.amogusTimer.Enabled = true;
            this.amogusTimer.Interval = 1;
            this.amogusTimer.Tick += new System.EventHandler(this.amogusTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1600, 886);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DeFormIschGelade);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer amogusTimer;
    }
}

