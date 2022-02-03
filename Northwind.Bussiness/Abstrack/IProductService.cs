using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussiness.Abstrack
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetProductsByCategory(int cateoryId);
        List<Product> GetProductsByName(string productName);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
