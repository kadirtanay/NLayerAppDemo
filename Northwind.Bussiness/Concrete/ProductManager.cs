using FluentValidation;
using Northwind.Bussiness.Abstrack;
using Northwind.Bussiness.Utilities;
using Northwind.Bussiness.ValidationRules.FluentValidation;
using Northwind.DataAcces.Abstrack;
using Northwind.DataAcces.Concrete;
using Northwind.DataAcces.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussiness.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }
        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }
        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch (Exception)
            {
                throw new Exception("Operation failed!");
            }
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int cateoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == cateoryId);
        }

        public List<Product> GetProductsByName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }


    }
}
