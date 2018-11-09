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
    public partial class Tezina : Form
    {
        public Tezina()
        {
            InitializeComponent();
        }
        //procedure
        public void RefreshData()
        {
            DataTable dt = DataBase.executeQuery("select id,Datum,Tezina,Promena from Tezina order by id desc");
            grid.DataSource = dt;
        }
        //eventi
        private void btn_namirnice_Click(object sender, EventArgs e)
        {
            Namirnice kalorije = new Namirnice();
            kalorije.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBase.init();
            RefreshData();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            TezinaUnos tezinaunos = new TezinaUnos();
            tezinaunos.ShowDialog();
            if (tezinaunos.Datum != "")
            {
                String sTezina = tezinaunos.Tezina;
                String sDatum = tezinaunos.Datum;
                DataTable dt=DataBase.executeQuery("select max(id)+1 from Tezina");
                int nMaxId=1;
                double nPromena = 0,nTezinaOld=0;
                foreach(DataRow row in dt.Rows)
                {
                    try
                    {
                        nMaxId = int.Parse(row.ItemArray[0].ToString());

                    }
                    catch (Exception ex)
                    {
                        nMaxId = 1;
                    }
                }
                dt = DataBase.executeQuery("select id,Tezina from Tezina where id=(select max(id) from Tezina)");
                foreach (DataRow row in dt.Rows)
                {
                    try
                    {
                        nTezinaOld = float.Parse(row.ItemArray[1].ToString());

                    }
                    catch (Exception ex)
                    {
                        nTezinaOld = 0;
                    }
                }
                if (nTezinaOld != 0)
                {
                    double nTezina = double.Parse(sTezina.Replace(".",","));
                    nPromena =  nTezina - nTezinaOld;
                }
                DataBase.executeNonQuery("insert into Tezina(id,Datum,Tezina,Promena) values(" + nMaxId + ",'" + sDatum + "'," + sTezina + ","+Math.Round(nPromena,1).ToString().Replace(",",".")+")");
                RefreshData();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int nRow = grid.SelectedCells[0].RowIndex;
                String sId = grid.Rows[nRow].Cells[0].Value.ToString();
                if (sId == "")
                    return;
                DialogResult dialogResult = MessageBox.Show("Da li želite da obrišete slog sa id: " + sId + ".", "Upozorenje", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DataBase.executeNonQuery("delete from Tezina where id=" + sId);
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
            }
            
        }

        private void btn_calculator_Click(object sender, EventArgs e)
        {
            UneteKalorije calculator = new UneteKalorije();
            calculator.ShowDialog();
        }
    }
}
