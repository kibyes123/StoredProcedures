using Dapper;
using StoredProcedure.Context;
using StoredProcedure.Models;
using System.Data;

namespace StoredProcedure.Repositories
{
    internal class ProductRepository : IProductRepository
    {
        private readonly DapperContext _context;
        public ProductRepository()
        {
            _context = new DapperContext("Data Source=DELL-PC;Initial Catalog=BikeStores;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public async Task<IEnumerable<Products>> Exec()
        {
            var sql = "uspGetProductList";
            var values = new {model_year = 2018 };
            using (var connection = _context.CreateConnection())
            {
                var results = await connection.QueryAsync<Products>(sql, values, commandType: CommandType.StoredProcedure);
                return results.ToList();
            }
            //results.ForEach(r => Console.WriteLine($"{r.OrderID} {r.Subtotal}"))
        }
    }
}
