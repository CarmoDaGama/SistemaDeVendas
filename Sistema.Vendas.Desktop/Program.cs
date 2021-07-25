using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace Sistema.Vendas.Desktop
{
    using System.Windows.Forms;
    using Views.Forms.Main;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            Application.Run(new FormMain());
        }
    }
}
