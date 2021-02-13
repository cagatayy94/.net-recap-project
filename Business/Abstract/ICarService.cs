using System;
using System.Collections.Generic;
using Entities.Concrate;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(int carId);
    }
}