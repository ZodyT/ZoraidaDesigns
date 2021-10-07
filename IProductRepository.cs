using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoraidaDesigns.Models;

namespace ZoraidaDesigns
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
