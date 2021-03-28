using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webshop
{
    public partial class Form1 : Form
    {
        Database1Entities context = new Database1Entities();
        public Form1()
        {
            InitializeComponent();
            listBox1.DisplayMember = "NEV";
            listBox2.DisplayMember = "REND_DATUM";
            ugyfelszures();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ugyfelszures();
        }

        void ugyfelszures()
        {
            var ügyfelek = from x in context.Ugyfel
                           where x.NEV.Contains(textBox1.Text)
                           select x;
            listBox1.DataSource = ügyfelek.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var LOGIN = ((Ugyfel)listBox1.SelectedItem).LOGIN;
            var rendelések = from x in context.Rendeles where x.LOGIN == LOGIN select x;           
            listBox2.DataSource = rendelések.ToList();  
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var SORSZAM = ((Rendeles)listBox2.SelectedItem).SORSZAM;
            var rendelésiTételek = from x in context.Rendeles_tetel
                                   where x.SORSZAM == SORSZAM
                                   select new
                                   {
                                       Teméknév = x.Termek.MEGNEVEZES,
                                       Kategória = x.Termek.Termekkategoria.KAT_NEV,
                                       Egységár = (x.EGYSEGAR + " Ft"),
                                       Ár = x.MENNYISEG * x.EGYSEGAR + " Ft",
                                       Mennyiség = x.MENNYISEG,
                                       Mérték_egység = x.Termek.MEGYS,
                                   };


            dataGridView1.DataSource = rendelésiTételek.ToList();

            var osszeg = from x in context.Rendeles_tetel
                         where x.SORSZAM == SORSZAM
                         select new
                         {
                             ár_ft = x.MENNYISEG * x.EGYSEGAR,
                         };

            var teljes_osszeg = (from x in osszeg select x.ár_ft).Sum();
            label2.Text =teljes_osszeg.ToString() + " Ft";
        }

      
    }
}
