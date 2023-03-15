using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40kListApp
{
    public class Army
    {
        string name_;
        string faction_;
        List<Unit> units_;

        public Army(string name, string faction)
        {
            this.name_ = name;
            this.faction_ = faction;
            units_ = new List<Unit>();
        }


        public Army() { units_ = new List<Unit>(); }

       public string name()
        {
            return name_;
        }

        public string faction()
        {
            return faction_;
        }

        public void addUnit(Unit u)
        {
            units_.Add(u);
        }

        public List<Unit> units() { return units_; }

        public Unit unit(int index) { return units_[index]; }

        public List<string> writeArmyRecord()
        {
            List<string> record = new List<string>();

            string armyLine = name_ + "|" + faction_;
            record.Add(armyLine);

            foreach (Unit u in units_)
            {
                record.Add(u.writeUnitLine());
            }

            return record;
        }
       
    }
}
