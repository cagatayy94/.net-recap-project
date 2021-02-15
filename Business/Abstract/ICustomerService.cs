using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetById(int customerId);
    }
}
