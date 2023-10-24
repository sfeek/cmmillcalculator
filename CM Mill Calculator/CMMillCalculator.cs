using CM_Mill_Calculator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

            if (Properties.Settings.Default.inmm == 0)
            {
                rbInches.Checked = true;
                rbMM.Checked = false;
            }
            else
            {
                rbInches.Checked = false;
                rbMM.Checked = true;
            }    
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double conversion;
            double distance;
            double xdstperturn;
            double ydstperturn;
            double angle;
            double radangle;
            double x, y;
            double xturns, xremainder, yturns, yremainder;
            double xdt, ydt;

            try
            {
                distance = Convert.ToDouble(txtDistance.Text);
            }
            catch { return; }

            try
            {
               xdstperturn = Convert.ToDouble(txtXDstTurn.Text);
            }
            catch { return; }

            try
            {
                ydstperturn = Convert.ToDouble(txtYDstTurn.Text);
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

            xdt = Math.Round(xdstperturn * 1000);
            ydt = Math.Round(ydstperturn * 1000);

            distance *= conversion; // Convert if metric

            x = distance * Math.Sin(radangle);
            y = distance * Math.Cos(radangle);

            xturns = Math.Truncate(x / xdstperturn);
            xremainder = Math.Round(((x / xdstperturn) - xturns) * xdstperturn * 1000, 0);

            yturns = Math.Truncate(y / ydstperturn);
            yremainder = Math.Round(((y / ydstperturn) - yturns) * ydstperturn * 1000,0);

            if (xturns > 0 || xremainder > 0)
            {
                lblXLD.Text = "CCW";
                lblXRD.Text = "CW";

                xremainder = Math.Abs(xremainder);

                if (xremainder == 0.0)
                {
                    txtXRW.Text = Math.Abs(xturns).ToString() + "T";
                    txtXLW.Text = Math.Abs(xturns).ToString() + "T";

                }
                else
                {
                    txtXRW.Text = Math.Abs(xturns).ToString() + "T + " + xremainder.ToString();
                    txtXLW.Text = Math.Abs(xturns).ToString() + "T - " + (xdt - xremainder).ToString();
                }
            }
            else
            {
                lblXLD.Text = "CW";
                lblXRD.Text = "CCW";

                xremainder = Math.Abs(xremainder);

                if (xremainder == 0.0)
                {
                    txtXRW.Text = Math.Abs(xturns).ToString() + "T";
                    txtXLW.Text = Math.Abs(xturns).ToString() + "T";
                }
                else
                {
                    txtXRW.Text = Math.Abs(xturns).ToString() + "T - " + (xdt - xremainder).ToString();
                    txtXLW.Text = Math.Abs(xturns).ToString() + "T + " + xremainder.ToString();
                }
            }

            if (yturns > 0 || yremainder > 0)
            {
                lblYFD.Text = "CCW";

                yremainder = Math.Abs(yremainder);

                if (yremainder == 0.0)
                {
                    txtYFW.Text = Math.Abs(yturns).ToString() + "T";
                }
                else
                {
                    txtYFW.Text = Math.Abs(yturns).ToString() + "T - " + (ydt - yremainder).ToString();
                }
            }
            else
            {
                lblYFD.Text = "CW";

                yremainder = Math.Abs(yremainder);

                if (yremainder == 0.0)
                {
                    txtYFW.Text = Math.Abs(yturns).ToString() + "T";
                }
                else
                {
                    txtYFW.Text = Math.Abs(yturns).ToString() + "T + " + yremainder.ToString();
                }
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

        private void btnWCalculate_Click(object sender, EventArgs e)
        {
            double wThousandths;
            int wTurns;
            double conversion;
            double xdistPerTurn;
            double ydistPerTurn;
            double tDistance;

            txtWDistance.Text = String.Empty;

            try
            {
                xdistPerTurn = Convert.ToDouble(txtXDstTurn.Text);
                ydistPerTurn = Convert.ToDouble(txtYDstTurn.Text);

                if (rbInches.Checked == true)
                    conversion = 1.0;
                else
                    conversion = 0.03937;

                wTurns = Convert.ToInt32(txtWTurns.Text);
                wThousandths = Convert.ToDouble(txtWThousandths.Text) / 1000;

                if (rbXAxis.Checked == true)
                    tDistance = (wTurns * xdistPerTurn + wThousandths) / conversion;
                else
                    tDistance = (wTurns * ydistPerTurn + wThousandths) / conversion;

                txtWDistance.Text = Math.Round(tDistance, 4).ToString();
            }
            catch { return; }
        }
        private void CMMillCalculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (rbInches.Checked == true) 
                Properties.Settings.Default.inmm = 0; 
            else
                Properties.Settings.Default.inmm = 1;

            Settings.Default.Save();
        }
    }
}
