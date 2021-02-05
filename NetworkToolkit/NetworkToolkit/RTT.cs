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

    
    public partial class RTT : Form
    { 
        private double srtt= 0.0;
        public RTT()
        {
            InitializeComponent();
            
        }

        private void rttBtnCalc_Click(object sender, EventArgs e)
        {

            calculateSrtt();
            
        }

        /**
         * Calculates new RTT using boxes values
         * After that srtt will be 0 again.
         */
        public void calculateSrtt()
        {
            srtt = Convert.ToDouble(aValue.Text) * Convert.ToDouble(thatTimeBox.Text)
                + (1 - Convert.ToDouble(aValue.Text)) * Convert.ToDouble(nextConfirmBox.Text);


            //result to resultLabel
            resultLabel.Text = "Η νέα εκτίμηση για το RTT: "+srtt.ToString() +" msec";

            srtt = 0;

        }


        /**
         * To clean boxes, result label after calculation 
         */ 
        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();

        }


        public void clear()
        {
            nextConfirmBox.Text = "";
            thatTimeBox.Text = "";
            aValue.Text = "";
            resultLabel.Text = "";
        }
    }
}
