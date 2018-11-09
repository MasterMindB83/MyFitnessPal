using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyFitnessPal
{
    public partial class Osnovna : Form
    {
        public Kalkulator kalkulator;
        public Namirnice namirnice;
        public Tezina tezina;
        public UneteKalorije uneteKalorije;
        public Osnovna()
        {
            InitializeComponent();
        }

        private void btn_tezina_Click(object sender, EventArgs e)
        {
            if (tezina == null || tezina.IsDisposed)
            {
                tezina = new Tezina();
                tezina.Show();
            }
            else
            {
                tezina.BringToFront();
            }
        }

        private void btn_namirnice_Click(object sender, EventArgs e)
        {
            if (namirnice == null || namirnice.IsDisposed)
            {
                namirnice = new Namirnice();
                namirnice.Show();
            }
            else
            {
                namirnice.BringToFront();
            }
        }

        private void btn_kalkulator_unetih_kalorija_Click(object sender, EventArgs e)
        {
            if (uneteKalorije == null || uneteKalorije.IsDisposed)
            {
                uneteKalorije = new UneteKalorije();
                uneteKalorije.Show();
            }
            else
            {
                uneteKalorije.BringToFront();
            }
        }

        private void Osnovna_Load(object sender, EventArgs e)
        {
            DataBase.init();
        }

        private void btn_kalkulator_Click(object sender, EventArgs e)
        {
            if (kalkulator == null || kalkulator.IsDisposed)
            {
                kalkulator = new Kalkulator();
                kalkulator.Show();
            }
            else
            {
                kalkulator.BringToFront();
            }
        }

        
    }
}
