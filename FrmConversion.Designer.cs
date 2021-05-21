namespace NumberConversionApp
{
    partial class FrmConversion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cmbxBase = new System.Windows.Forms.ComboBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.txtOctal = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblBinary = new System.Windows.Forms.Label();
            this.lblOctal = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtInput.Location = new System.Drawing.Point(12, 23);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(416, 23);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // cmbxBase
            // 
            this.cmbxBase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbxBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cmbxBase.FormattingEnabled = true;
            this.cmbxBase.Items.AddRange(new object[] {
            "Decimal",
            "Binary",
            "Hexadecimal",
            "Octal"});
            this.cmbxBase.Location = new System.Drawing.Point(434, 22);
            this.cmbxBase.Name = "cmbxBase";
            this.cmbxBase.Size = new System.Drawing.Size(121, 23);
            this.cmbxBase.TabIndex = 1;
            this.cmbxBase.Text = "Base";
            this.cmbxBase.SelectedIndexChanged += new System.EventHandler(this.cmbxBase_SelectedIndexChanged);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblInput.Location = new System.Drawing.Point(12, 5);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(39, 15);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Input:";
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(208)))), ((int)(((byte)(206)))));
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnConvert.Location = new System.Drawing.Point(561, 22);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(95, 56);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.ReadOnly = true;
            this.txtDecimal.Size = new System.Drawing.Size(541, 23);
            this.txtDecimal.TabIndex = 4;
            // 
            // txtBinary
            // 
            this.txtBinary.Location = new System.Drawing.Point(95, 85);
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.ReadOnly = true;
            this.txtBinary.Size = new System.Drawing.Size(541, 23);
            this.txtBinary.TabIndex = 4;
            // 
            // txtHex
            // 
            this.txtHex.Location = new System.Drawing.Point(95, 114);
            this.txtHex.Name = "txtHex";
            this.txtHex.ReadOnly = true;
            this.txtHex.Size = new System.Drawing.Size(541, 23);
            this.txtHex.TabIndex = 4;
            // 
            // txtOctal
            // 
            this.txtOctal.Location = new System.Drawing.Point(95, 143);
            this.txtOctal.Name = "txtOctal";
            this.txtOctal.ReadOnly = true;
            this.txtOctal.Size = new System.Drawing.Size(541, 23);
            this.txtOctal.TabIndex = 4;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(208)))), ((int)(((byte)(206)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Location = new System.Drawing.Point(614, 177);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(22, 23);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "?";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblDecimal
            // 
            this.lblDecimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDecimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblDecimal.Location = new System.Drawing.Point(12, 59);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(54, 15);
            this.lblDecimal.TabIndex = 6;
            this.lblDecimal.Text = "Decimal:";
            // 
            // lblHex
            // 
            this.lblHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHex.AutoSize = true;
            this.lblHex.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblHex.Location = new System.Drawing.Point(12, 117);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(79, 15);
            this.lblHex.TabIndex = 6;
            this.lblHex.Text = "Hexadecimal:";
            // 
            // lblBinary
            // 
            this.lblBinary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBinary.AutoSize = true;
            this.lblBinary.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBinary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblBinary.Location = new System.Drawing.Point(12, 88);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(43, 15);
            this.lblBinary.TabIndex = 6;
            this.lblBinary.Text = "Binary:";
            // 
            // lblOctal
            // 
            this.lblOctal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOctal.AutoSize = true;
            this.lblOctal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOctal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lblOctal.Location = new System.Drawing.Point(12, 146);
            this.lblOctal.Name = "lblOctal";
            this.lblOctal.Size = new System.Drawing.Size(38, 15);
            this.lblOctal.TabIndex = 6;
            this.lblOctal.Text = "Octal:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(208)))), ((int)(((byte)(206)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(13, 177);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(643, 212);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOctal);
            this.Controls.Add(this.lblBinary);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.txtOctal);
            this.Controls.Add(this.txtHex);
            this.Controls.Add(this.txtBinary);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.cmbxBase);
            this.Controls.Add(this.txtInput);
            this.MaximizeBox = false;
            this.Name = "FrmConversion";
            this.Text = "Number Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox cmbxBase;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtBinary;
        private System.Windows.Forms.TextBox txtHex;
        private System.Windows.Forms.TextBox txtOctal;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblBinary;
        private System.Windows.Forms.Label lblOctal;
        private System.Windows.Forms.Button btnExit;
    }
}

