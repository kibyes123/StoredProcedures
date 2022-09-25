using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcedure.Models
{
    internal class Products
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int ModelYear { get; set; }
        public double ListPrice { get; set; }

        public List<Products> products { get; set; } = new List<Products>();

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }


    }
}
