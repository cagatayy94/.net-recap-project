using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId=1, BrandId=7, ColorId=10, ModelYear=1994, DailyPrice=249.90, Description="Its an impala"},
                new Car{CarId=2, BrandId=6, ColorId=11, ModelYear=1990, DailyPrice=234.90, Description="Its an ford"},
                new Car{CarId=3, BrandId=5, ColorId=12, ModelYear=1999, DailyPrice=223.90, Description="Its an ferrari"},
                new Car{CarId=4, BrandId=4, ColorId=13, ModelYear=1973, DailyPrice=212.90, Description="Its an jason"},
                new Car{CarId=5, BrandId=3, ColorId=14, ModelYear=1966, DailyPrice=256.90, Description="Its an stathom"},
                new Car{CarId=6, BrandId=2, ColorId=15, ModelYear=1921, DailyPrice=289.90, Description="Its an yunus"},
                new Car{CarId=7, BrandId=1, ColorId=16, ModelYear=1900, DailyPrice=255.90, Description="Its an impalamasyon"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<CarDetailDto> GetCarDetail(int carId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByColorIdAndBrandId(int colorId, int brandId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByColorIdAndBrandId(int? colorId, int? brandId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}