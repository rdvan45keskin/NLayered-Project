using Northwind.DataAccess.Abstract;
using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> //TEntity işlem yapılacak şey(product,category vb.) TContext database işlemi(NorthwindContext),IEntityRepository<TEntity> için ise IEntityRepository'e product yollayıp yani IProductDal kullanılması
        where TEntity : class,IEntity,new()
        where TContext :DbContext,new()
    {
        public void Add(TEntity entity)     //product veya categories geliyo
        {
            using (TContext context = new TContext())   //NorthwindContext geliyo mesela
            {
                var addedEntity = context.Entry(entity);    
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)      //product veya categories geliyo
        {
            using (TContext context = new TContext())       //NorthwindContext geliyo mesela
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)      //product veya categories geliyo
        //public Product Get(Expression<Func<Product, bool>> filter)
        //sonuç varsa 1 tane döner yoksa null döner
        {
            using (TContext context = new TContext())       //NorthwindContext geliyo mesela
                  //(NorthwindContext context = new NorthwindContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)      //product veya categories geliyo
        //Verilen filtreye uyan (veya filtre verilmemişse tüm) kayıtların bir listesini döner.
        {
            using (TContext context = new TContext())       //NorthwindContext geliyo mesela
            {
                return filter==null? context.Set<TEntity>().ToList(): context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)      //product veya categories geliyo
        {
            using (TContext context = new TContext())       //NorthwindContext geliyo mesela
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
