using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CM_Mill_Calculator
{
    public partial class CMMillCalculator : Form
    {
        public CMMillCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double conversion = 1.0;
            double distance = 0.0;
            double dstperturn = 0.0;
            double angle = 0.0;
            double radangle = 0.0;
            double x, y;
            double xturns, xremainder, yturns, yremainder;

            try
            {
                distance = Convert.ToDouble(txtDistance.Text);
            }
            catch { return; }

            try
            {
               dstperturn = Convert.ToDouble(txtDstTurn.Text);
            }
            catch { return; }

            try
            {
                angle = Convert.ToDouble(txtAngle.Text);
                radangle = Math.PI * angle / 180.0;
            }
            catch { return; }

            if (rbInches.Checked == true)
                conversion = 1.0;
            else
                conversion = 0.03937;

            distance *= conversion; // Convert if metric

            x = distance * Math.Sin(radangle);
            y = distance * Math.Cos(radangle);

            xturns = Math.Truncate(x / dstperturn);
            xremainder = Math.Round(((x / dstperturn) - xturns) * dstperturn * 1000,0);

            yturns = Math.Truncate(y / dstperturn);
            yremainder = Math.Round(((y / dstperturn) - yturns) * dstperturn * 1000,0);

            txtXLW.Text = Math.Abs(xturns).ToString() + "T + " + Math.Abs(xremainder).ToString();
            txtYFW.Text = Math.Abs(yturns).ToString() + "T + " + Math.Abs(yremainder).ToString();
            txtXRW.Text = txtXLW.Text;

            if (xturns > 0 || xremainder > 0)
            {
                lblXLD.Text = "CCW";
                lblXRD.Text = "CW";
            }
            else
            {
                lblXLD.Text = "CW";
                lblXRD.Text = "CCW";
            }

            if (yturns > 0 || yremainder > 0)
            {
                lblYFD.Text = "CCW";
            }
            else
            {
                lblYFD.Text = "CW";
            }
        }

        private void rbBack_CheckedChanged(object sender, EventArgs e)
        {
            txtAngle.Text = "0.0";
        }

        private void rbRight_CheckedChanged(object sender, EventArgs e)
        {
            txtAngle.Text = "90.0";
        }

        private void rbFront_CheckedChanged(object sender, EventArgs e)
        {
            txtAngle.Text = "180.0";
        }

        private void rbLeft_CheckedChanged(object sender, EventArgs e)
        {
            txtAngle.Text = "270.0";
        }

        private void rbAngle_CheckedChanged(object sender, EventArgs e)
        {
            txtAngle.Text = "0.0";
        }
    }
}
