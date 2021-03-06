using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length<2)
            {
                return new ErrorResult(Messages.BrandNameInValid);
            }

            _brandDal.Add(brand);
            return new SuccessResult(Messages.Added);
        }

        public IResult Deleted(Brand brand)
        {
            _brandDal.Deleted(brand);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>> (_brandDal.GetAll(),Messages.ListiningSuccessful);
        }

        public IResult Updated(Brand brand)
        {
            
            _brandDal.Update(brand);
            return new SuccessResult(Messages.Updated);
        }
    }
}
