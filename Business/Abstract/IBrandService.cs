using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrate;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand brand);
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetById(int brandId);
    }
}
