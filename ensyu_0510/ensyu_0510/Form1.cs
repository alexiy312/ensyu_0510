using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ensyu_0510
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.Text = "(●｀･ω･)ゞ＜ok！";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Size = new Size(2, 2);
            button2.Location = new Point(1, 1);
            MessageBox.Show("どこにいるでしょうか？");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Orange;
            button3.Text = "オレンジ";
        }
    }
}
