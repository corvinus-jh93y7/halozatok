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
            context.Instructors.Load();
            dataGridView1.DataSource = context.Instructors.Local;
        }
    }
}
