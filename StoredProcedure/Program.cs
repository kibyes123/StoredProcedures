using StoredProcedure.Models;
using StoredProcedure.Repositories;

namespace StoredProcedure
{
    internal class Program
    { 
        public static async Task Main(string[] args)
        {
            IProductRepository repo = new ProductRepository();
            foreach(var res in await repo.Exec())
            {
                Console.WriteLine(res); 
            }
            
        }
    }
}