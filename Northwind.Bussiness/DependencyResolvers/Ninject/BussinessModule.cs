using Ninject.Modules;
using Northwind.Bussiness.Abstrack;
using Northwind.Bussiness.Concrete;
using Northwind.DataAcces.Abstrack;
using Northwind.DataAcces.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussiness.DependencyResolvers.Ninject
{
    public class BussinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
        }

    }
}
