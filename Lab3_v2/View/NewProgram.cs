using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_v2
{
    public partial class NewProgram : Form
    {
        public NewProgram()
        {
            InitializeComponent();    
        }

        private void save_program(object sender, EventArgs e)
        {
            MainProgram.MyGlobals.p = MainProgram.MyGlobals.pm.AddProgram(MainProgram.MyGlobals.np);
            Close();
        }
    }
}
