﻿using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int rentalId);
    }
}