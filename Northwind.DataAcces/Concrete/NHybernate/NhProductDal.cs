using Northwind.DataAcces.Abstrack;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAcces.Concrete.NHybernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
            {
                new Product{
                CategoryId = 1,
                ProductId = 1,
                ProductName = "Laptop",
                QuantityPerUnit="ASDF",
                UnitPrice = 5,
                UnitsInStock = 43 }
            };
            return products;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
