namespace NumberConversionApp
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.btnAboutExit = new System.Windows.Forms.Button();
            this.lblAboutHeading = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAboutExit
            // 
            this.btnAboutExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(208)))), ((int)(((byte)(206)))));
            this.btnAboutExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutExit.Location = new System.Drawing.Point(12, 578);
            this.btnAboutExit.Name = "btnAboutExit";
            this.btnAboutExit.Size = new System.Drawing.Size(45, 23);
            this.btnAboutExit.TabIndex = 0;
            this.btnAboutExit.Text = "Exit";
            this.btnAboutExit.UseVisualStyleBackColor = false;
            this.btnAboutExit.Click += new System.EventHandler(this.btnAboutExit_Click);
            // 
            // lblAboutHeading
            // 
            this.lblAboutHeading.AutoSize = true;
            this.lblAboutHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAboutHeading.Location = new System.Drawing.Point(13, 13);
            this.lblAboutHeading.Name = "lblAboutHeading";
            this.lblAboutHeading.Size = new System.Drawing.Size(155, 32);
            this.lblAboutHeading.TabIndex = 1;
            this.lblAboutHeading.Text = "User\'s Guide:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 62);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(453, 495);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(496, 613);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblAboutHeading);
            this.Controls.Add(this.btnAboutExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.Text = "FrmAbout";
            this.Load += new System.EventHandler(this.FrmAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAboutExit;
        private System.Windows.Forms.Label lblAboutHeading;
        private System.Windows.Forms.Label lblDescription;
    }
}