using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _40kListApp
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            this.Text = "Crusade Army Manager";
            InitializeComponent();
        }

        private void btn_newArmy_Click(object sender, EventArgs e)
        {
            Form_NewArmy FNA = new Form_NewArmy();
            FNA.Text = "New Army";
            FNA.Show();
            this.Hide(); //use Hide() for the main screen
        }

        private void btn_loadArmy_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "army files (*.army)|*.army";
            ofd.RestoreDirectory= true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fpath=ofd.FileName;
                FileManager fm = new FileManager();
                Army army = fm.loadArmy(fpath);

                Form_ArmyHome FAN = new Form_ArmyHome(army);
                FAN.Show();
                this.Hide();
            }
        }
    }
}
