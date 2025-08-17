using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    //EfEntityRepositoryBase içinde Category, NorthwindContext classlarını ve ICategoryDal içindekini kullanıyor
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {
    }
}
