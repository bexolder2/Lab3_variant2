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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void NewUserSave_Click(object sender, EventArgs e)
        {
            MainProgram.MyGlobals.pm.AddUser(MainProgram.MyGlobals.newUser);
            Close();
        }
    }
}
