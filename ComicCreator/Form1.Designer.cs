namespace ComicCreator
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
            this.bttnExecute = new System.Windows.Forms.Button();
            this.txbxPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttnExecute
            // 
            this.bttnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnExecute.Location = new System.Drawing.Point(289, 58);
            this.bttnExecute.Name = "bttnExecute";
            this.bttnExecute.Size = new System.Drawing.Size(75, 23);
            this.bttnExecute.TabIndex = 0;
            this.bttnExecute.Text = "Execute";
            this.bttnExecute.UseVisualStyleBackColor = true;
            this.bttnExecute.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbxPath
            // 
            this.txbxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxPath.Location = new System.Drawing.Point(12, 12);
            this.txbxPath.Name = "txbxPath";
            this.txbxPath.Size = new System.Drawing.Size(352, 20);
            this.txbxPath.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 93);
            this.Controls.Add(this.txbxPath);
            this.Controls.Add(this.bttnExecute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnExecute;
        private System.Windows.Forms.TextBox txbxPath;
    }
}

