using System.Collections.Generic;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             join b in context.Brands
                                on car.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                CarId= car.CarId,
                                BrandName = b.BrandName,
                                ColorName = color.ColorName,
                                ModelYear = car.ModelYear,
                                DailyPrice = car.DailyPrice,
                                Description = car.Description
                             };
                return result.ToList();
            }
        }
    }
}
