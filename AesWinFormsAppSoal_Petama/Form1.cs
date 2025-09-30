using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AesWinFormsApp
{
    public partial class Form1 : Form
    {
        private const string DefaultKey = "11223344556677888877665544332211"; // 32 chars = AES-256
        private const string DefaultIV = "1111111111111111"; // 16 chars = AES IV

        public Form1()
        {
            InitializeComponent();

            // Set default Key & IV saat form load
            txtKey.Text = DefaultKey;
            txtIV.Text = DefaultIV;

            // Biar user tidak bisa ubah
            txtKey.ReadOnly = true;
            txtIV.ReadOnly = true;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txtInput.Text;
                string key = txtKey.Text;
                string iv = txtIV.Text;

                var mode = cmbCipherMode.SelectedItem as CipherMode? ?? CipherMode.CBC;
                var padding = cmbPadding.SelectedItem as PaddingMode? ?? PaddingMode.PKCS7;

                string result = Encrypt(text, key, iv, mode, padding);
                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string cipher = txtInput.Text;
                string key = txtKey.Text;
                string iv = txtIV.Text;

                var mode = cmbCipherMode.SelectedItem as CipherMode? ?? CipherMode.CBC;
                var padding = cmbPadding.SelectedItem as PaddingMode? ?? PaddingMode.PKCS7;

                string result = Decrypt(cipher, key, iv, mode, padding);
                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string Encrypt(string plainText, string secretKey, string ivString, CipherMode mode, PaddingMode padding)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(secretKey);
            byte[] ivBytes = Encoding.UTF8.GetBytes(ivString);
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

            using var aes = Aes.Create();
            aes.Key = keyBytes;
            aes.IV = ivBytes;
            aes.Mode = mode;
            aes.Padding = padding;

            using var encryptor = aes.CreateEncryptor();
            var encrypted = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
            return Convert.ToBase64String(encrypted);
        }

        private string Decrypt(string cipherBase64, string secretKey, string ivString, CipherMode mode, PaddingMode padding)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(secretKey);
            byte[] ivBytes = Encoding.UTF8.GetBytes(ivString);
            byte[] cipherBytes = Convert.FromBase64String(cipherBase64);

            using var aes = Aes.Create();
            aes.Key = keyBytes;
            aes.IV = ivBytes;
            aes.Mode = mode;
            aes.Padding = padding;

            using var decryptor = aes.CreateDecryptor();
            var decrypted = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
            return Encoding.UTF8.GetString(decrypted);
        }
    }
}
