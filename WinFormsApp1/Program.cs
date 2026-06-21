using System;
using System.Windows.Forms;
using FinalProjek.View; // Pastikan ini ada agar sistem mengenali Form Login

namespace FinalProjek
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.Run(new Login());
        }
    }
}