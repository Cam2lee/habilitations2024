using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using habilitations2024.dal;
using habilitations2024.view;

namespace habilitations2024
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DeveloppeurAccess da = new DeveloppeurAccess();
            da.Test_GetLesDeveloppeurs_ParProfil();
            da.Test_GetLesDeveloppeurs_TousProfils();
            Application.Run(new FrmAuthentification());
        }
    }
}
