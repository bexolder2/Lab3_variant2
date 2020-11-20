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
    public partial class NewParameters : Form
    {
        public NewParameters()
        {
            InitializeComponent();
        }

        private void NewParameters_save(object sender, EventArgs e)
        {
            MainProgram.MyGlobals.pm.NewParameters(MainProgram.MyGlobals.newParam);
            Close();
        }
    }
}
