using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomkullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int s,s1,s2;
            s = rnd.Next(1,10);
            s1= rnd.Next(1,20);
            s2 = rnd.Next(1,30);
            label1.Text = s.ToString();
            label2.Text = s1.ToString();
            label3.Text = s2.ToString();
        }
    }
}
