using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrsach
{
    static class Program
    {
         public static int s;
         public static int n;
         public static Sportsmen [] stran;
        public static int[,] znachen;
        public static int[,] mestasort;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
         }   
    }
}
