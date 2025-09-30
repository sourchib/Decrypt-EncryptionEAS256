using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using AESDecryptWinForms.Utils;

namespace AESDecryptWinForms.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string keyHex = "B4A78AFE62BD323D57232342D8522BABB4A78AFE62BD323D57232342D8522BAB";
                byte[] key = CryptoHelper.HexStringToBytes(keyHex);

                string cipherHex = txtCipher.Text.Replace("\r", "").Replace("\n", "").Replace(" ", "");
                if (cipherHex.Length == 0)
                {
                    MessageBox.Show("Masukkan ciphertext hex terlebih dahulu.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                byte[] cipherBytes = CryptoHelper.HexStringToBytes(cipherHex);

                byte[] decryptedBytes = CryptoHelper.AESDecrypt_ECB(cipherBytes, key);

                // Decode dari EBCDIC ke ASCII menggunakan cp1140 (bisa dicoba cp500, cp037, cp1140)
                string decoded = CryptoHelper.DecodeEBCDIC(decryptedBytes, "cp500");

                txtOutput.Text = decoded;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat dekripsi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOutput.Text))
            {
                MessageBox.Show("Tidak ada hasil dekripsi untuk disimpan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.FileName = "hasil_dekripsi.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, txtOutput.Text, Encoding.UTF8);
                    MessageBox.Show("File berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
