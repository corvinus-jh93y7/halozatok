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

namespace linq_lekerdezes
{
    public partial class UserControl1 : UserControl
    {

        StudiesEntities context = new StudiesEntities();
        public UserControl1()
        {
            InitializeComponent();
            // context.Instructors.Load();
            // dataGridView1.DataSource = context.Instructors.Local;



            //FROM, WHERE, GROUP BY, HAVING, ORDER BY
            // var er1 = from x in context.Instructors
            // where x.Salutation=="Dr."
            // select x;

            //    orderby x.Name
            //    select new {Név= x.Name, x.Salutation };


            //    dataGridView1.DataSource = er1.ToList(); 


            SzűrésNévre();

        }



        private void SzűrésNévre()
        {
            var er = from x in context.Instructors
                     where x.Name.Contains(textBox1.Text)
                     orderby x.Name
                     select x;
            listBox1.DataSource = er.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SzűrésNévre();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instructor oktato = (Instructor) listBox1.SelectedItem;

            var oktatóÓrái = from x in context.Lessons
                             where x.InstructorFK == oktato.InstructorSK
                             select new {
                                 Nap=x.Day.Name,
                                 Sáv=x.Time.Name,
                                 Terem=x.Room.Name, 
                                 Kurzus=x.Course.Name
                             };


            dataGridView1.DataSource = oktatóÓrái.ToList(); 
            


        }
    }
}
