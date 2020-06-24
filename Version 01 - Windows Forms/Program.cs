using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using FirebirdSql.Data.Services;
using System.Diagnostics;

namespace Version_01___Windows_Forms
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Process[] processes = Process.GetProcessesByName("Medidor Reg DL2020");

            foreach (Process process in processes)
            {
                process.Kill();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
