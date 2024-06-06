namespace EinfachNurAbfuckGehDichLöschenDuVerdammterUhrensohn
{
    partial class Abfuck
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
            this.trollButton = new System.Windows.Forms.Button();
            this.hoverArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trollButton
            // 
            this.trollButton.Location = new System.Drawing.Point(249, 159);
            this.trollButton.Name = "trollButton";
            this.trollButton.Size = new System.Drawing.Size(567, 209);
            this.trollButton.TabIndex = 0;
            this.trollButton.Text = "Drück Mich!";
            this.trollButton.UseVisualStyleBackColor = true;
            this.trollButton.Click += new System.EventHandler(this.trollButton_Click);
            this.trollButton.MouseHover += new System.EventHandler(this.trollButton_MouseHover);
            // 
            // hoverArea
            // 
            this.hoverArea.BackColor = System.Drawing.SystemColors.Control;
            this.hoverArea.Cursor = System.Windows.Forms.Cursors.No;
            this.hoverArea.FlatAppearance.BorderSize = 0;
            this.hoverArea.Location = new System.Drawing.Point(209, 108);
            this.hoverArea.Name = "hoverArea";
            this.hoverArea.Size = new System.Drawing.Size(705, 364);
            this.hoverArea.TabIndex = 1;
            this.hoverArea.Text = "button1";
            this.hoverArea.UseCompatibleTextRendering = true;
            this.hoverArea.UseVisualStyleBackColor = false;
            this.hoverArea.MouseHover += new System.EventHandler(this.hoverArea_MouseHover);
            // 
            // Abfuck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 702);
            this.Controls.Add(this.trollButton);
            this.Controls.Add(this.hoverArea);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Abfuck";
            this.Text = "Abfuck";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Abfuck_FormClosed);
            this.Load += new System.EventHandler(this.Abfuck_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button trollButton;
        private System.Windows.Forms.Button hoverArea;
    }
}