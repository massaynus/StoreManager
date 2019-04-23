using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Manager
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            System.Drawing.Point P = new Point(0 ,bunifuFlatButton1.Location.Y);
            panel3.Location = P;
            panel3.Visible = true;
            stock1.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            System.Drawing.Point P = new Point(0, bunifuFlatButton2.Location.Y);
            panel3.Location = P;
            panel3.Visible = true;
            stock1.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            System.Drawing.Point P = new Point(0, bunifuFlatButton3.Location.Y);
            panel3.Location = P;
            panel3.Visible = true;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            System.Drawing.Point P = new Point(0, bunifuFlatButton4.Location.Y);
            panel3.Location = P;
            panel3.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCircleProgressbar1.Value++;
            Color C = new Color();

            if (bunifuCircleProgressbar1.Value == 149)
            {
                C = bunifuCircleProgressbar1.ProgressBackColor;
                bunifuCircleProgressbar1.ProgressBackColor = bunifuCircleProgressbar1.ProgressColor;
                bunifuCircleProgressbar1.ProgressColor = C;
                bunifuCircleProgressbar1.Value = 1;
            }
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
