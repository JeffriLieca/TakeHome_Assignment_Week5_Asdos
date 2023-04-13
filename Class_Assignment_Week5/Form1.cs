using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Assignment_Week5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxNamaProd.Focus();
        }
        List<string> listIDProduct = new List<string>(){"J001","T001","T002","R001","J002","C001","C002","R002"};
        List<string> listNamaProduct = new List<string>() { "Jas Hitam", "T-Shirt Black Pink", "T-Shirt Obsessive", "Rok mini", "Jeans Biru" ,"Celana Pendek Coklat","Cawat Blink-blink","Rocca Shirt"};
        List<int> listHargaProduct = new List<int>() { 100000,70000,75000,82000,90000,60000,1000000,50000 };
        List<int> listStockProduct = new List<int>() { 10, 20, 16, 26, 5, 11,1 ,8};
        List<string> listProduct_IDCategory = new List<string>() { "C1", "C2", "C2", "C3", "C4","C4","C5" ,"C2"};
        List<string> listIDCategory = new List<string>() { "C1", "C2", "C3", "C4","C5" };
        List<string> listNamaCategory = new List<string>() { "Jas", "T-Shirt", "Rok", "Celana","Cawat" };
        DataTable dtProductSimpan = new DataTable();
        DataTable dtProductTampil = new DataTable();
        DataTable dtCategorySimpan = new DataTable();
        DataTable dtCategoryTampil = new DataTable();
        DataColumn column=new DataColumn();
        DataRow row;
        private void Form1_Load(object sender, EventArgs e)
        {
                comboBoxFilter.Enabled = false;
            
            // add kolom id
            column =new DataColumn();
            column.ColumnName = "ID Product";
            dtProductSimpan.Columns.Add(column);

            // add kolom id
            column = new DataColumn();
            column.ColumnName = "Nama Product";
            dtProductSimpan.Columns.Add(column);

            // add kolom id
            column = new DataColumn();
            column.ColumnName = "Harga";
            dtProductSimpan.Columns.Add(column);

            // add kolom id
            column = new DataColumn();
            column.ColumnName = "Stock";
            dtProductSimpan.Columns.Add(column);

            // add kolom id
            column = new DataColumn();
            column.ColumnName = "ID Category";
            dtProductSimpan.Columns.Add(column);

            for (int i = 0; i < listIDProduct.Count; i++)
            {
                row=dtProductSimpan.NewRow();
                row[0] = listIDProduct[i];
                row[1] = listNamaProduct[i];
                row[2] = listHargaProduct[i];
                row[3] = listStockProduct[i];
                row[4] = listProduct_IDCategory[i];
                dtProductSimpan.Rows.Add(row);
            }

            // add kolom id
            column = new DataColumn();
            column.ColumnName = "ID Category";
            dtCategorySimpan.Columns.Add(column);

            // add kolom id
            column = new DataColumn();
            column.ColumnName = "Nama Category";
            dtCategorySimpan.Columns.Add(column);

            for (int i = 0; i < listIDCategory.Count; i++)
            {
                row = dtCategorySimpan.NewRow();
                row[0] = listIDCategory[i];
                row[1] = listNamaCategory[i];
                dtCategorySimpan.Rows.Add(row);
            }
            //dtCategoryTampil = dtCategorySimpan.Copy();
            dtProductTampil= dtProductSimpan.Copy();
            dataGridViewProduct.DataSource = dtProductTampil;
            dataGridViewCategory.DataSource = dtCategorySimpan;
            comboBoxFilter.DataSource = dtCategorySimpan.Copy();
            comboBoxFilter.DisplayMember = "Nama Category";
            comboBoxFilter.ValueMember = "ID Category";
            comboBoxCategory.DataSource = dtCategorySimpan.Copy();
            comboBoxCategory.DisplayMember = "Nama Category";
            comboBoxCategory.ValueMember = "ID Category";
            comboBoxFilter.Text = "";

            dataGridViewProduct.Columns[1].Width = 100;
            dataGridViewProduct.Columns["Stock"].Width = 50;
            buttonAll.Focus();
            textBoxNamaProd.Focus();
            dataGridViewCategory.CurrentCell = null;
            dataGridViewProduct.ClearSelection();
            dataGridViewProduct.CurrentCell= null;
            comboBoxCategory.Text = "";
        }


        private void buttonFilter_Click(object sender, EventArgs e)
        {
            comboBoxFilter.Enabled = true;
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            comboBoxFilter.Enabled=false;
            Filter("");
            dataGridViewCategory.CurrentCell = null;
            dataGridViewProduct.CurrentCell = null;
        }

        public void Filter(string nilai)
        {
            if (nilai != "")
            {

                dtProductTampil.Rows.Clear();
                for (int i = 0; i < dtProductSimpan.Rows.Count; i++)
                {
                    if (dtProductSimpan.Rows[i][4].ToString() == nilai)
                    {
                        row = dtProductTampil.NewRow();
                        row[0] = dtProductSimpan.Rows[i][0];
                        row[1] = dtProductSimpan.Rows[i][1];
                        row[2] = dtProductSimpan.Rows[i][2];
                        row[3] = dtProductSimpan.Rows[i][3];
                        row[4] = dtProductSimpan.Rows[i][4];
                        dtProductTampil.Rows.Add(row);
                    }

                }
            }
            else
            {
                dtProductTampil.Rows.Clear();
                for (int i = 0; i < dtProductSimpan.Rows.Count; i++)
                {
                        row = dtProductTampil.NewRow();
                        row[0] = dtProductSimpan.Rows[i][0];
                        row[1] = dtProductSimpan.Rows[i][1];
                        row[2] = dtProductSimpan.Rows[i][2];
                        row[3] = dtProductSimpan.Rows[i][3];
                        row[4] = dtProductSimpan.Rows[i][4];
                        dtProductTampil.Rows.Add(row);

                }
            }
            dataGridViewProduct.CurrentCell = null;
            dataGridViewCategory.CurrentCell = null;
            textBoxNamaProd.Clear();
            textBoxHarga.Clear();
            textBoxStock.Clear();
            passID = "";
            passCat = "";
            comboBoxCategory.DataSource=dtCategorySimpan.Copy();
            comboBoxFilter.DataSource = dtCategorySimpan.Copy();
            comboBoxCategory.Text="";
            comboBoxFilter.Text = "";
            textBoxCategory.Text = "";

        }

        private void comboBoxFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Filter(comboBoxFilter.SelectedValue.ToString());
            dtProductTampil.Rows.Clear();
            for (int i = 0; i < dtProductSimpan.Rows.Count; i++)
            {
                if (dtProductSimpan.Rows[i][4].ToString() == comboBoxFilter.SelectedValue.ToString())
                {
                    row = dtProductTampil.NewRow();
                    row[0] = dtProductSimpan.Rows[i][0];
                    row[1] = dtProductSimpan.Rows[i][1];
                    row[2] = dtProductSimpan.Rows[i][2];
                    row[3] = dtProductSimpan.Rows[i][3];
                    row[4] = dtProductSimpan.Rows[i][4];
                    dtProductTampil.Rows.Add(row);
                }

            }
        }

        string passCat = "";
        private void dataGridViewCategory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //comboBoxFilter.Enabled = true;
            //Filter(label1.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[0].Value.ToString());
            try
            {
                passCat = dataGridViewCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxCategory.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                dataGridViewCategory.CurrentCell = null;
            }
        }

        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void AddProduct()
        {
            if (textBoxNamaProd.Text == "" || textBoxHarga.Text == "" || textBoxStock.Text == "")
            {
                MessageBox.Show("Input yang lengkap ya", "Error anying");
            }
            else
            {
                if (comboBoxCategory.SelectedValue == null || comboBoxCategory.Text=="")
                {
                    MessageBox.Show("Pilih Category dulu boy", "hehe");
                }
                else
                {


                    string hurufdepan = textBoxNamaProd.Text[0].ToString().ToUpper();
                    int angkatertinggi = 0;
                    foreach (DataRow ab in dtProductSimpan.Rows)
                    {
                        if (ab[0].ToString()[0].ToString() == hurufdepan)
                        {
                            int simpanAngka = Convert.ToInt32(ab[0].ToString().Substring(1));
                            if (angkatertinggi <= simpanAngka)
                            {
                                angkatertinggi = simpanAngka;
                            }
                        }
                    }
                    angkatertinggi += 1;
                    string id = hurufdepan.ToString();
                    for (int i = angkatertinggi.ToString().Length; i < 3; i++)
                    {
                        id += "0";
                    }
                    id += (angkatertinggi).ToString();
                    row = dtProductSimpan.NewRow();
                    row[0] = id;
                    row[1] = textBoxNamaProd.Text;
                    row[2] = textBoxHarga.Text;
                    row[3] = textBoxStock.Text;
                    row[4] = comboBoxCategory.SelectedValue;
                    dtProductSimpan.Rows.Add(row);
                    Filter("");
                }
            }
        }

        string passID="";
        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                passID = dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxNamaProd.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxHarga.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxStock.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxStock.Text = dataGridViewProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBoxCategory.SelectedValue = dataGridViewProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (comboBoxCategory.Text == "")
                {


                    foreach (DataRow row in dtCategorySimpan.Rows)
                    {
                        if (row[0].ToString() == dataGridViewProduct.Rows[e.RowIndex].Cells[4].Value.ToString())
                        {
                            comboBoxCategory.Text = row[1].ToString();
                        }
                    }
                }
                
            }
            catch (Exception) { dataGridViewProduct.CurrentCell = null; }
        }

        private void buttonEditProd_Click(object sender, EventArgs e)
        {
            if (passID != "")
            {
                if(textBoxNamaProd.Text=="" || textBoxHarga.Text=="" || textBoxStock.Text == "")
                {
                    MessageBox.Show("Input yang bener", "Dasar");
                }
                else
                {
                    if (comboBoxCategory.SelectedValue == null||comboBoxCategory.Text=="")
                    {
                        MessageBox.Show("Pilih Category dulu boy", "hehe");
                    }
                    else
                    {
                        foreach (DataRow ab in dtProductSimpan.Rows)
                        {
                            if (ab[0].ToString() == passID)
                            {
                                ab[1] = textBoxNamaProd.Text;
                                ab[2] = textBoxHarga.Text;
                                ab[3] = textBoxStock.Text;
                                ab[4] = comboBoxCategory.SelectedValue;
                                if (ab[3].ToString() == "0")
                                {
                                    dtProductSimpan.Rows.Remove(ab);
                                    break;
                                }
                            }
                        }
                    }
                }

                
            }
            else
            {
                MessageBox.Show("Pilih produk yang mau diedit terlebih dahulu","zzz");
            }
            Filter("");
        }

        private void buttonRemoveProd_Click(object sender, EventArgs e)
        {
            foreach (DataRow ab in dtProductSimpan.Rows)
            {
                if (ab[0].ToString() == passID)
                {
                    dtProductSimpan.Rows.Remove(ab);
                    break;
                }
            }
            Filter("");
        }

        private void buttonAddCat_Click(object sender, EventArgs e)
        {
            if (textBoxCategory.Text == "")
            {
                MessageBox.Show("Masukkan nama category terlebih dahulu","Hadee");
            }
            else
            {
                bool cek = true;
                foreach (DataRow ab in dtCategorySimpan.Rows)
                {
                    if(textBoxCategory.Text == ab[1].ToString())
                    {
                        cek= false;
                    }
                }
                if (cek == false)
                {
                    MessageBox.Show("Category sudah ada", "Ga bisa");
                }
                else
                {

                    int angkatertinggi = 0;
                    foreach (DataRow ab in dtCategorySimpan.Rows)
                    {
                        int simpanAngka = Convert.ToInt32(ab[0].ToString().Substring(1));
                        if (angkatertinggi <= simpanAngka)
                        {
                            angkatertinggi = simpanAngka;
                        }
                    }
                    string id = "C";
                    id += (angkatertinggi + 1).ToString();
                    row = dtCategorySimpan.NewRow();
                    row[0] = id;
                    row[1] = textBoxCategory.Text;
                    dtCategorySimpan.Rows.Add(row);
                    Filter("");
                }
            }
        }

        private void buttonRemoveCat_Click(object sender, EventArgs e)
        {
            foreach (DataRow ab in dtCategorySimpan.Rows)
            {
                if (ab[0].ToString() == passCat)
                {
                    dtCategorySimpan.Rows.Remove(ab);
                    break;
                }
            }
            for(int i = dtProductSimpan.Rows.Count - 1; i >= 0; i--)
            {
                if (dtProductSimpan.Rows[i]["ID Category"] == passCat)
                {
                    dtProductSimpan.Rows.Remove(dtProductSimpan.Rows[i]);
                }
            }
            Filter("");
        }

        private void textBoxHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
