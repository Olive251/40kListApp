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

        public Army(string name_, string faction_)
        {
            this.name_ = name_;
            this.faction_ = faction_;
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
       
    }
}
