using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserServices
    {
        IResult Add(User user);
        IResult Deleted(User user);
        IResult Updated(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetByUserId(int userId);

    }
}
