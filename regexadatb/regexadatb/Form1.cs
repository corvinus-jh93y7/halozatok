using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regexadatb
{
    public partial class Form1 : Form
    {

        Database1Entities context = new Database1Entities();
        public Form1()
        {
            InitializeComponent();
            context.People.Load();
            personBindingSource.DataSource = context.People.Local;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Name = "Joe";

            personBindingSource.Add(p);
            context.SaveChanges();
            
        }
    }
}
