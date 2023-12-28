using Dapper;
using DataAccessLayer;
using EntityLayer.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer
{
    public class ProductManager
    {
        Repository<Product> repository = new Repository<Product>();
        public List<Product> GetAllEF()
        {
            return repository.List();
        }
        public int AddEF(Product p)
        {
            return repository.Insert(p);
        }

        public Product GetByIdEF(int id)
        {
            return repository.GetById(id);
        }


        public int UpdateEF(Product p)
        {
            return repository.Update(p);
        }
       


        private string connectionString = "Data Source=DESKTOP-PE0VBS8;Database=HizTesti;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public void ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Product> GetProductsUsingDapper()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.Query<Product>("SELECT * FROM dbo.Products").ToList();
            }
        }

        public Product GetProductByIdUsingDapper(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.Query<Product>("SELECT * FROM dbo.Products WHERE Id = @Id", new { Id = id }).FirstOrDefault();
            }
        }

        public int AddDapper(Product p)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.Execute("INSERT INTO dbo.Products (ProductName, Stock) VALUES (@ProductName, @Stock)", p);
            }
        }

        public int UpdateDapper(Product p)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.Execute("UPDATE dbo.Products SET ProductName = @ProductName, Stock = @Stock WHERE Id = @Id", p);
            }
        }

        
    }
}
