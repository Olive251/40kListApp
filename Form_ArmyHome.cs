using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _40kListApp
{
    public partial class Form_ArmyHome : Form
    {
        internal Army army_;
        static FileManager fileManager = new FileManager();
        static Helper helper = new Helper();

        public Form_ArmyHome()
        {
            InitializeComponent();
        }

        public Form_ArmyHome(Army army)
        {
            army_ = army;
            this.Text = army_.name();
            InitializeComponent();
            loadScreen();
        }

        public void loadScreen()
        {
            lbl_armyName.Text = army_.name();
            lbl_armyFaction.Text = army_.faction();
            num_battleTally.Value = army_.battleTally();
            num_winTally.Value = army_.winTally();
            num_RP.Value = army_.reqPoints();
            num_supplyLimit.Value = army_.supplyLimit();
            lbl_supplyUsed.Text = army_.supplyUsed().ToString();

            foreach (Unit unit in army_.units())
            {
                lb_cards.Items.Add(unit.name());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_NewUnit nu = new Form_NewUnit(this);
            nu.Text = "New Unit | " + army_.name();
            nu.ShowDialog();
        }

        private void lb_cards_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selection = lb_cards.SelectedIndex;
            Unit u = army_.unit(selection);

            //unit table 1
            lbl_unitName.Text = u.name();
            lbl_unitName.Visible = true;
            lbl_unitRole.Text = u.battleFieldRole();
            lbl_unitRole.Visible = true;
            lbl_unitFaction.Text = u.faction();
            lbl_unitFaction.Visible = true;

            //unit keywords
            List<string> uKeywords = u.keywords();
            lbl_unitKeywords.Text = "";
            foreach (string keyword in uKeywords)
            {
                lbl_unitKeywords.Text += keyword + ", ";
            }
            lbl_unitKeywords.Visible = true;

            //unit table 2
            lbl_unitType.Text = u.unitType();
            lbl_unitType.Visible = true;
            //equipment
            lbl_unitEquipment.Text = "";
            foreach (string equipment in u.equipment())
            {
                lbl_unitEquipment.Text += equipment + ", ";
            }
            lbl_unitEquipment.Visible = true;

            lbl_unitPsyPowers.Text = u.psyPowers();
            lbl_unitPsyPowers.Visible = true;
            lbl_unitWarlordTraits.Text = u.warlordTraits();
            lbl_unitWarlordTraits.Visible = true;
            lbl_unitRelics.Text = u.relics();
            lbl_unitRelics.Visible = true;

            //unit table 3
            lbl_unitPR.Text = u.powerRating().ToString();
            lbl_unitPR.Visible = true;
            lbl_unitXP.Text = u.xp().ToString();
            lbl_unitXP.Visible = true;
            lbl_unitCP.Text = u.crusadePoints().ToString();
            lbl_unitCP.Visible = true;
        }

        private void btn_saveArmy_Click(object sender, EventArgs e)
        {
            //open save army screen
            //user selects a file path to save the army too
            //save the file

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Environment.CurrentDirectory;
            sfd.RestoreDirectory = true;
            sfd.FileName = "*.army";
            sfd.DefaultExt = "army";
            sfd.Filter = "army files (*.army)|*.army";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream fStream = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(fStream);
                fileManager.saveArmy(army_, sw);
            }
        }

        private void btn_editUnit_Click(object sender, EventArgs e)
        {

        }
    }
}
