using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40kListApp
{
    public class Unit
    {
        string name_;
        string type_;
        string battlefieldRole_;
        string faction_;
        int expPoints_;
        int powerRating_;
        int crusadePoints_;
        List<string> keywords_;

        public Unit()
        {
            expPoints_= 0;
            powerRating_= 0;
            crusadePoints_= 0;
        }

        public Unit(string name, string type, string bfRole, string faction, int powerRating, List<string> keywords = null)
        {
            name_ = name;
            type_ = type;
            battlefieldRole_ = bfRole;
            faction_ = faction;
            expPoints_ = 0;
            powerRating_ = powerRating;
            crusadePoints_ = 0;
            keywords_ = keywords;
        }

        public string name() { return name_; }
        public string unitType() { return type_; }
        public int xp() { return expPoints_; }
        public int powerRating() { return powerRating_; }
        public int crusadePoints() { return crusadePoints_; }
        public string battleFieldRole() { return battlefieldRole_; }
        public string faction() { return faction_; }
        public List<string> keywords() { return keywords_;}
    }
}
