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
            segA.BackColor = Color.Silver;
            segB.BackColor = Color.Red;
            segC.BackColor = Color.Red;
            segD.BackColor = Color.Silver;
            segE.BackColor = Color.Silver;
            segF.BackColor = Color.Silver;
            segG.BackColor = Color.Silver;
            labelBinarySegments.Text = "0 0 0-0 1 1 0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 2 = G-ED-BA
            segA.BackColor = Color.Red;
            segB.BackColor = Color.Red;
            segC.BackColor = Color.Silver;
            segD.BackColor = Color.Red;
            segE.BackColor = Color.Red;
            segF.BackColor = Color.Silver;
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
            segE.BackColor = Color.Silver;
            segF.BackColor = Color.Silver;
            segG.BackColor = Color.Red;
            labelBinarySegments.Text = "1 0 0-1 1 1 1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 4 = GF--CB-
            segA.BackColor = Color.Silver;
            segB.BackColor = Color.Red;
            segC.BackColor = Color.Red;
            segD.BackColor = Color.Silver;
            segE.BackColor = Color.Silver;
            segF.BackColor = Color.Red;
            segG.BackColor = Color.Red;
            labelBinarySegments.Text = "1 1 0-0 1 1 0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 5 = GF-DC-A
            segA.BackColor = Color.Red;
            segB.BackColor = Color.Silver;
            segC.BackColor = Color.Red;
            segD.BackColor = Color.Red;
            segE.BackColor = Color.Silver;
            segF.BackColor = Color.Red;
            segG.BackColor = Color.Red;
            labelBinarySegments.Text = "1 1 0-1 1 0 1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 6 = GFEDC-A
            segA.BackColor = Color.Red;
            segB.BackColor = Color.Silver;
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
            segD.BackColor = Color.Silver;
            segE.BackColor = Color.Silver;
            segF.BackColor = Color.Silver;
            segG.BackColor = Color.Silver;
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
            segE.BackColor = Color.Silver;
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
            segG.BackColor = Color.Silver;
            labelBinarySegments.Text = "0 1 1-1 1 1 1";
        }

        private void buttonDotOn_Click(object sender, EventArgs e)
        {
            // Turn on dot
            segDot.BackColor = Color.Red;
            labelBinaryDot.Text = "1";
        }

        private void buttonAllOff_Click(object sender, EventArgs e)
        {
            // All Off = -------
            segA.BackColor = Color.Silver;
            segB.BackColor = Color.Silver;
            segC.BackColor = Color.Silver;
            segD.BackColor = Color.Silver;
            segE.BackColor = Color.Silver;
            segF.BackColor = Color.Silver;
            segG.BackColor = Color.Silver;
            segDot.BackColor = Color.Silver;
            labelBinarySegments.Text = "0 0 0-0 0 0 0";
            labelBinaryDot.Text = "0";
        }
    }
}
