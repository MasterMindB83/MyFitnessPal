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
    public partial class TezinaUnos : Form
    {
        public String Datum = "";
        public String Tezina = "";
        public TezinaUnos()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Datum = txt_datum.Text;
            Tezina = txt_tezina.Text;
            Close();
        }

        private void TezinaUnoscs_Load(object sender, EventArgs e)
        {
            DateTime date=DateTime.Now;

            txt_datum.Text = date.Date.ToString("dd.MM.yyyy");
        }
    }
}
