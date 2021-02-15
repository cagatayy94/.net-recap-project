using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrate;

namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color color);
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int colorId);
    }
}
