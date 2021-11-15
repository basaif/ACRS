using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACRS.Forms;
using BusinessLogic.RentalClasses;
using DataAccess;

namespace ACRS
{
    static class Program
    {
        public static IDataAccess connection = new DatabaseAccessor();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IDataAccess connection = new DatabaseAccessor();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
