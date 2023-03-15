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
        int battleTally_;
        int winTally_;
        int requisitionPoints_;
        int supplyLimit_;
        int supplyUsed_;

        static Helper helper = new Helper();
        
        internal void tallySupplyUsed()
        {
            int supplyUsed = 0;
            foreach(Unit unit in units_) { supplyUsed_ += unit.crusadePoints() + unit.powerRating(); }
            supplyUsed_ = supplyUsed;
        }
        public Army(string name, string faction)
        {
            this.name_ = name;
            this.faction_ = faction;
            units_ = new List<Unit>();
            supplyLimit_ = 50;
            supplyUsed_ = 0;
            requisitionPoints_ = 5;
            battleTally_ = 0;
            winTally_ = 0;
        }

        public Army(string[] armyRecord)
        {
            List<string> recordTokens = helper.parseDelimLine(armyRecord[0], '|');
            name_ = recordTokens[0];
            faction_ = recordTokens[1];

            units_ = new List<Unit>();
            for (int i = 1; i < armyRecord.Length; i++)
            {
                addUnit(new Unit(armyRecord[i]));
            }
        }


        public Army() { units_ = new List<Unit>(); }

        public int battleTally() { return battleTally_; }
        public int winTally() { return winTally_;}
        public int reqPoints() { return requisitionPoints_; }
        public int supplyLimit() { return supplyLimit_; }
        public int supplyUsed() { return supplyUsed_; }
        public string name() {  return name_;  }

        public string faction() { return faction_; }

        public void addUnit(Unit u) { units_.Add(u); tallySupplyUsed(); }

        public List<Unit> units() { return units_; }

        public Unit unit(int index) { return units_[index]; }

        public List<string> writeArmyRecord()
        {
            List<string> record = new List<string>();

            string armyLine = name_ + "|" + faction_ + "|";
            armyLine += battleTally_ + "|" + winTally_ + "|" + requisitionPoints_ + "|" + supplyLimit_ + "|" + supplyUsed_;
            record.Add(armyLine);

            foreach (Unit u in units_)
            {
                record.Add(u.writeUnitLine());
            }

            return record;
        }
       
    }
}
