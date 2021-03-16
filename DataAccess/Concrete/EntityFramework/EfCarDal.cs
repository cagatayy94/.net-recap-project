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
                                 CarId = car.CarId,
                                 BrandId = car.BrandId,
                                 BrandName = b.BrandName,
                                 ColorId = car.ColorId,
                                 ColorName = color.ColorName,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                             };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsByColorIdAndBrandId(int? colorId, int? brandId)
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
                                BrandId = car.BrandId,
                                BrandName = b.BrandName,
                                ColorId= car.ColorId,
                                ColorName = color.ColorName,
                                ModelYear = car.ModelYear,
                                DailyPrice = car.DailyPrice,
                                Description = car.Description,
                             };

                if (brandId != null)
                {
                    result = result.Where(c=>c.BrandId == brandId);
                }

                if (colorId != null)
                {
                    result = result.Where(c => c.ColorId == colorId);
                }

                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetail(int carId)
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
                                 CarId = car.CarId,
                                 BrandId = car.BrandId,
                                 BrandName = b.BrandName,
                                 ColorId = car.ColorId,
                                 ColorName = color.ColorName,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                             };
                return result.Where(c=>c.CarId == carId).ToList();
            }
        }
    }
}
