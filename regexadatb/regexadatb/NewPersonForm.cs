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

namespace regexadatb
{
    public partial class NewPersonForm : Form
    {
        public NewPersonForm()
        {
            InitializeComponent();
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxName, "Nem lehet üres");
            }
        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxName, "");
        }

     

        private void textBoxNeptun_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"^[A-Z0-9]{6}$");
            if (!r.IsMatch(textBoxNeptun.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxNeptun, "Nem megfelelő formátum");
            }
        }

        private void textBoxNeptun_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxNeptun, "");
        }



        private void textBoxSzemelyi_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"(^[A-Z]{2}-?[0-9]{6}$)|(^[0-9]{6}-?[A-Z]{2}$)");
            if (!r.IsMatch(textBoxSzemelyi.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxSzemelyi, "Nem megfelelő formátum");
            }
        }



        private void textBoxSzemelyi_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxSzemelyi, "");
        }

        private void textBoxAdo_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"^[0-9]{8}-[0-9]-[0-9]{2}$$");
            if (!r.IsMatch(textBoxAdo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxAdo, "Nem megfelelő formátum");
            }
        }

        private void textBoxAdo_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxAdo, "");
        }

        private void textBoxTelo_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"^(\+36|06)(-|/)[0-9]{1,2}-[0-9]{3}-?[0-9]{3,4}$");
            if (!r.IsMatch(textBoxTelo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxTelo, "Nem megfelelő formátum");
            }
        }

        private void textBoxTelo_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxTelo, "");
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"(^$)|(^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$)");
            if (!r.IsMatch(textBoxEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxEmail, "Nem megfelelő formátum");
            }
        }

        private void textBoxEmail_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxEmail, "");
        }
    }
}
