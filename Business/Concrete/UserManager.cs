using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
            
        }

        public IResult Add(User user)
        {
            if (user.LastName.Length<2&&user.Password.Length<8)
            {
                return new SuccessResult(Messages.RegistrationFailed);
            }
            _userDal.Add(user);
            return new SuccessResult(Messages.RegistrationSuccessful);
        }

        public IResult Deleted(User user)
        {
            _userDal.Deleted(user);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),Messages.ListiningSuccessful);
        }

        public IDataResult<User> GetByUserId(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u=>u.Id==userId),Messages.ListiningSuccessful);
        }

        public IResult Updated(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.Updated);
        }
    }
}
