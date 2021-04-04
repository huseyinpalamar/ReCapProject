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
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Deleted(Car car)
        {
            
            _carDal.Deleted(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            
            if (DateTime.Now.Hour==14)
            {
                return new ErrorDataResult<List<Car>>(Messages.CarListingFailed);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListiningSuccessful);
            
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.Id==id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
           
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.ColorId==colorId),Messages.CarListiningSuccessful);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>> (_carDal.GetCarDetails(),Messages.CarListiningSuccessful);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
       
    }
}
