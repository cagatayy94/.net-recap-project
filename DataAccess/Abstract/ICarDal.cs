using System;
using System.Collections.Generic;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        public List<CarDetailDto> GetCarDetails();
        public List<CarDetailDto> GetCarDetail(int carId);
        public List<CarDetailDto> GetCarDetailsByColorIdAndBrandId(int? colorId, int? brandId);
    }
}
