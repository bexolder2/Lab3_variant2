using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_v2
{
    public class Program
    {
        public string Name { get; set; }
        public string TypeOC { get; set; }
        public string Producer { get; set; }
        public DateTime InstallDate { get; set; }
        public int Version { get; set; }
        public int RequiredRAM { get; set; }
        public double RequiredFrequency { get; set; }
        public int HDD { get; set; }

        public Program()
        {

        }

        public Program(string name, string oc, string  producer, DateTime dt, int version, double rf, int hdd, int ram = 512)
        {
            Name = name;
            TypeOC = oc;
            Producer = producer;
            InstallDate = dt;
            Version = version;
            RequiredRAM = ram;
            RequiredFrequency = rf;
            HDD = hdd;
        }

        public void UpdateProgram()
        {
            var rand = new Random();
            Version = rand.Next(Version, 6);
            RequiredRAM = rand.Next(RequiredRAM, 16385);
            HDD = rand.Next(HDD, 513);
            RequiredFrequency += rand.NextDouble();
        }

        public static bool operator >(Program recomended, ProgramManager current)
        {
            if (recomended.RequiredRAM > current.RAM || recomended.RequiredFrequency > current.Frequency)
                return true;
            else
                return false;
        }
        public static bool operator <(Program recomended, ProgramManager current)
        {
            if (recomended.RequiredRAM < current.RAM && recomended.RequiredFrequency < current.Frequency)
                return true;
            else
                return false;
        }
    }
}
