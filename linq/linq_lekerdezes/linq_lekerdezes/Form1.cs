using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq_lekerdezes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 uc1 = new UserControl1();
            panel1.Controls.Add(uc1);
            uc1.Dock = DockStyle.Fill;
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 uc2 = new UserControl2();            
            panel1.Controls.Add(uc2);
            uc2.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 uc3 = new UserControl3();            
            panel1.Controls.Add(uc3);
            uc3.Dock = DockStyle.Fill;
        }
    }
}
