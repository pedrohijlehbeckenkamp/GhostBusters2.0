using GhostBusters_Forms.View.PerfilP;
using GhostBusters_Forms.View.Status;
using GhostBusters_Forms.View.Tech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostBusters_Forms
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login()); // Login
        }
    }
}
