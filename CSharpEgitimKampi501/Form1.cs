using CSharpEgitimKampi501.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=EgitimKampi501Db;Integrated Security=True");

        private async void Form1_Load(object sender, EventArgs e)
        {
            string query1 = "Select Count(*) From TblProduct";
            var productTotalCount = await connection.QueryFirstOrDefaultAsync<int>(query1);
            lbl_TotalProductCount.Text = productTotalCount.ToString();

            string query2 = "Select ProductName From TblProduct Where ProductPrice=(Select Max(ProductPrice) From TblProduct)";
            var maxProductPriceName = await connection.QueryFirstOrDefaultAsync<string>(query2);
            lbl_maxPriceProductName.Text = maxProductPriceName.ToString();

            string query3 = "Select Count(Distinct(ProductCategory)) From TblProduct";
            var distinctProductCount = await connection.QueryFirstOrDefaultAsync<int>(query3);
            lbl_distinctCategoryCount.Text = distinctProductCount.ToString();
        }

        private async void btn_listele_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TblProduct";
            var values = await connection.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource = values;

        }


        private async void btn_ekle_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO TblProduct (ProductName, ProductStock, ProductPrice, ProductCategory) VALUES (@productName, @productStock, @productPrice, @productCategory)";
            var parameters = new DynamicParameters();
            parameters.Add("@productName", txt_productName.Text);
            parameters.Add("@productStock", int.Parse(txt_productStock.Text));
            parameters.Add("@productPrice", decimal.Parse(txt_productPrice.Text));
            parameters.Add("@productCategory", txt_productCategory.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Yeni Kitap Ekleme İşlemi Başarılı!");
        }

        private async void btn_sil_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM TblProduct WHERE ProductId = @productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", int.Parse(txt_id.Text));
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Kitap Silme İşlemi Başarılı!");
        }

        private async void btn_guncelle_Click(object sender, EventArgs e)
        {
            string query = "UPDATE TblProduct SET ProductName = @productName, ProductStock = @productStock, ProductPrice = @productPrice, ProductCategory = @productCategory WHERE ProductId = @productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productName", txt_productName.Text);
            parameters.Add("@productStock", int.Parse(txt_productStock.Text));
            parameters.Add("@productPrice", decimal.Parse(txt_productPrice.Text));
            parameters.Add("@productCategory", txt_productCategory.Text);
            parameters.Add("@productId", int.Parse(txt_id.Text));
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Kitap Güncelleme İşlemi Başarılı Bir Şekilde Yapıldı!", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

       
    }
}
