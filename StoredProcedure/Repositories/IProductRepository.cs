
using Newtonsoft.Json;
using StoredProcedure.Models;

namespace StoredProcedure.Repositories
{
    internal interface IProductRepository
    {
       Task<IEnumerable<Products>> Exec();

   
    }
}
