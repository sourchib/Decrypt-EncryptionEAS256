namespace AESDecryptWinForms.Forms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCipher;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblCipher;
        private System.Windows.Forms.Label lblOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCipher = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblCipher = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCipher
            // 
            this.txtCipher.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtCipher.Location = new System.Drawing.Point(12, 30);
            this.txtCipher.Multiline = true;
            this.txtCipher.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCipher.Size = new System.Drawing.Size(760, 200);
            this.txtCipher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top 
                | System.Windows.Forms.AnchorStyles.Left 
                | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCipher.Name = "txtCipher";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(12, 240);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(100, 30);
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Text = "Save Output";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtOutput.Location = new System.Drawing.Point(12, 290);
            this.txtOutput.Multiline = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(760, 260);
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top 
                | System.Windows.Forms.AnchorStyles.Left 
                | System.Windows.Forms.AnchorStyles.Right 
                | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtOutput.Name = "txtOutput";
            // 
            // lblCipher
            // 
            this.lblCipher.AutoSize = true;
            this.lblCipher.Location = new System.Drawing.Point(12, 10);
            this.lblCipher.Name = "lblCipher";
            this.lblCipher.Size = new System.Drawing.Size(135, 15);
            this.lblCipher.Text = "Input Ciphertext (Hex):";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 270);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(120, 15);
            this.lblOutput.Text = "Hasil Dekripsi (ASCII):";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblCipher);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtCipher);
            this.Name = "Form1";
            this.Text = "AES ECB Decryptor";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
