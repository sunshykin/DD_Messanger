using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatterBox.Client.WinForms.Forms;

namespace ChatterBox.Client.WinForms
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //#if DEBUG
            //            Application.Run(new MainViewForm(Guid.Parse("d7e6daab-ad9a-48dd-8296-dbbf5087de51"), new AuthForm()));
            //#else
            Application.Run(new AuthForm());
            //#endif
        }
    }
}
