using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Drawing2D;

namespace _40kListApp
{
    public class FileManager
    {
        public FileManager() { }

        public void saveArmy(Army army, StreamWriter sw)
        {
            List<string> record = army.writeArmyRecord();

            foreach (string line in record)
            {
                sw.WriteLine(line);
            }
            sw.Close();
        }

        public Army loadArmy(string fpath)
        {
            string[] armyRecord = System.IO.File.ReadAllLines(fpath);
            Army army = new Army(armyRecord);

            return army;
        }
    }
}
