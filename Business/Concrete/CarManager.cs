using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == carId));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
        }

        [ValidationAspect(typeof(CarValidator))]
        [SecuredOperation("car.add")]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            if (car.Description.Length <= 1)
            {
                return new ErrorResult(Messages.CarDescriptionInvalid);
            }

            if (car.DailyPrice <= 0)
            {
                return new ErrorResult(Messages.CarDailyPriceInvalid);
            }

            _carDal.Add(car);

            return new SuccessResult(Messages.CarAddedSuccessfully);

        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            _carDal.Add(car);

            if (car.DailyPrice < 10)
            {
                throw new Exception("asd");
            }


            car.CarId = 0;

            _carDal.Add(car);

            return new SuccessResult();
        }

        [PerformanceAspect(3)]
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsByColorIdAndBrandId(int? colorId, int? brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailsByColorIdAndBrandId(colorId, brandId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetail(int carId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetail(carId));
        }
    }
}
