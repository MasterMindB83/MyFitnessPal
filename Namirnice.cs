using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyFitnessPal
{
    public partial class Namirnice : Form
    {
        String[] Kategorija = new String[1000];
        String sSearch = "";
        int nKategorijaNo = 0;
        int nRezimRada=0;
        public Namirnice()
        {
            InitializeComponent();
            txt_datum.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }
        public Namirnice(int nRezimRada1)
        {
            InitializeComponent();
            nRezimRada = nRezimRada1;
            txt_datum.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }
        private void Kalorije_Load(object sender, EventArgs e)
        {
            DataBase.init();
            RefreshData();
            SetColumns();
            FillKategorijuComboBox();
        }

        //procedure
        public void FillKategorijuComboBox()//fill combo box
        {
            var dataSource = new List<String>();

            //Setup data binding

            dataSource.Add("");
            DataTable dt = DataBase.executeQuery("select * from Kategorija");
            foreach (DataRow row in dt.Rows)
            {
                dataSource.Add(row.ItemArray[0].ToString());
            }
            this.txt_kategorija.DataSource = dataSource;
        }
        public void InsertKategoriju(String kategorija)
        {
            String sQuery = "insert into kategorija values('"+kategorija+"')";
            DataBase.executeNonQuery(sQuery);
        }
        public void SetColumns()
        {
            try
            {
                grid.Columns[0].Width = 300;
                grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception ex)
            {
            }
        }
        public void RefreshData()
        {
           DataTable dt=new DataTable();
            String sQuery = "select * from Namirnice";
            dt = DataBase.executeQuery(GetQuery(sQuery));
            grid.DataSource = dt;
            
        }
        public String GetQuery(String sQuery)
        {
            if (txt_namirnica.Text != "" && txt_kategorija.Text!="")
            {
                sQuery += " where [Namirnica(100g)] like '%" + txt_namirnica.Text + "%' and Kategorija like '" + txt_kategorija.Text+"'";
            }
            else if (txt_namirnica.Text != "")
            {
                sQuery += " where [Namirnica(100g)] like '%" + txt_namirnica.Text + "%'";
            }
            else if( txt_kategorija.Text!="")
            {
                sQuery += " where Kategorija like '" + txt_kategorija.Text + "'";
            }


            return sQuery;
        }
        public void InsertData(String line)//insert data to database
        {
            
            int nPos = 0;
            String sNamirnica = GetItem(line, ref nPos).Replace("Č","C").Replace("Ć","C").Replace("ć","c").Replace("č","c");
            String sKcal = GetItem(line, ref nPos);
            String sKJ = GetItem(line, ref nPos);
            String sUH = GetItem(line, ref nPos);
            String sProteini = GetItem(line, ref nPos);
            String sMasti = GetItem(line, ref nPos);
            String sKategorija = GetItem(line, ref nPos).Replace("Č", "C").Replace("Ć", "C").Replace("ć", "c").Replace("č", "c").Replace("Đ", "D").Replace("đ", "d");



            String sql = "insert into Namirnice values('" + sNamirnica + "'," +
                                                    sKcal + "," +
                                                    sKJ + "," +
                                                    sUH + "," +
                                                    sProteini + "," +
                                                    sMasti + ",'" +
                                                    sKategorija +
                                                    "')";


            DataTable dt = DataBase.executeQuery("select * from Namirnice where [Namirnica(100g)] like '" + sNamirnica + "'");
            if (dt.Rows.Count == 0)
            {
                DataBase.executeNonQuery(sql);
                if (!sSearch.Contains("," + sKategorija + ","))
                {
                    InsertKategoriju(sKategorija);
                    Kategorija[nKategorijaNo++] = sKategorija;
                    sSearch += sKategorija + ",";
                }
            }
            //FillKategorijuComboBox();

        }
        public String GetItem(String line, ref int nPos)
        {
            String sItem = "";
            if (nPos > line.Length - 1)
                return "";
            int nPos2 = nPos;
            nPos2 = line.IndexOf(";", nPos);
            if (nPos2 == -1)
                nPos2 = line.Length;
            sItem = line.Substring(nPos, nPos2 - nPos);
            nPos = nPos2 + 1;


            return sItem;
        }
        
        //eventi
        private void btn_search_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)//choose file
            { 
                nKategorijaNo = 0;
                sSearch = ",,";
                Kategorija[nKategorijaNo++] = "";
                DataTable dt = DataBase.executeQuery("select * from kategorija");
                
                foreach (DataRow row in dt.Rows)
                {

                    Kategorija[nKategorijaNo++] = row.ItemArray[0].ToString();
                    sSearch += row.ItemArray[0].ToString()+",";
                }
                
                String selectedFileName = openFileDialog1.FileName;
                String[] lines = System.IO.File.ReadAllLines(selectedFileName);
                foreach (String line in lines)//inserting to database
                {
                    if(line!="")
                        InsertData(line);
                }
                RefreshData();
                FillKategorijuComboBox();
            }
        }

        private void txt_namirnica_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btn_empty_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite da obrišete sve namirnice?", "Upozorenje", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                DataBase.executeNonQuery("delete from Namirnice");
                RefreshData();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_datum.Text == "" || txt_kolicina.Text == "")
                return;
            
            int nRowIndex = grid.SelectedCells[0].RowIndex;
            String sNamirnica = grid.Rows[nRowIndex].Cells[0].Value.ToString();
            
            DialogResult dialogResult = MessageBox.Show("Da li želite da dodate "+sNamirnica+" u kalkulator kalorija?", "Obaveštenje", MessageBoxButtons.YesNo);//pitalica
            if (dialogResult == DialogResult.Yes)//ako je yes
            {
                
                String sKalorije = "", sUh = "", sProteini = "", sMasti = "";
                DataTable dt = DataBase.executeQuery("select * from Namirnice where [Namirnica(100g)] like '" + sNamirnica + "'");
                float nKolicina = 0;
                foreach (DataRow row in dt.Rows)
                {
                    sKalorije = row.ItemArray[1].ToString();
                    sUh = row.ItemArray[3].ToString();
                    sProteini = row.ItemArray[4].ToString();
                    sMasti = row.ItemArray[5].ToString();

                }
                nKolicina = float.Parse(txt_kolicina.Text) / 100;
                sUh = (nKolicina * float.Parse(sUh)).ToString();
                sProteini = (nKolicina * float.Parse(sProteini)).ToString();
                sMasti = (nKolicina * float.Parse(sMasti)).ToString();
                nKolicina = float.Parse(txt_kolicina.Text);
                float nKalorije = float.Parse(sKalorije);
                String sKalorijeUkupno = (nKolicina * nKalorije / 100).ToString();

                String sQuery2 = "select max(id) from calculator where datum like '"+txt_datum.Text+"'";
                DataTable dt2 = DataBase.executeQuery(sQuery2);
                int nId = 0;
                foreach (DataRow row2 in dt2.Rows)
                {
                    try
                    {
                        nId = int.Parse(row2.ItemArray[0].ToString());
                    }
                    catch (Exception ex)
                    {
                        nId = 0;
                    }
                }
                nId++;

                String sQuery = "insert into Calculator(Datum,id,Namirnica,UH,Proteini,Masti,Kalorije,Kolicina,[Kalorije ukupno]) values ('" +
                    txt_datum.Text + "',"+
                    nId.ToString()+ ",'" +
                    sNamirnica + "'," +
                    sUh.Replace(",", ".") + "," +
                    sProteini.Replace(",", ".") + "," +
                    sMasti.Replace(",", ".") + "," +
                    sKalorije.Replace(",", ".") + "," +
                    txt_kolicina.Text.Replace(",", ".") + "," +
                    sKalorijeUkupno.Replace(",", ".") + ")";

                DataBase.executeNonQuery(sQuery);
            }
            
        }
    }
}
