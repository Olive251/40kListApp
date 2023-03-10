using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _40kListApp
{
    public partial class Form_NewUnit : Form
    {
        Form_ArmyHome armyHome_;
        Helper helper = new Helper();

        public Form_NewUnit(Form_ArmyHome armyHome)
        {
            this.armyHome_ = armyHome;
            InitializeComponent();
        }

        private void btn_addUnit_Click(object sender, EventArgs e)
        {
            List<string> keywords = helper.parseDelimLine(tb_keywords.Text, ',');

            Unit newUnit = 
                new Unit(tb_unitName.Text, tb_unitType.Text, cb_battlefieldRole.Text, tb_faction.Text, Int32.Parse(tb_powerRating.Text), keywords);

            armyHome_.army_.addUnit(newUnit);
            armyHome_.loadScreen();
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
