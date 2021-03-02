using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImage carImage);
        IDataResult<List<CarImage>> GetAll();
        IResult Update(CarImage carImage);
        IResult Delete(int carImageId);
        IDataResult<List<CarImage>> GetCarImagesByCarId(int CarId);
    }
}
