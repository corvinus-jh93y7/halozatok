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
            button1.Text = "\uE706";
            context.People.Load();
            personBindingSource.DataSource = context.People.Local;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewPersonForm npf = new NewPersonForm();
            if (npf.ShowDialog()==DialogResult.OK)
            {
                Person p = new Person();
                p.Name = npf.textBoxName.Text;
                p.Neptun = npf.textBoxNeptun.Text;
                p.Email = npf.textBoxEmail.Text;
                p.PersonalNumber = npf.textBoxSzemelyi.Text;
                p.TaxNumber = npf.textBoxAdo.Text;
                p.PhoneNumber = npf.textBoxTelo.Text;

                personBindingSource.Add(p);
                context.SaveChanges();
            }
        }
    }
}
