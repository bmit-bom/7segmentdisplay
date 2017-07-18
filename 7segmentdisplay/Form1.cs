using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7segmentdisplay
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1 = ----CB-
            segA.BackColor = Color.Maroon;
            segB.BackColor = Color.Red;
            segC.BackColor = Color.Red;
            segD.BackColor = Color.Maroon;
            segE.BackColor = Color.Maroon;
            segF.BackColor = Color.Maroon;
            segG.BackColor = Color.Maroon;
            labelBinarySegments.Text = "0 0 0-0 1 1 0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 2 = G-ED-BA
            segA.BackColor = Color.Red;
            segB.BackColor = Color.Red;
            segC.BackColor = Color.Maroon;
            segD.BackColor = Color.Red;
            segE.BackColor = Color.Red;
            segF.BackColor = Color.Maroon;
            segG.BackColor = Color.Red;
            labelBinarySegments.Text = "1 0 1-1 0 1 1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 3 = G--DCBA
            segA.BackColor = Color.Red;
            segB.BackColor = Color.Red;
            segC.BackColor = Color.Red;
            segD.BackColor = Color.Red;
            segE.BackColor = Color.Maroon;
            segF.BackColor = Color.Maroon;
            segG.BackColor = Color.Red;
            labelBinarySegments.Text = "1 0 0-1 1 1 1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 4 = GF--CB-
            segA.BackColor = Color.Maroon;
            segB.BackColor = Color.Red;
            segC.BackColor = Color.Red;
            segD.BackColor = Color.Maroon;
            segE.BackColor = Color.Maroon;
            segF.BackColor = Color.Red;
            segG.BackColor = Color.Red;
            labelBinarySegments.Text = "1 1 0-0 1 1 0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 5 = GF-DC-A
            segA.BackColor = Color.Red;
            segB.BackColor = Color.Maroon;
            segC.BackColor = Color.Red;
            segD.BackColor = Color.Red;
            segE.BackColor = Color.Maroon;
            segF.BackColor = Color.Red;
            segG.BackColor = Color.Red;
            labelBinarySegments.Text = "1 1 0-1 1 0 1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 6 = GFEDC-A
            segA.BackColor = Color.Red;
            segB.BackColor = Color.Maroon;
            segC.BackColor = Color.Red;
            segD.BackColor = Color.Red;
            segE.BackColor = Color.Red;
            segF.BackColor = Color.Red;
            segG.BackColor = Color.Red;
            labelBinarySegments.Text = "1 1 1-1 1 0 1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 7 = ----CBA
            segA.BackColor = Color.Red;
            segB.BackColor = Color.Red;
            segC.BackColor = Color.Red;
            segD.BackColor = Color.Maroon;
            segE.BackColor = Color.Maroon;
            segF.BackColor = Color.Maroon;
            segG.BackColor = Color.Maroon;
            labelBinarySegments.Text = "0 0 0-0 1 1 1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // 8 = GFEDCBA
            segA.BackColor = Color.Red;
            segB.BackColor = Color.Red;
            segC.BackColor = Color.Red;
            segD.BackColor = Color.Red;
            segE.BackColor = Color.Red;
            segF.BackColor = Color.Red;
            segG.BackColor = Color.Red;
            labelBinarySegments.Text = "1 1 1-1 1 1 1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // 9 = GF-DCBA
            segA.BackColor = Color.Red;
            segB.BackColor = Color.Red;
            segC.BackColor = Color.Red;
            segD.BackColor = Color.Red;
            segE.BackColor = Color.Maroon;
            segF.BackColor = Color.Red;
            segG.BackColor = Color.Red;
            labelBinarySegments.Text = "1 1 0-1 1 1 1";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            // 0 = -FEDCBA
            segA.BackColor = Color.Red;
            segB.BackColor = Color.Red;
            segC.BackColor = Color.Red;
            segD.BackColor = Color.Red;
            segE.BackColor = Color.Red;
            segF.BackColor = Color.Red;
            segG.BackColor = Color.Maroon;
            labelBinarySegments.Text = "0 1 1-1 1 1 1";
        }

        private void buttonDotOn_Click(object sender, EventArgs e)
        {
            // switch dot state
            if (segDot.BackColor == Color.Maroon)
            {
                segDot.BackColor = Color.Red;
                labelBinaryDot.Text = "1";
            }
            else
            {
                segDot.BackColor = Color.Maroon;
                labelBinaryDot.Text = "0";
            }
        }

        private void buttonAllOff_Click(object sender, EventArgs e)
        {
            // All Off = -------
            segA.BackColor = Color.Maroon;
            segB.BackColor = Color.Maroon;
            segC.BackColor = Color.Maroon;
            segD.BackColor = Color.Maroon;
            segE.BackColor = Color.Maroon;
            segF.BackColor = Color.Maroon;
            segG.BackColor = Color.Maroon;
            segDot.BackColor = Color.Maroon;
            labelBinarySegments.Text = "0 0 0-0 0 0 0";
            labelBinaryDot.Text = "0";
        }
    }
}
