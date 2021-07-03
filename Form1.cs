using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EntityOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities northwindEntities = new NorthwindEntities();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnUrunListele_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-D7EVAFE;Initial Catalog=Northwind;Integrated Security=True");
            SqlCommand command = new SqlCommand("Select * From Products", connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void BtnUrunListele2_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = northwindEntities.Products.ToList();
            dataGridView1.Columns[2].Visible = false;

        }

        private void BtnUrunListele3_Click(object sender, EventArgs e)
        {
            var query = from item in northwindEntities.Products
                        select new { item.ProductID, item.ProductName, item.UnitPrice,item.Categories.CategoryName };
            dataGridView1.DataSource = query.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.ProductName = TxtProductName.Text;
            products.UnitPrice = Convert.ToDecimal(TxtUnitPrice.Text);
            northwindEntities.Products.Add(products);
            northwindEntities.SaveChanges();
            MessageBox.Show("product added!!!");

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtProductID.Text);
            var p = northwindEntities.Products.Find(id);
            northwindEntities.Products.Remove(p);
            northwindEntities.SaveChanges();
            MessageBox.Show("product deleted!!!");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtProductID.Text);
            var p = northwindEntities.Products.Find(id);
            p.ProductName = TxtProductName.Text;
            p.UnitPrice = Convert.ToDecimal(TxtUnitPrice.Text);
            northwindEntities.SaveChanges();
            MessageBox.Show("product updated!!!");
        }

        private void BtnProsedur_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = northwindEntities.Ürünler();
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = northwindEntities.Products.Where(p => p.ProductName == TxtProductName.Text
            | p.Categories.CategoryName == TxtCategoryName.Text).ToList();
        }

        private void TxtProductName_TextChanged(object sender, EventArgs e)
        {
            string searched = TxtProductName.Text;
            var values = from item in northwindEntities.Products
                         where item.ProductName.Contains(searched)
                         select item;
            dataGridView1.DataSource = values.ToList();
        }

        private void BtnLinqEntity_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //Ascending
                List<Products> List1 = northwindEntities.Products.OrderBy(p => p.ProductName).ToList();
                dataGridView1.DataSource = List1;
            }
            if (radioButton2.Checked == true)
            {
                //Descending
                List<Products> List2 = northwindEntities.Products.OrderByDescending(p => p.ProductName).ToList();
                dataGridView1.DataSource = List2;
            }
            if (radioButton3.Checked == true)
            {
                //İlk 3 kayıt
                List<Products> List3 = northwindEntities.Products.OrderBy(p => p.ProductName).Take(3).ToList();
                dataGridView1.DataSource = List3;
            }
            if (radioButton4.Checked==true)
            {
                //ID ye göre veri getirme
                List<Products> List4 = northwindEntities.Products.Where(p => p.ProductID == 5).ToList();
                dataGridView1.DataSource = List4;
            }
            if (radioButton5.Checked==true)
            {
                //A ile başlayanları getir
                List<Products> List5 = northwindEntities.Products.Where(p => p.ProductName.StartsWith("A")).ToList();
                dataGridView1.DataSource = List5;
            }
            if (radioButton6.Checked == true)
            {
                //A ile bitenler
                List<Products> List6 = northwindEntities.Products.Where(p => p.ProductName.EndsWith("a")).ToList();
                dataGridView1.DataSource = List6;
            }
            if (radioButton7.Checked == true)
            {
                //Değer var mı
                bool value = northwindEntities.Products.Any();
                MessageBox.Show(value.ToString(), "Bilgi" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton8.Checked == true)
            {
                //toplam ürün sayısı
                int total = northwindEntities.Products.Count();
                MessageBox.Show(total.ToString(), "Toplam Ürün Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton9.Checked == true)
            {
                //ürünlerin toplam fiyatı
                var total = northwindEntities.Products.Sum(p => p.UnitPrice);
                MessageBox.Show("ürünlerin toplam fiyatı : " + total.ToString());
            }
            if (radioButton10.Checked==true)
            {
                //ürünlerin ortalama fiyatı
                var average = northwindEntities.Products.Average(p => p.UnitPrice);
                MessageBox.Show("ürünlerin ortalama fiyatı : " + average.ToString());
            }
            if (radioButton11.Checked == true)
            {
                //en yüksek fiyat
                var top = northwindEntities.Products.Max(p => p.UnitPrice);
                MessageBox.Show("en yüksek fiyat : " + top.ToString());
            }
            if (radioButton12.Checked == true)
            {
                //en yüksdüşükek fiyat
                var lower = northwindEntities.Products.Min(p => p.UnitPrice);
                MessageBox.Show("en yüksdüşükek fiyat : " + lower.ToString());
            }

        }

    }
}
