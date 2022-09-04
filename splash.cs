using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Shop_Management_System
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int startp = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            startp += 1;
            Myprogress.Value = startp;
            PercentageLbl.Text = startp + "%";
            if (Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                loginfrm obj = new loginfrm();
                obj.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
