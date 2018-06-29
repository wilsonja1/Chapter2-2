using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(enableCheckBox.Checked == true)
            {
                if(label1.Text == "Right")
                {
                    label1.Text = "Left";
                    label1.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    label1.Text = "Right";
                    label1.TextAlign = ContentAlignment.MiddleRight;
                }
            }
            else
            {
                label1.Text = "Text changing is disabled";
                label1.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int c = 254; c>=0; c--)
            {
                this.BackColor = Color.FromArgb(c, 255 - c, c);
                Application.DoEvents();
            }

        }
    }
}
