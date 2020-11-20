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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            status_lb.DoubleClick += new EventHandler(newParam_doubleClick);
            button5.Click += new EventHandler(UpdateProgram_Click);
            listBox1.DoubleClick += new EventHandler(UpdateProgramData_DoubleClick);
            listBox2.DoubleClick += new EventHandler(UpdateUserData_DoubleClick);

            status_lb.Text = $"CPU:  {MainProgram.MyGlobals.pm.Frequency} GHz  RAM: {MainProgram.MyGlobals.pm.RAM} Mb  " +
                $"OC: {MainProgram.MyGlobals.pm.TypeOC}  HDD: {MainProgram.MyGlobals.pm.HDD} Gb";
        }

        private void UpdateProgramData_DoubleClick(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            MainProgram.MyGlobals.np.tb_name.Text = MainProgram.MyGlobals.pm.InstallPrograms[index].Name;
            MainProgram.MyGlobals.np.cb_OC.Text = MainProgram.MyGlobals.pm.InstallPrograms[index].TypeOC;
            MainProgram.MyGlobals.np.tb_producer.Text = MainProgram.MyGlobals.pm.InstallPrograms[index].Producer;
            MainProgram.MyGlobals.np.dt.Value = MainProgram.MyGlobals.pm.InstallPrograms[index].InstallDate;
            MainProgram.MyGlobals.np.cb_version.Text = MainProgram.MyGlobals.pm.InstallPrograms[index].Version.ToString();

            if (MainProgram.MyGlobals.pm.InstallPrograms[index].RequiredRAM == 512)
            {
                MainProgram.MyGlobals.np.rb_512.Checked = true;
            }
            else if (MainProgram.MyGlobals.pm.InstallPrograms[index].RequiredRAM == 1024)
            {
                MainProgram.MyGlobals.np.rb_1.Checked = true;
            }
            else if (MainProgram.MyGlobals.pm.InstallPrograms[index].RequiredRAM == 2048)
            {
                MainProgram.MyGlobals.np.rb_2.Checked = true;
            }
            else if (MainProgram.MyGlobals.pm.InstallPrograms[index].RequiredRAM == 4096)
            {
                MainProgram.MyGlobals.np.rb_4.Checked = true;
            }
            else if (MainProgram.MyGlobals.pm.InstallPrograms[index].RequiredRAM == 8192)
            {
                MainProgram.MyGlobals.np.rb_8.Checked = true;
            }
            else if (MainProgram.MyGlobals.pm.InstallPrograms[index].RequiredRAM == 16384)
            {
                MainProgram.MyGlobals.np.rb_16.Checked = true;
            }

            MainProgram.MyGlobals.np.spin_cpu.Value = (decimal)MainProgram.MyGlobals.pm.InstallPrograms[index].RequiredFrequency;
            MainProgram.MyGlobals.np.spin_hdd.Value = MainProgram.MyGlobals.pm.InstallPrograms[index].HDD;

            MainProgram.MyGlobals.np.ControlBox = false;
            MainProgram.MyGlobals.np.ShowDialog();
            MainProgram.MyGlobals.pm.InstallPrograms.RemoveAt(index);
            UpdateListBox1();
            MainProgram.MyGlobals.np.ControlBox = true;
        }

        private void UpdateUserData_DoubleClick(object sender, EventArgs e)
        {
            int index = listBox2.SelectedIndex;
            string username = listBox2.Items[index].ToString();
            MainProgram.MyGlobals.newUser.tb_name.Text = MainProgram.MyGlobals.pm.Users.ElementAt(index).Key.ToString();
            MainProgram.MyGlobals.newUser.tb_password.Text = MainProgram.MyGlobals.pm.Users.ElementAt(index).Value.ToString();

            MainProgram.MyGlobals.newUser.ControlBox = false;
            MainProgram.MyGlobals.pm.Users.Remove(username);
            MainProgram.MyGlobals.newUser.ShowDialog();
            UpdateListBox2();
            MainProgram.MyGlobals.newUser.ControlBox = true;
        }

        private void UpdateProgram_Click(object sender, EventArgs e)
        {
            MainProgram.MyGlobals.p.UpdateProgram();
        }

        private void newParam_doubleClick(object sender, EventArgs e)
        {
            MainProgram.MyGlobals.newParam.ShowDialog();
            status_lb.Text = $"CPU:  {MainProgram.MyGlobals.pm.Frequency} GHz  RAM: {MainProgram.MyGlobals.pm.RAM} Mb  " +
                $"OC: {MainProgram.MyGlobals.pm.TypeOC}  HDD: {MainProgram.MyGlobals.pm.HDD} Gb";
        }

        private void AddNewProgram(object sender, EventArgs e)
        {
            MainProgram.MyGlobals.np.ShowDialog();
            listBox1.Items.Add(MainProgram.MyGlobals.pm.InstallPrograms[MainProgram.MyGlobals.pm.InstallPrograms.Count - 1].Name);
        }

        private void DeleteProgram_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if(MainProgram.MyGlobals.pm.NumberOfPrograms > 0)
            {
                MainProgram.MyGlobals.pm.DeleteProgram(index);
                UpdateListBox1();
            } 
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            MainProgram.MyGlobals.newUser.ShowDialog();

            UpdateListBox2();
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            int index = listBox2.SelectedIndex;

            if(MainProgram.MyGlobals.pm.NumberOfUsers > 0)
            {
                string username = listBox2.Items[index].ToString();
                MainProgram.MyGlobals.pm.DeleteUser(username);
                UpdateListBox2();
            }
        }

        private void UpdateListBox1()
        {
            listBox1.Items.Clear();

            foreach (Program program in MainProgram.MyGlobals.pm.InstallPrograms)
            {
                listBox1.Items.Add(program.Name);
            }
        }

        private void UpdateListBox2()
        {
            listBox2.Items.Clear();
            foreach (var user in MainProgram.MyGlobals.pm.Users)
            {
                listBox2.Items.Add(user.Key);
            }
        }

        private void button1_Click(object sender, EventArgs e) //>
        {
            int index = listBox1.SelectedIndex;

            if(MainProgram.MyGlobals.pm.NumberOfPrograms > 0)
            {
                bool result = MainProgram.MyGlobals.p > MainProgram.MyGlobals.pm;

                if (result == true)
                {
                    MessageBox.Show("Требования недостаточны.");    
                }
                else
                {
                    MessageBox.Show("Требования подходящие.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //<
        {
            int index = listBox1.SelectedIndex;

            if (MainProgram.MyGlobals.pm.NumberOfPrograms > 0)
            {
                bool result = MainProgram.MyGlobals.p < MainProgram.MyGlobals.pm;

                if (result == true)
                {
                    MessageBox.Show("Требования подходящие.");
                }
                else
                {
                    MessageBox.Show("Требования недостаточны.");
                }
            }
        }

        private void Comparison_Click(object sender, EventArgs e)
        {
            if(MainProgram.MyGlobals.pm.NumberOfPrograms > 0 || MainProgram.MyGlobals.pm.NumberOfUsers > 0)
            {
                MainProgram.MyGlobals.comparison.UpdateComboBoxes();
                MainProgram.MyGlobals.comparison.ShowDialog();
            }
        }
    }
}
