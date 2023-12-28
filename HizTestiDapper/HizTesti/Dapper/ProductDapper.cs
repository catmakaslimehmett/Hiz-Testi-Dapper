using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper
{
    public class ProductDapper
    {
        public List<Product> GetAllDapper()
        {
            using (var connection = new SqlConnection("Data Source=DESKTOP-PE0VBS8;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                connection.Open();
                var products = connection.Query<Product>("SELECT * FROM Products").ToList();
                return products;
            }
        }
    }
}
