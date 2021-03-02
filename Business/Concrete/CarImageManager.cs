using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage carImage)
        {
            IResult isValid = CheckCarImageLimitSuitable(carImage.CarId);

            if (isValid.Success)
            {
                _carImageDal.Add(carImage);

                return new SuccessResult();
            }

            return new ErrorResult(isValid.Message);
        }

        public IResult Delete(int carImageId)
        {
            var carImageToDelete = _carImageDal.Get(c => c.CarImageId == carImageId);

            _carImageDal.Delete(carImageToDelete);

            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IResult Update(CarImage carImage)
        {
            var result = _carImageDal.Get(c => c.CarImageId == carImage.CarImageId);

            _carImageDal.Update(carImage);

            return new SuccessResult();
        }

        private IResult CheckCarImageLimitSuitable(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult(Messages.CarImageLimitExceded);
            }

            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetCarImagesByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId));
        }
    }
}
