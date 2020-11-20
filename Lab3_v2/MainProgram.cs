using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_v2
{
    static class MainProgram
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static class MyGlobals
        {
            public static ProgramManager pm = new ProgramManager();
            public static NewProgram np = new NewProgram();
            public static NewUser newUser = new NewUser();
            public static Program p = new Program();
            public static NewParameters newParam = new NewParameters();
            public static Comparison_ comparison = new Comparison_();
        }
    }
}
