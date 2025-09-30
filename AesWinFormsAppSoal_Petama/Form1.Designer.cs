namespace AesWinFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.ComboBox cmbCipherMode;
        private System.Windows.Forms.ComboBox cmbPadding;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblIV;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblPadding;
        private System.Windows.Forms.Label lblOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.cmbCipherMode = new System.Windows.Forms.ComboBox();
            this.cmbPadding = new System.Windows.Forms.ComboBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblIV = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblPadding = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(120, 20);
            this.txtInput.Multiline = true;
            this.txtInput.Size = new System.Drawing.Size(400, 60);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(120, 90);
            this.txtKey.Size = new System.Drawing.Size(400, 23);
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(120, 120);
            this.txtIV.Size = new System.Drawing.Size(400, 23);
            // 
            // cmbCipherMode
            // 
            this.cmbCipherMode.Location = new System.Drawing.Point(120, 150);
            this.cmbCipherMode.Size = new System.Drawing.Size(200, 23);
            this.cmbCipherMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCipherMode.Items.AddRange(new object[] {
                System.Security.Cryptography.CipherMode.CBC,
                System.Security.Cryptography.CipherMode.ECB});
            this.cmbCipherMode.SelectedIndex = 0;
            // 
            // cmbPadding
            // 
            this.cmbPadding.Location = new System.Drawing.Point(120, 180);
            this.cmbPadding.Size = new System.Drawing.Size(200, 23);
            this.cmbPadding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPadding.Items.AddRange(new object[] {
                System.Security.Cryptography.PaddingMode.PKCS7,
                System.Security.Cryptography.PaddingMode.None});
            this.cmbPadding.SelectedIndex = 0;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(120, 210);
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(220, 210);
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(120, 250);
            this.txtOutput.Multiline = true;
            this.txtOutput.Size = new System.Drawing.Size(400, 100);
            // 
            // Labels
            // 
            this.lblInput.Text = "Input:";
            this.lblInput.Location = new System.Drawing.Point(20, 20);
            this.lblKey.Text = "Key:";
            this.lblKey.Location = new System.Drawing.Point(20, 90);
            this.lblIV.Text = "IV:";
            this.lblIV.Location = new System.Drawing.Point(20, 120);
            this.lblMode.Text = "Cipher Mode:";
            this.lblMode.Location = new System.Drawing.Point(20, 150);
            this.lblPadding.Text = "Padding:";
            this.lblPadding.Location = new System.Drawing.Point(20, 180);
            this.lblOutput.Text = "Output:";
            this.lblOutput.Location = new System.Drawing.Point(20, 250);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtIV);
            this.Controls.Add(this.cmbCipherMode);
            this.Controls.Add(this.cmbPadding);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblIV);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblPadding);
            this.Controls.Add(this.lblOutput);
            this.Text = "AES Encryption/Decryption Tool (Fixed Key & IV)";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
