using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6_4
{
    public partial class Form1 : Form
    {
        int[] openNum = new int[6];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Array.Clear(openNum, 0, 6);
            MakeRnd mkrnd = new MakeRnd();
            mkrnd.GetRnd(openNum);
            
            for (int i = 1; i <= openNum.Length; i++)
            {
                Controls.Find("label"+i, false)[0].Text = Convert.ToString(openNum[i - 1]);
            }

            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Sort(openNum);

            for (int i = 1; i <= openNum.Length; i++)
            {
                Controls.Find("label" + i, false)[0].Text = Convert.ToString(openNum[i - 1]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= openNum.Length; i++)
            {
                Controls.Find("label" + i, false)[0].Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
