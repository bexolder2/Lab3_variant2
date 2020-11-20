using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_v2
{
    public class ProgramManager
    {
        private Program program;
        private User user;

        public List<Program> InstallPrograms { get; set; }
        public List<User> AvailableUsers { get; set; }
        public Dictionary<string, string> Users { get; set; }
        public int NumberOfPrograms { get; set; }
        public string TypeOC { get; set; }
        public int NumberOfUsers { get; set; }
        public double Frequency { get; set; }
        public int RAM { get; set; }
        public int HDD { get; set; }

        public ProgramManager()
        {
            InstallPrograms = new List<Program>();
            AvailableUsers = new List<User>();
            Users = new Dictionary<string, string>();
            user = new User();

            TypeOC = "Windows";
            RAM = 4096;
            Frequency = 3.8;
            HDD = 128;
        }

        public void ResolutionForUsers()
        {
            foreach(var au in AvailableUsers)
            {
                foreach(var installPr in InstallPrograms)
                {
                    if(installPr.RequiredFrequency <= Frequency)
                        if(installPr.RequiredRAM <= RAM)
                            if(installPr.HDD <=  HDD)
                                if(installPr.TypeOC == TypeOC)
                                {
                                    au.AvailablePrograms.Add(installPr);
                                }
                }
            }
        }

        public bool ComparisonProgram(Program pr1, Program pr2)
        {
            if (pr1.Equals(pr2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ComparisonUsers(User user1, User user2)
        {
            if (user1.Equals(user2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateProgram(Program program)
        {
            program.UpdateProgram();
        } 

        public Program AddProgram(NewProgram np)
        {
            string name = np.tb_name.Text;
            string typeoc = np.cb_OC.Text;
            string producer = np.tb_producer.Text;
            DateTime dtime = np.dt.Value.Date;
            int version;
            int.TryParse(np.cb_version.Text, out version);
            int recomRAM = 512;
            double cpu = (double)np.spin_cpu.Value;
            int hdd = (int)np.spin_hdd.Value;

            if (np.rb_512.Checked == true)
            {
                recomRAM = 512;
            }
            else if (np.rb_1.Checked == true)
            {
                recomRAM = 1024;
            }
            else if (np.rb_2.Checked == true)
            {
                recomRAM = 2 * 1024;
            }
            else if (np.rb_4.Checked == true)
            {
                recomRAM = 4 * 1024;
            }
            else if (np.rb_8.Checked == true)
            {
                recomRAM = 8 * 1024;
            }
            else if (np.rb_16.Checked == true)
            {
                recomRAM = 16 * 1024;
            }

            program = new Program(name, typeoc, producer, dtime, version, cpu, hdd, recomRAM);

            if(HDD - hdd >= 0)
            {
                InstallPrograms.Add(program);
                HDD -= hdd;
            }
            else
            {
                MessageBox.Show("Недостаточно места на диске");
            }
            NumberOfPrograms++;
            return program;
        }

        public void DeleteProgram(int index)
        {
            HDD += InstallPrograms[index].HDD;
            InstallPrograms.RemoveAt(index);
            NumberOfPrograms--;
        }

        public void AddUser(NewUser newUser)
        {
            string name = newUser.tb_name.Text;
            string password = newUser.tb_password.Text;
            Users.Add(name, password);
            user.Name = name;
            user.Password = password;
            AvailableUsers.Add(user);
            NumberOfUsers++;
        }

        public void DeleteUser(string username)
        {
            Users.Remove(username); 
            int index = 0;
            foreach(var user_ in AvailableUsers)
            {
                if(user_.Name == username)
                {
                   AvailableUsers.RemoveAt(index);
                }
                else
                {
                    index++;
                }
            }
            NumberOfUsers--;
        }

        public void NewParameters(NewParameters newParam)
        {
            TypeOC = newParam.cb_OC.Text;

            if (newParam.rb_512.Checked == true)
            {
                RAM = 512;
            }
            else if (newParam.rb_1.Checked == true)
            {
                RAM = 1024;
            }
            else if (newParam.rb_2.Checked == true)
            {
                RAM = 2 * 1024;
            }
            else if (newParam.rb_4.Checked == true)
            {
                RAM = 4 * 1024;
            }
            else if (newParam.rb_8.Checked == true)
            {
                RAM = 8 * 1024;
            }
            else if (newParam.rb_16.Checked == true)
            {
                RAM = 16 * 1024;
            }

            Frequency = (double)newParam.spin_cpu.Value;
            HDD = (int)newParam.spin_hdd.Value;
        }
    }
}
