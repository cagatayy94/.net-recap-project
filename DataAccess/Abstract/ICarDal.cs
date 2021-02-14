﻿using System;
using System.Collections.Generic;
using Core.DataAccess;
using Entities.Concrate;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        public List<CarDetailDto> GetCarDetails();
    }
}