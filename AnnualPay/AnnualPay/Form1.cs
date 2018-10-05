using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnnualPay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Declare integer variables
            int hoursperweek;
            int weeksperyear;
            decimal hourlypayrate;
            decimal annualpay;
            // Parse input methods
            hoursperweek = int.Parse(hoursWorkedText.Text);
            weeksperyear = int.Parse(weeksWorkedText.Text);
            hourlypayrate = decimal.Parse(dollarsPerHourText.Text);
            // Calculate annual pay
            annualpay = hoursperweek * hourlypayrate * (weeksperyear);
            totalLabel.Text = annualpay.ToString("c");

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hoursWorkedText.Text = "";
            weeksWorkedText.Text = "";
            dollarsPerHourText.Text = "";
            totalLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}