using System;
using Core.DataAccess;
using Entities.Concrate;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
    }
}
