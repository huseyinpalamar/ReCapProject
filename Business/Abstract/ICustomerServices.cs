using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface ICustomerServices
    {
        IResult Add(Customer customer);
        IResult Updated(Customer customer);
        IResult Deleted(Customer customer);
        IDataResult<List<Customer>> GetAll();
    }
}
