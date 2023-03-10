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
    public partial class Form_NewArmy : Form
    {
        public Form_NewArmy()
        {
            InitializeComponent();
        }

        private void btn_nArmyCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_createArmy_Click(object sender, EventArgs e)
        {
            Army newArmy = new Army(tb_nArmyName.Text, tb_nArmyFaction.Text);

            Form_ArmyHome AH = new Form_ArmyHome(newArmy);
            AH.Show();
            Close();
        }
    }
}
