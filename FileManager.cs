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
        string fPath_;

        public FileManager(string fpath)
        {
            fPath_ = fpath;
        }

        public void saveArmy(Army army, string fpath)
        {
            StreamWriter sw = new StreamWriter(fpath);
            List<string> record = army.writeArmyRecord();

            foreach (string line in record)
            {
                sw.WriteLine(line);
            }
            sw.Close();
        }

        public Army loadArmy()
        {
            Army army= new Army();

            return army;
        }
    }
}
