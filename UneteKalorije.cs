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
    public partial class UneteKalorije : Form
    {
        public UneteKalorije()
        {
            InitializeComponent();
        }
        //procedure
        public void SetColumns()
        {
            grid.Columns[1].Width = 300;
            grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns[0].Visible = false;
        }
        public void RefreshData()
        {
            String sQuery = "select id,Namirnica,uh,proteini,masti,kalorije,kolicina,[Kalorije ukupno] from calculator where datum like '" + txt_datum.Text + "'";
            DataTable dt = DataBase.executeQuery(sQuery);
            grid.DataSource = dt;
            String sQuery2 = "select sum(uh),sum(proteini),sum(masti),sum(kalorije),sum(kolicina),sum([Kalorije ukupno]) from calculator where datum like '" + txt_datum.Text + "'";
            DataTable dt2 = DataBase.executeQuery(sQuery2);
            foreach (DataRow row in dt2.Rows)
            {
                txt_uh.Text = row.ItemArray[0].ToString();
                txt_proteini.Text = row.ItemArray[1].ToString();
                txt_masti.Text = row.ItemArray[2].ToString();
                txt_kolicina.Text = row.ItemArray[4].ToString();
                txt_kalorije_ukupno.Text = row.ItemArray[5].ToString();
            }
        }
        //eventi
        private void btn_clear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite da obrišete slogove na dan: "+txt_datum.Text+"?", "Upozorenje", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataBase.executeNonQuery("delete from Calculator where datum like '"+txt_datum.Text+"'");
            }
            RefreshData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Namirnice kalorije = new Namirnice(1);
            kalorije.ShowDialog();
            RefreshData();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            //Build a list
            var dataSource = new List<String>();
            String sNow = DateTime.Now.ToString("dd.MM.yyyy");
            dataSource.Add(sNow);
            String sSearch = ","+sNow+",";
            DataTable dt = DataBase.executeQuery("select datum from calculator");
            foreach (DataRow row in dt.Rows)
            {
                String sDatum = row.ItemArray[0].ToString();
                if (!sSearch.Contains("," + sDatum + ","))
                {
                    dataSource.Add(sDatum);
                    sSearch += sDatum+",";
                }
            }

            //Setup data binding
            this.txt_datum.DataSource = dataSource;
            RefreshData();
            SetColumns();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int nRowIndex = grid.SelectedCells[0].RowIndex;

            String sId = grid.Rows[nRowIndex].Cells[0].Value.ToString();
            String sNamirnica = grid.Rows[nRowIndex].Cells[1].Value.ToString();
            String sDatum = txt_datum.Text;
            
            if (sNamirnica != "" && sDatum != "")
            {
                DialogResult dr = MessageBox.Show("Da li želite da obrišete: "+sNamirnica+" na dan: "+sDatum+"?", "Upozorenje", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    String sQuery = "delete from calculator where datum like'" + sDatum + "' and id=" + sId;
                    DataBase.executeNonQuery(sQuery);
                    RefreshData();
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void txt_datum_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
