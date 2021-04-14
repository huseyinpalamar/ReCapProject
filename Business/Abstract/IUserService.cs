using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Deleted(User user);
        IResult Updated(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByUserId(int userId);

    }
}
