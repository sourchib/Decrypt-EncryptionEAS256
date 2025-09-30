using System;
using System.Text;
using System.Windows.Forms;
using AESDecryptWinForms.Forms;

namespace AESDecryptWinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // <-- Tambahkan ini

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
