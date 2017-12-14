namespace Hasher
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblFileName = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.tbSHA1 = new System.Windows.Forms.TextBox();
            this.lblSHA1 = new System.Windows.Forms.Label();
            this.tbSHA256 = new System.Windows.Forms.TextBox();
            this.lblSHA256 = new System.Windows.Forms.Label();
            this.tbSHA3256 = new System.Windows.Forms.TextBox();
            this.lblSHA3256 = new System.Windows.Forms.Label();
            this.tbSHA512 = new System.Windows.Forms.TextBox();
            this.lblSHA512 = new System.Windows.Forms.Label();
            this.tbSHA3512 = new System.Windows.Forms.TextBox();
            this.lblSHA3512 = new System.Windows.Forms.Label();
            this.tbMD5 = new System.Windows.Forms.TextBox();
            this.lblMD5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(317, 199);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrowse.Location = new System.Drawing.Point(12, 199);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "&Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All files|*.*";
            this.openFileDialog1.InitialDirectory = "%USERPROFILE%";
            this.openFileDialog1.ReadOnlyChecked = true;
            // 
            // lblFileName
            // 
            this.lblFileName.Location = new System.Drawing.Point(12, 11);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(75, 20);
            this.lblFileName.TabIndex = 3;
            this.lblFileName.Text = "File Name:";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFileName
            // 
            this.tbFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFileName.Location = new System.Drawing.Point(93, 12);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(299, 20);
            this.tbFileName.TabIndex = 4;
            // 
            // tbSHA1
            // 
            this.tbSHA1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA1.Location = new System.Drawing.Point(93, 38);
            this.tbSHA1.Name = "tbSHA1";
            this.tbSHA1.ReadOnly = true;
            this.tbSHA1.Size = new System.Drawing.Size(299, 20);
            this.tbSHA1.TabIndex = 6;
            // 
            // lblSHA1
            // 
            this.lblSHA1.Location = new System.Drawing.Point(12, 37);
            this.lblSHA1.Name = "lblSHA1";
            this.lblSHA1.Size = new System.Drawing.Size(75, 20);
            this.lblSHA1.TabIndex = 5;
            this.lblSHA1.Text = "SHA-1:";
            this.lblSHA1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSHA256
            // 
            this.tbSHA256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA256.Location = new System.Drawing.Point(93, 64);
            this.tbSHA256.Name = "tbSHA256";
            this.tbSHA256.ReadOnly = true;
            this.tbSHA256.Size = new System.Drawing.Size(299, 20);
            this.tbSHA256.TabIndex = 8;
            // 
            // lblSHA256
            // 
            this.lblSHA256.Location = new System.Drawing.Point(12, 63);
            this.lblSHA256.Name = "lblSHA256";
            this.lblSHA256.Size = new System.Drawing.Size(75, 20);
            this.lblSHA256.TabIndex = 7;
            this.lblSHA256.Text = "SHA-256:";
            this.lblSHA256.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSHA3256
            // 
            this.tbSHA3256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA3256.Location = new System.Drawing.Point(93, 116);
            this.tbSHA3256.Name = "tbSHA3256";
            this.tbSHA3256.ReadOnly = true;
            this.tbSHA3256.Size = new System.Drawing.Size(299, 20);
            this.tbSHA3256.TabIndex = 12;
            // 
            // lblSHA3256
            // 
            this.lblSHA3256.Location = new System.Drawing.Point(12, 115);
            this.lblSHA3256.Name = "lblSHA3256";
            this.lblSHA3256.Size = new System.Drawing.Size(75, 20);
            this.lblSHA3256.TabIndex = 11;
            this.lblSHA3256.Text = "SHA3-256:";
            this.lblSHA3256.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSHA512
            // 
            this.tbSHA512.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA512.Location = new System.Drawing.Point(93, 90);
            this.tbSHA512.Name = "tbSHA512";
            this.tbSHA512.ReadOnly = true;
            this.tbSHA512.Size = new System.Drawing.Size(299, 20);
            this.tbSHA512.TabIndex = 10;
            // 
            // lblSHA512
            // 
            this.lblSHA512.Location = new System.Drawing.Point(12, 89);
            this.lblSHA512.Name = "lblSHA512";
            this.lblSHA512.Size = new System.Drawing.Size(75, 20);
            this.lblSHA512.TabIndex = 9;
            this.lblSHA512.Text = "SHA-512:";
            this.lblSHA512.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSHA3512
            // 
            this.tbSHA3512.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA3512.Location = new System.Drawing.Point(93, 142);
            this.tbSHA3512.Name = "tbSHA3512";
            this.tbSHA3512.ReadOnly = true;
            this.tbSHA3512.Size = new System.Drawing.Size(299, 20);
            this.tbSHA3512.TabIndex = 14;
            // 
            // lblSHA3512
            // 
            this.lblSHA3512.Location = new System.Drawing.Point(12, 141);
            this.lblSHA3512.Name = "lblSHA3512";
            this.lblSHA3512.Size = new System.Drawing.Size(75, 20);
            this.lblSHA3512.TabIndex = 13;
            this.lblSHA3512.Text = "SHA3-512:";
            this.lblSHA3512.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMD5
            // 
            this.tbMD5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMD5.Location = new System.Drawing.Point(93, 168);
            this.tbMD5.Name = "tbMD5";
            this.tbMD5.ReadOnly = true;
            this.tbMD5.Size = new System.Drawing.Size(299, 20);
            this.tbMD5.TabIndex = 16;
            // 
            // lblMD5
            // 
            this.lblMD5.Location = new System.Drawing.Point(12, 167);
            this.lblMD5.Name = "lblMD5";
            this.lblMD5.Size = new System.Drawing.Size(75, 20);
            this.lblMD5.TabIndex = 15;
            this.lblMD5.Text = "MD5:";
            this.lblMD5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBrowse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(404, 234);
            this.Controls.Add(this.tbMD5);
            this.Controls.Add(this.lblMD5);
            this.Controls.Add(this.tbSHA3512);
            this.Controls.Add(this.lblSHA3512);
            this.Controls.Add(this.tbSHA512);
            this.Controls.Add(this.lblSHA512);
            this.Controls.Add(this.tbSHA3256);
            this.Controls.Add(this.lblSHA3256);
            this.Controls.Add(this.tbSHA256);
            this.Controls.Add(this.lblSHA256);
            this.Controls.Add(this.tbSHA1);
            this.Controls.Add(this.lblSHA1);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnExit);
            this.MinimumSize = new System.Drawing.Size(365, 249);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.TextBox tbSHA1;
        private System.Windows.Forms.Label lblSHA1;
        private System.Windows.Forms.TextBox tbSHA256;
        private System.Windows.Forms.Label lblSHA256;
        private System.Windows.Forms.TextBox tbSHA3256;
        private System.Windows.Forms.Label lblSHA3256;
        private System.Windows.Forms.TextBox tbSHA512;
        private System.Windows.Forms.Label lblSHA512;
        private System.Windows.Forms.TextBox tbSHA3512;
        private System.Windows.Forms.Label lblSHA3512;
        private System.Windows.Forms.TextBox tbMD5;
        private System.Windows.Forms.Label lblMD5;
    }
}

