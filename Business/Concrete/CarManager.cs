using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int carId)
        {
            return _carDal.GetAll(c => c.CarId == carId);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public void Add(Car car)
        {
            if (car.Description.Length <= 1)
            {
                throw new InvalidOperationException("Description must be minimum 2 chars");
            }

            if (car.DailyPrice <= 0)
            {
                throw new InvalidOperationException("Daily price must be grater than 0");
            }

            _carDal.Add(car);
        }
    }
}
