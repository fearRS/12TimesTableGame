using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12TimesTableGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            GetRandomArray getRandomList = new GetRandomArray();
            int[] nums = getRandomList.AssignSidesAndTop();
            InitializeComponent();
            string[] sides = new string[] { side1.Text, side2.Text, side3.Text, side4.Text, side5.Text, side6.Text, side7.Text, side8.Text, side9.Text, side10.Text, side11.Text, side12.Text };
            string[] top = new string[] { top1.Text, top2.Text, top3.Text, top4.Text, top5.Text, top6.Text, top7.Text, top8.Text, top9.Text, top10.Text, top11.Text, top12.Text };
            int b = 0;
            int c = 0;
            foreach (string a in sides)
            {
                sides[b] = nums[b].ToString();
                b++;
            }
            foreach (string a in top)
            {
                sides[c] = nums[c].ToString();
                c++;
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
