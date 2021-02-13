using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal:ICarDal
    {
        public EfCarDal()
        {
        }

        public void Add(Car entity)
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                var addedEntity = reCapContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                reCapContext.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                return filter == null
                    ? reCapContext.Set<Car>().ToList()
                    : reCapContext.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }

    }
}
