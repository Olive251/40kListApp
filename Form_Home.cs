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
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }

        private void btn_newArmy_Click(object sender, EventArgs e)
        {
            Form_NewArmy FNA = new Form_NewArmy();
            FNA.Show();
            this.Hide(); //use Hide() for the main screen
        }
    }
}
