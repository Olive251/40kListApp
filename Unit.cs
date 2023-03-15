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
        List<string> equipment_;
        List<string> psyPowers_;
        List<string> relics_;
        List<string> warlordTraits_;
        Helper helper = new Helper();

        public Unit()
        {
            expPoints_= 0;
            powerRating_= 0;
            crusadePoints_= 0;
        }

        public Unit(string name, string type, string bfRole, string faction, int powerRating, List<string> keywords = null, List<string> equipment = null, List<string> psyPowers = null)
        {
            name_ = name;
            type_ = type;
            battlefieldRole_ = bfRole;
            faction_ = faction;
            expPoints_ = 0;
            powerRating_ = powerRating;
            crusadePoints_ = 0;
            keywords_ = keywords;
            equipment_ = equipment;
            psyPowers_ = psyPowers;
        }

        public Unit(string unitRecord)
        {
            List<string> recordTokens = helper.parseDelimLine(unitRecord, '|');

            string name = recordTokens[0];
            string type = recordTokens[1];
            string bfRole = recordTokens[2];
            string faction = recordTokens[3];
            int expPoints = Int32.Parse(recordTokens[4]);
            int powerRating = Int32.Parse(recordTokens[5]);
            int crusadePoints = Int32.Parse(recordTokens[6]);
            string dirty_keywords = recordTokens[7];
            string dirty_equipment = recordTokens[8];
            string dirty_psyPowers = recordTokens[9];
            string dirty_relics = recordTokens[10];
            string dirty_traits = recordTokens[11];

            List<string> keywords = helper.parseDelimLine(dirty_keywords, ',');
            List<string> equipment = helper.parseDelimLine(dirty_equipment, ',');
            List<string> psyPowers = helper.parseDelimLine(dirty_psyPowers, ',');
            List<string> relics = helper.parseDelimLine(dirty_relics, ',');
            List<string> warlordTraits = helper.parseDelimLine(dirty_traits, ',');

            name_ = name;
            type_ = type;
            battlefieldRole_ = bfRole;
            faction_= faction;
            expPoints_ = expPoints;
            powerRating_ = powerRating;
            crusadePoints_ = crusadePoints;
            keywords_ = keywords;
            equipment_ = equipment;
            psyPowers_ = psyPowers;
            relics_ = relics;
            warlordTraits_= warlordTraits;
        }

        public string writeUnitLine()
        {
            string line = string.Empty;

            line += name_ + "|";
            line += type_ + "|";
            line += battlefieldRole_ + "|";
            line += faction_ + "|";
            line += expPoints_ + "|";
            line += powerRating_ + "|";
            line += crusadePoints_ + "|";

            foreach (string keyword in keywords_)
            {
                line += keyword + ",";
            }
            line += "|";

            foreach (string equipment in equipment_)
            {
                line += equipment + ",";
            }
            line += "|";

            foreach (string power in psyPowers_)
            {
                line += power + ",";
            }
            line += "|";

            foreach (string relic in relics_)
            {
                line += relic + ",";
            }
            line += "|";

            foreach (string trait in warlordTraits_)
            {
                line += trait + ",";
            }
            line += "|";

            return line;
        }

        public string name() { return name_; }
        public string unitType() { return type_; }
        public int xp() { return expPoints_; }
        public int powerRating() { return powerRating_; }
        public int crusadePoints() { return crusadePoints_; }
        public string battleFieldRole() { return battlefieldRole_; }
        public string faction() { return faction_; }
        public List<string> keywords() { return keywords_;}
        public List<string> equipment() { return equipment_; }
    }
}
