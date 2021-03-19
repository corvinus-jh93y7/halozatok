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
    public partial class UserControl2 : UserControl
    {
        StudiesEntities context = new StudiesEntities();
        public UserControl2()
        {
            InitializeComponent();
            SzűrésKurzusra();
        }
        private void SzűrésKurzusra()
        {
            var er = from x in context.Courses
                     where x.Name.Contains(textBox1.Text)
                     orderby x.Name
                     select x;
            listBox1.DataSource = er.ToList();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SzűrésKurzusra();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course kurzus = (Course)listBox1.SelectedItem;
            var kurzustartalma = from x in context.Lessons
                             where x.CourseFK == kurzus.CourseSK
                             select new
                             {
                                 Nap = x.Day.Name,
                                 Sáv = x.Time.Name,
                                 Oktato= x.Instructor.Name
                             };


            dataGridView1.DataSource = kurzustartalma.ToList();
        }
    }
}
