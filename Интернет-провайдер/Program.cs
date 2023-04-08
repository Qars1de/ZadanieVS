using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Интернет_провайдер
{
    static class Program
    {
        public static int chet;
        public static int money;
        public static int tarifTV, TarifInet, TarifTvInet;
        public static int kolvo;
        public static string tarifName;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Reg());
        }
    }
}
