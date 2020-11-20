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
    public partial class Comparison_ : Form
    {
        public Comparison_()
        {
            InitializeComponent();
        }

        private void Equal1_Click(object sender, EventArgs e)
        {
            if(MainProgram.MyGlobals.pm.NumberOfUsers > 0)
            {
                if(cb_user1.Text != string.Empty && cb_user2.Text != string.Empty)
                {
                    bool result = MainProgram.MyGlobals.pm.ComparisonUsers(MainProgram.MyGlobals.pm.AvailableUsers.Find(item => item.Name == cb_user1.Text),
                                                                   MainProgram.MyGlobals.pm.AvailableUsers.Find(item => item.Name == cb_user2.Text));

                    if (result == true)
                        MessageBox.Show("Это одинаковые пользователи.");
                    else
                        MessageBox.Show("Это разные пользователи.");
                } 
            } 
        }

        private void Equal2_Click(object sender, EventArgs e)
        {
            if(MainProgram.MyGlobals.pm.NumberOfPrograms > 0)
            {
                if (cb_programm1.Text != string.Empty && cb_programm2.Text != string.Empty)
                {
                    bool result = MainProgram.MyGlobals.pm.ComparisonProgram(MainProgram.MyGlobals.pm.InstallPrograms.Find(item => item.Name == cb_programm1.Text),
                                                                     MainProgram.MyGlobals.pm.InstallPrograms.Find(item => item.Name == cb_programm2.Text));

                    if (result == true)
                        MessageBox.Show("Это одинаковые программы.");
                    else
                        MessageBox.Show("Это разные програмы.");
                }
            }
        }

        public void UpdateComboBoxes()
        {
            foreach (var users in MainProgram.MyGlobals.pm.AvailableUsers)
            {
                cb_user1.Items.Add(users.Name);
                cb_user2.Items.Add(users.Name);
            }
            cb_user1.Update();
            cb_user2.Update();

            foreach (var prg in MainProgram.MyGlobals.pm.InstallPrograms)
            {
                cb_programm1.Items.Add(Text = prg.Name);
                cb_programm2.Items.Add(Text = prg.Name);
            }
            cb_programm1.Update();
            cb_programm2.Update();
        }
    }
}
