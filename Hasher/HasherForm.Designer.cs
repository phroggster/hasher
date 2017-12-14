/*
 * Copyright © 2017  Hasher Development Team
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you
 * may not use this file except in compliance with the License.
 * 
 * You may obtain a copy of the License at:
 * https://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
 * implied.
 * 
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace Hasher
{
    partial class HasherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HasherForm));
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
            this.cbUpperCase = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(262, 197);
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
            this.btnBrowse.Location = new System.Drawing.Point(12, 197);
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
            this.lblFileName.Location = new System.Drawing.Point(12, 9);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(75, 20);
            this.lblFileName.TabIndex = 3;
            this.lblFileName.Text = "File:";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFileName
            // 
            this.tbFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFileName.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFileName.Location = new System.Drawing.Point(93, 12);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(244, 18);
            this.tbFileName.TabIndex = 4;
            // 
            // tbSHA1
            // 
            this.tbSHA1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSHA1.Location = new System.Drawing.Point(93, 64);
            this.tbSHA1.Name = "tbSHA1";
            this.tbSHA1.ReadOnly = true;
            this.tbSHA1.Size = new System.Drawing.Size(244, 18);
            this.tbSHA1.TabIndex = 8;
            // 
            // lblSHA1
            // 
            this.lblSHA1.Location = new System.Drawing.Point(12, 61);
            this.lblSHA1.Name = "lblSHA1";
            this.lblSHA1.Size = new System.Drawing.Size(75, 20);
            this.lblSHA1.TabIndex = 7;
            this.lblSHA1.Text = "SHA-1:";
            this.lblSHA1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSHA256
            // 
            this.tbSHA256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA256.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSHA256.Location = new System.Drawing.Point(93, 90);
            this.tbSHA256.Name = "tbSHA256";
            this.tbSHA256.ReadOnly = true;
            this.tbSHA256.Size = new System.Drawing.Size(244, 18);
            this.tbSHA256.TabIndex = 10;
            // 
            // lblSHA256
            // 
            this.lblSHA256.Location = new System.Drawing.Point(12, 87);
            this.lblSHA256.Name = "lblSHA256";
            this.lblSHA256.Size = new System.Drawing.Size(75, 20);
            this.lblSHA256.TabIndex = 9;
            this.lblSHA256.Text = "SHA-256:";
            this.lblSHA256.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSHA3256
            // 
            this.tbSHA3256.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA3256.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSHA3256.Location = new System.Drawing.Point(93, 116);
            this.tbSHA3256.Name = "tbSHA3256";
            this.tbSHA3256.ReadOnly = true;
            this.tbSHA3256.Size = new System.Drawing.Size(244, 18);
            this.tbSHA3256.TabIndex = 12;
            // 
            // lblSHA3256
            // 
            this.lblSHA3256.Location = new System.Drawing.Point(12, 113);
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
            this.tbSHA512.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSHA512.Location = new System.Drawing.Point(93, 142);
            this.tbSHA512.Name = "tbSHA512";
            this.tbSHA512.ReadOnly = true;
            this.tbSHA512.Size = new System.Drawing.Size(244, 18);
            this.tbSHA512.TabIndex = 14;
            // 
            // lblSHA512
            // 
            this.lblSHA512.Location = new System.Drawing.Point(12, 139);
            this.lblSHA512.Name = "lblSHA512";
            this.lblSHA512.Size = new System.Drawing.Size(75, 20);
            this.lblSHA512.TabIndex = 13;
            this.lblSHA512.Text = "SHA-512:";
            this.lblSHA512.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSHA3512
            // 
            this.tbSHA3512.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSHA3512.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSHA3512.Location = new System.Drawing.Point(93, 168);
            this.tbSHA3512.Name = "tbSHA3512";
            this.tbSHA3512.ReadOnly = true;
            this.tbSHA3512.Size = new System.Drawing.Size(244, 18);
            this.tbSHA3512.TabIndex = 16;
            // 
            // lblSHA3512
            // 
            this.lblSHA3512.Location = new System.Drawing.Point(12, 165);
            this.lblSHA3512.Name = "lblSHA3512";
            this.lblSHA3512.Size = new System.Drawing.Size(75, 20);
            this.lblSHA3512.TabIndex = 15;
            this.lblSHA3512.Text = "SHA3-512:";
            this.lblSHA3512.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMD5
            // 
            this.tbMD5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMD5.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMD5.Location = new System.Drawing.Point(93, 38);
            this.tbMD5.Name = "tbMD5";
            this.tbMD5.ReadOnly = true;
            this.tbMD5.Size = new System.Drawing.Size(244, 18);
            this.tbMD5.TabIndex = 6;
            // 
            // lblMD5
            // 
            this.lblMD5.Location = new System.Drawing.Point(12, 35);
            this.lblMD5.Name = "lblMD5";
            this.lblMD5.Size = new System.Drawing.Size(75, 20);
            this.lblMD5.TabIndex = 5;
            this.lblMD5.Text = "MD5:";
            this.lblMD5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbUpperCase
            // 
            this.cbUpperCase.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbUpperCase.AutoSize = true;
            this.cbUpperCase.Checked = true;
            this.cbUpperCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpperCase.Location = new System.Drawing.Point(133, 201);
            this.cbUpperCase.Name = "cbUpperCase";
            this.cbUpperCase.Size = new System.Drawing.Size(82, 17);
            this.cbUpperCase.TabIndex = 17;
            this.cbUpperCase.Text = "&Upper Case";
            this.cbUpperCase.UseVisualStyleBackColor = true;
            this.cbUpperCase.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBrowse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(349, 232);
            this.Controls.Add(this.cbUpperCase);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(365, 271);
            this.Name = "Form1";
            this.Text = "Hasher";
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
        private System.Windows.Forms.CheckBox cbUpperCase;
    }
}

