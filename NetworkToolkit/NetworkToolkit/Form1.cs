using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkToolkit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            speedConnection sp = new speedConnection();
            sp.Show();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            RTT rtt = new RTT();
            rtt.Show();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            maxHosts maxHosts = new maxHosts();
            maxHosts.Show();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            csma sc = new csma();
            sc.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Window window = new Window();
            window.Show();
        }
    }
}
