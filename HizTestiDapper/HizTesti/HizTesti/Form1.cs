using BusinessLayer;
using DataAccessLayer;
using EntityLayer.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HizTesti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        ProductManager productManager = new ProductManager();
        private void btnEntity_Click(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            long startmemory = GC.GetTotalMemory(true);
            stopwatch.Start();
            dataGridView1.DataSource = productManager.GetAllEF();
            stopwatch.Stop();
            long endmemory = GC.GetTotalMemory(true);
            long memory = endmemory - startmemory;
            var efTime = stopwatch.ElapsedMilliseconds;
            lblEFTime.Text = "Entity Framework Time: " + efTime + " ms" + "\nKullanýlan Memory: " + memory + " byte";

        }

        private void btnDapper_Click(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            long startmemory = GC.GetTotalMemory(true);
            stopwatch.Start();
            dataGridView1.DataSource = productManager.GetProductsUsingDapper();
            stopwatch.Stop();
            long endmemory = GC.GetTotalMemory(true);
            long memory = endmemory - startmemory;
            var dapperTime = stopwatch.ElapsedMilliseconds;
            lblDapperTime.Text = "Dapper Time: " + dapperTime + " ms." + "\nKullanýlan Memory: " + memory + " byte";

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtStock.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            long startmemory = GC.GetTotalMemory(true);
            stopwatch.Start();
            Product product = new Product()
            {
                ProductName = txtProductName.Text,
                Stock = Convert.ToInt32(txtStock.Text)
            };
            productManager.AddEF(product);
            stopwatch.Stop();
            long endmemory = GC.GetTotalMemory(true);
            long memory = endmemory - startmemory;
            var dapperTime = stopwatch.ElapsedMilliseconds;
            lblEkleEF.Text = "Entity Framework Time: " + dapperTime + " ms." + "\nKullanýlan Memory: " + memory + " byte";


            MessageBox.Show("Ekleme Baþarýlý");
            dataGridView1.DataSource = productManager.GetAllEF();
        }

        private void btnGuncelleEF_Click(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            long startmemory = GC.GetTotalMemory(true);
            stopwatch.Start();
            //var id = dataGridView1.SelectedRows[0].Cells[0].Value;
            var id = Convert.ToInt32(txtId.Text);

            var guncellenecekVeri = productManager.GetByIdEF((int)id);

            guncellenecekVeri.ProductName = txtProductName.Text;
            guncellenecekVeri.Stock = Convert.ToInt32(txtStock.Text);

            productManager.UpdateEF(guncellenecekVeri);
            stopwatch.Stop();
            long endmemory = GC.GetTotalMemory(true);
            long memory = endmemory - startmemory;
            var dapperTime = stopwatch.ElapsedMilliseconds;
            lblGuncelleEF.Text = "Entity Framework Time: " + dapperTime + " ms." + "\nKullanýlan Memory: " + memory + " byte";


            dataGridView1.DataSource = productManager.GetAllEF();
            MessageBox.Show("Güncelleme Baþarýlý");

        }

        private void DapperIleEkle(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            long startmemory = GC.GetTotalMemory(true);
            stopwatch.Start();
            productManager.AddDapper(new Product
            {
                ProductName = txtProductName.Text,
                Stock = Convert.ToInt32(txtStock.Text)
            });
            stopwatch.Stop();
            long endmemory = GC.GetTotalMemory(true);
            long memory = endmemory - startmemory;
            var dapperTime = stopwatch.ElapsedMilliseconds;
            lblEkleDapper.Text = "Dapper Time: " + dapperTime + " ms." + "\nKullanýlan Memory: " + memory + " byte";


            MessageBox.Show("Ekleme Baþarýlý");
            dataGridView1.DataSource = productManager.GetProductsUsingDapper();
        }

        private void btnGuncelleDapper_Click(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            long startmemory = GC.GetTotalMemory(true);
            stopwatch.Start();
            //var id = dataGridView1.SelectedRows[0].Cells[0].Value;
            var id = Convert.ToInt32(txtId.Text);
            var guncellenecekUrun = productManager.GetProductByIdUsingDapper((int)id);

            guncellenecekUrun.ProductName = txtProductName.Text;
            guncellenecekUrun.Stock = Convert.ToInt32(txtStock.Text);
            productManager.UpdateDapper(guncellenecekUrun);
            stopwatch.Stop();
            long endmemory = GC.GetTotalMemory(true);
            long memory = endmemory - startmemory;
            var dapperTime = stopwatch.ElapsedMilliseconds;
            lblGuncelleDapper.Text = "Dapper Time: " + dapperTime + " ms." + "\nKullanýlan Memory: " + memory + " byte";

            MessageBox.Show("Güncelleme Baþarýlý");
            dataGridView1.DataSource = productManager.GetProductsUsingDapper();
        }
      
      
    }

}