using System;
using System.Windows.Forms;
using FinalProjek.View;

namespace FinalProjek
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Register());
        }
    }
}
    