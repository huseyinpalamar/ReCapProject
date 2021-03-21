using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public void Add(Car car)
        {
            if (car.Description.Length>2&&car.DailyPrice>0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("The vehicle name must be 2 characters and the daily price of the vehicle must be greater than 0.");
            }
        }

        public void Deleted(Car car)
        {
            _carDal.Deleted(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c=>c.Id==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c=>c.ColorId==id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
