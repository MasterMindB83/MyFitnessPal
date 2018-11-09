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
    public partial class KalkulatorParametri : Form
    {
        public KalkulatorParametri(String Pol, String Visina, String Starost,String NivoAktivnosti)
        {
            InitializeComponent();

            FillGodina();
            FillVisina();
            FillPol();

            txt_pol.Text = Pol;
            txt_visina.Text = Visina;
            txt_starost.Text = Starost;
            if (NivoAktivnosti == "Sedeci")
            {
                rad_1.Checked=true;
            }
            else if (NivoAktivnosti == "Lak")
            {
                rad_2.Checked = true;
            }
            else if (NivoAktivnosti == "Umeren")
            {
                rad_3.Checked = true;
            }
            else if (NivoAktivnosti == "Veoma aktivan")
            {
                rad_4.Checked = true;
            }
            else
            {
                rad_5.Checked = true;
            }

        }

        //procedure
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

        //eventi
        private void KalkulatorParametri_Load(object sender, EventArgs e)
        {
        }

        private void btn_odustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_sacuvaj_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li želite da sačuvate parametre?", "Obaveštenje", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
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
                String sQuery = "delete from kalkulatorparametri";
                DataBase.executeNonQuery(sQuery);
                sQuery = "insert into kalkulatorparametri(pol,visina,starost,[Nivo aktivnosti]) values ('" +
                    txt_pol.Text + "'," +
                    txt_visina.Text + "," +
                    txt_starost.Text + ",'" +
                    sNivoAktivnosti + "')";
                DataBase.executeNonQuery(sQuery);

                Close();
            }
        }
    }
}
