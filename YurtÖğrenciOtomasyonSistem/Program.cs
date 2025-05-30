using System;
using System.Windows.Forms;
using YurtÖğrenciOtomasyonSistem;
// using YurtÖğrenciOtomasyonSistem; // Bu satır gereksiz görünüyor (kullanılmayan namespace)

namespace YurtÖğrenciOtomasyonSistem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}