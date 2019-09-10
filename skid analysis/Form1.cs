using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace skid_analysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.tyretype.SelectedIndex = 0;
            this.tyrecond.SelectedIndex = 0;
            this.vehicletype.SelectedIndex = 1;
            this.skidsbackfront.SelectedIndex = 0;
            this.skidsequal.SelectedIndex = 0;
            this.roadcover.SelectedIndex = 0;
            this.roadslope.SelectedIndex = 0;
            this.roadsurface.SelectedIndex = 0;
        }

        int [] weight = new int[]{805, 1248, 1295, 1500, 775, 1800, 4572, 14560};
        double[] area = new double[]{1.83, 2.19, 2.28, 3.68, 2.53, 4.38, 8.19, 10.95};
        double[] surfaces = new double[]{0.55, 0.5, 0.4, 0.25, 0.1};

        private double calcSurfaceDrag(int surfacetype, int vehicle, bool worn)
        {
            double surface = 0;
            int percent = vehicle < 6 ? 5 : 10;
            surface = surfaces[surfacetype] + ((surfaces[surfacetype] + (vehicle * percent)) / 100);
            if (worn == true)
                surface = surface - ((surface + 5) / 100);
            switch (roadcover.SelectedIndex)
            {
                case 0: // dry
                    break;
                case 1: // damp - lose 10% traction
                    surface = surface - ((surface + 10) / 100);
                    break;
                case 2: // wet - lose 20% traction
                    surface = surface - ((surface + 20) / 100);
                    break;
                case 3: // loose snow
                    surface = surfaces[surfacetype] + ((surfaces[3] + (vehicle * percent)) / 100);
                    break;
                case 4:
                case 5:
                    surface = surfaces[surfacetype] + ((surfaces[4] + (vehicle * percent)) / 100);
                    break;
            }
            return surface;
        }

        private double calcTyreEffect(int tyresize, int tyrecond, double currentSurface)
        {
            double newSurface = currentSurface;
            if (tyresize != 0 || tyrecond != 0)
            {
                if (tyrecond != 0)
                    newSurface = newSurface - ((newSurface + (tyrecond * 10)) / 100);
                if (tyresize == 1)
                    newSurface = newSurface - ((newSurface + 1) / 100);
                if (tyresize == 2)
                    newSurface = newSurface + ((newSurface + 1) / 100);
            }
            return newSurface;
        }

        private double calcForceDrag(int vehicle, double speed)
        {
            return 0.5 * (9.8 * (speed * speed) * area[vehicle] * calcDrag());
        }

        private double calcDrag()
        {
            double cd = 0;
            int surfacetype = 0;
            surfacetype = roadsurface.SelectedIndex;
            cd = calcTyreEffect(tyretype.SelectedIndex, tyrecond.SelectedIndex, calcSurfaceDrag(surfacetype, vehicletype.SelectedIndex, surfaceworn.Checked));
            return cd;
        }

        private double equivSpeed()
        {
            double skidf = Convert.ToDouble(skidfront.Text), brakeeff = skidsequal.SelectedIndex == 0 ? 100 : 60;
            double grad = Convert.ToDouble(slopegrad.Text);
            double equiv = Math.Sqrt(30 * skidf * (calcCoeffSlide() * (brakeeff / 100) + (grad / 100)));
            return equiv;
        }

        private double calcDragFactor()
        {
            int n = skidsequal.SelectedIndex == 0 ? 100 : 60;
            double drag = calcDrag() * n * Convert.ToInt32(slopegrad.Text);
            return drag;
        }

        private double calcCoeffSlide() // coefficient of friction 
        {
            //return 0.79;
            return calcDrag() - (calcDrag() * ((roadcover.SelectedIndex == 0 ? 25 : 50) / 100));
        }

        private double calcShortNonSkid()
        {
            double grad = Convert.ToDouble(slopegrad.Text) == 0 ? 0 : Convert.ToDouble(slopegrad.Text);
            double denom = 0.75 - (0.3 * roadcover.SelectedIndex == 0 ? 0 : 1) + (grad/100);
            double coeffsl = calcCoeffSlide(), bigcosl = coeffsl + (coeffsl * 25 / 100);
            denom = 30 * (bigcosl / denom);
            double skid = Math.Pow(Convert.ToDouble(collisionspeed.Text), 2) / denom;
            return skid;
        }

        private double minBrakeSpeed()
        {
            double col = Convert.ToDouble(collisionspeed.Text), equ = equivSpeed();
            double speeds = Math.Sqrt(Math.Pow(col, 2) + (Math.Pow(equ, 2)));
            double tst = 32.2 * calcCoeffSlide() * 0.15;
            tst /= 2;
            double res = speeds + tst;
            return res;    
        }

        private double stoppingDistance()
        {
            int n = skidsequal.SelectedIndex == 0 ? 100 : 60;
            double s = minBrakeSpeed();
            /*double dist = Convert.ToDouble(skidfront.Text);
            if (distinm.Checked == true)
                dist *= 3.2808399; // convert to feet
            dist = -dist;*/
            double drag = calcDrag();
            double a = Math.Pow(s, 2) / (30 * (drag * (n / 100) + (Convert.ToDouble(slopegrad.Text) / 100)));
            return a;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutThis ab = new AboutThis();
            ab.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void skidsequal_SelectedIndexChanged(object sender, EventArgs e)
        {
            skidsbackfront.Enabled = skidsequal.SelectedIndex == 0 ? false : true;
            label5.Enabled = skidsbackfront.Enabled;
            skidback.Enabled = skidsbackfront.Enabled ;
            label9.Enabled = skidback.Enabled;
        }

        private void skidsbackfront_SelectedIndexChanged(object sender, EventArgs e)
        {
            brakelgr.Enabled = skidsbackfront.SelectedIndex == 0 ? false : true;
            brakergl.Enabled = brakelgr.Enabled;
        }

        private void roadslope_SelectedIndexChanged(object sender, EventArgs e)
        {
            slopegrad.Enabled = roadslope.SelectedIndex != 0 ? true : false;
            slopelbl.Enabled = slopegrad.Enabled;
        }

        private void longwheel_CheckedChanged(object sender, EventArgs e)
        {
            weight[5] = longwheel.Checked == true ? 3500 : 1800;
        }

        private void vehicletype_SelectedIndexChanged(object sender, EventArgs e)
        {
            longwheel.Enabled = vehicletype.SelectedIndex == 6 ? true : false;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (collisionspeed.Text == "")
            {
                MessageBox.Show("You have not entered a collision speed", "Skid Analysis", MessageBoxButtons.OK);
                return;
            }

            if (skidfront.Text == "")
            {
                MessageBox.Show("You have not entered the measured front skid length", "Skid Analysis", MessageBoxButtons.OK);
                return;
            }

            if (skidback.Text == "" && skidback.Enabled == true)
            {
                MessageBox.Show("You have not entered the measured rear skid length", "Skid Analysis", MessageBoxButtons.OK);
                return;
            }

            if (slopegrad.Text == "")
                slopegrad.Text = "0";

            distance.Text = String.Format("{0:0.####}", calcShortNonSkid());
            distunit.Text = distinm.Checked == false ? "ft away" : "m away";
            minspeedbrake.Text = string.Format("{0:0.####}", minBrakeSpeed());
            speedunit.Text = ismph.Checked == true ? "m.p.h" : "km.p.h";
            equiv.Text = string.Format("{0:0.####}", equivSpeed());
            theorystop.Text = string.Format("{0:0.####}", stoppingDistance());
            theoryunit.Text = distinm.Checked == false ? "ft away" : "m away";
        }
    }

    class NumberBox : TextBox
    {
        public NumberBox()
        {
            this.CausesValidation = true;
            this.Validating += new CancelEventHandler(TextBox_Validation);
        }

        private void TextBox_Validation(object sender, CancelEventArgs e)
        {
            try
            {
                double value = System.Double.Parse(this.Text);
            }
            catch (System.Exception)
            {
                e.Cancel = true;
            }
        }
    }
}
