using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regularis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxText_TextChanged(object sender, EventArgs e)
        {
            DoCheck();
        }

        private void textBoxRegEx_TextChanged(object sender, EventArgs e)
        {
            DoCheck();
        }

        void DoCheck()
        {
            try
            {
                Regex regex = new Regex(textBoxRegEx.Text);
                if (regex.IsMatch(textBoxText.Text))
                {
                    textBoxText.BackColor = Color.LightGreen;
                }
                else
                {
                    textBoxText.BackColor = Color.LightCoral;
                }
            }
            catch (Exception)
            {
                textBoxRegEx.BackColor = Color.LightCoral;
                return;
            }
            textBoxRegEx.BackColor = Color.LightGreen;
        }
    }
}
