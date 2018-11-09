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
    public partial class Kalkulator : Form
    {
        public double nBmr = 0;
        public Kalkulator()
        {
            InitializeComponent();
        }
        //procedure
        public void IzracunajBMR()
        {
            if (txt_pol.SelectedValue=="1")//muskarci
            {
                nBmr = 66.47 + (13.75 * double.Parse(txt_tezina.Text)) + (5 * double.Parse(txt_visina.Text)) - (6.76 * double.Parse(txt_starost.Text));
                
                
                
                txt_bmr.Text= Math.Round(nBmr).ToString();
            }
            else//zene
            {
                nBmr = 655.1 + (9.56 * double.Parse(txt_tezina.Text)) + (1.85 * double.Parse(txt_visina.Text)) - (4.68 * double.Parse(txt_starost.Text));


                txt_bmr.Text = Math.Round(nBmr).ToString();
            }
            /*if (spol == 1)
            {
                meta.rezultat.value = Math.round(66.47 + (13.75 * tez) + (5 * vis) - (6.76 * sta));
            }


            if (spol == 2)
            {
                meta.rezultat.value = Math.round(655.1 + (9.56 * tez) + (1.85 * vis) - (4.68 * sta));
            }*/
        }

        public void IzracunajTDEE()
        {
            /*if (document.form4.flevel[0].checked == true) {
             document.form4.TDEErate.value=Math.round(bmr*1.2);
             }
             if (document.form4.flevel[1].checked == true) {
             document.form4.TDEErate.value=Math.round(bmr*1.375);
             }
             if (document.form4.flevel[2].checked == true) {
             document.form4.TDEErate.value=Math.round(bmr*1.55);
             }
             if (document.form4.flevel[3].checked == true) {
             document.form4.TDEErate.value=Math.round(bmr*1.725);
             }
             if (document.form4.flevel[4].checked == true) {
             document.form4.TDEErate.value=Math.round(bmr*1.9);*/
            if (rad_1.Checked)
            {
                txt_tdee.Text = Math.Round(nBmr * 1.2).ToString();
            } 
            else if (rad_2.Checked)
            {
                txt_tdee.Text = Math.Round(nBmr * 1.375).ToString();
            }
            else if (rad_3.Checked)
            {
                txt_tdee.Text = Math.Round(nBmr * 1.55).ToString();
            }
            else if (rad_4.Checked)
            {
                txt_tdee.Text = Math.Round(nBmr * 1.725).ToString();
            }
            else
            {
                txt_tdee.Text = Math.Round(nBmr * 1.9).ToString();
            }
        }
        public void FillPol()
        {
            var dataSource = new List<Pol>();
            dataSource.Add(new Pol() { Naziv = "Muškarci", Vrednost = "1" });
            dataSource.Add(new Pol() { Naziv = "Žene", Vrednost = "2" });
            txt_pol.DataSource = dataSource;
            txt_pol.DisplayMember = "Naziv";
            txt_pol.ValueMember = "Vrednost";
        }
        public void FillGodina()
        {
            var dataSource = new List<String>();
            dataSource.Add("");
            for (int i = 0; i < 150; i++)
            {
                dataSource.Add(i.ToString());
            }
            txt_starost.DataSource = dataSource; 
        }
        public void FillVisina()
        {
            var dataSource = new List<String>();
            dataSource.Add("");
            for (int i = 40; i < 251; i++)
            {
                dataSource.Add(i.ToString());
            }
            txt_visina.DataSource = dataSource;
        }
        public void FillTezina()
        {
            var dataSource = new List<String>();
            dataSource.Add("");
            for (int i = 1; i < 251; i++)
            {
                dataSource.Add(i.ToString());
            }
            txt_tezina.DataSource = dataSource;
        }
        public void RefreshData()
        {
            String sQuery = "select pol,visina,starost,[Nivo aktivnosti] from kalkulatorparametri";
            DataTable dt = DataBase.executeQuery(sQuery);
            foreach (DataRow row in dt.Rows)
            {
                txt_pol.Text = row.ItemArray[0].ToString();
                txt_visina.Text = row.ItemArray[1].ToString();
                txt_starost.Text = row.ItemArray[2].ToString();
                String sNivoAktivnosti = row.ItemArray[3].ToString();
                if (sNivoAktivnosti == "Sedeci")
                {
                    rad_1.Checked = true;
                }
                else if (sNivoAktivnosti == "Lak")
                {
                    rad_2.Checked = true;
                }
                else if (sNivoAktivnosti == "Umeren")
                {
                    rad_3.Checked = true;
                }
                else if (sNivoAktivnosti == "Veoma aktivan")
                {
                    rad_4.Checked = true;
                }
                else
                {
                    rad_5.Checked = true;
                }
                
            }
            sQuery = "select tezina from tezina where id=(select max(id) from tezina)";
            dt = DataBase.executeQuery(sQuery);
            foreach (DataRow row2 in dt.Rows)
            {
                txt_tezina.Text = Math.Round(double.Parse(row2.ItemArray[0].ToString())).ToString();
            }
        }
        //eventi
        private void Kalkulator_Load(object sender, EventArgs e)
        {
            rad_1.Checked = true;
            FillPol();
            FillGodina();
            FillVisina();
            FillTezina();
            RefreshData();
        }

        private void btn_izracunaj_Click(object sender, EventArgs e)
        {
            if (txt_starost.Text == "" || txt_tezina.Text == "" || txt_visina.Text == "")
                return;
            IzracunajBMR();
            IzracunajTDEE();
        }

        private void btn_parametri_Click(object sender, EventArgs e)
        {
            String sNivoAktivnosti = "";
            if (rad_1.Checked)
            {
                sNivoAktivnosti = "Sedeci";
            }
            else if (rad_2.Checked)
            {
                sNivoAktivnosti = "Lak";
            }
            else if (rad_3.Checked)
            {
                sNivoAktivnosti = "Umeren";
            }
            else if (rad_4.Checked)
            {
                sNivoAktivnosti = "Veoma aktivan";
            }
            else
            {
                sNivoAktivnosti = "Ekstreman";
            }
            KalkulatorParametri parametri = new KalkulatorParametri(txt_pol.SelectedText, txt_visina.Text, txt_starost.Text,sNivoAktivnosti);
            parametri.ShowDialog();
            RefreshData();
        }

        private void btn_osvezi_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
        
    }
    class Pol
    {
        public String Naziv{get;set;}
        public String Vrednost{get;set;}
    }
}
