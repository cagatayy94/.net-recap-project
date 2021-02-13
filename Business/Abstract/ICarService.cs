using System;
using System.Collections.Generic;
using Entities.Concrate;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(int carId);
        List<CarDetailDto> GetCarDetails();
    }
}