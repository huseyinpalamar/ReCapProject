using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal icarDal)
        {
            _carDal = icarDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length<2)
            {
                
                return new ErrorResult(Messages.CarNameInValid);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.Added);
        }

        public IResult Deleted(Car car)
        {
            
            _carDal.Deleted(car);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            
            if (DateTime.Now.Hour==19)
            {
                return new ErrorDataResult<List<Car>>(Messages.ListingFailed);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.ListiningSuccessful);
            
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.Id==brandId),Messages.ListiningSuccessful);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
           
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.ColorId==colorId),Messages.ListiningSuccessful);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>> (_carDal.GetCarDetails(),Messages.ListiningSuccessful);
        }

        public IResult Updated(Car car)
        {
            if (DateTime.Now.Hour==15)
            {
                return new ErrorResult(Messages.NotUptaded);
            }
            _carDal.Update(car);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.DailyPrice>=min&&c.DailyPrice<=max));
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c=>c.Id==id));
            
        }
    }
}
