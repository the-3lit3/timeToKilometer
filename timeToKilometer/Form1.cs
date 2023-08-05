using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timeToKilometer
{
    public partial class frmConverter : Form
    {
        
        public frmConverter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hrs, mins;
            double kilos, totalMinutes;

            hrs = Convert.ToInt32(tbHrs.Text);
            mins = Convert.ToInt32(tbMins.Text);

            totalMinutes = (hrs * 60) + mins;
            kilos = (totalMinutes / 60) * 64;

            lblResult.Text = kilos.ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbHrs.Text = "";
            tbMins.Text = "";
            lblResult.Text = "";
        }

    }
}
