using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {

              new Car{Id=1,BrandId=1,ColorId =1,ModelYear="1995",DailyPrice=200,Description="Mercedes - Benz 1995 MODEL MERCEDES C200 OTOMATİK ELEGANCE" },
              new Car{Id=2,BrandId=1,ColorId=2,ModelYear="2020",DailyPrice=1000,Description="Mercedes - Benz 2020 MERCEDES EQC 400 4 MATIC TAM DOLU EXTRA FULL"},
              new Car{Id=3,BrandId=2,ColorId=3,ModelYear="2020",DailyPrice=600,Description="Volkswagen Passat  1.5 TSI ELEGANCE 150 PS"},
              new Car{Id=4,BrandId=2,ColorId=4,ModelYear="2015",DailyPrice=400,Description="Volkswagen Passat 2015 MODEL YENI KASA COMFORTLİNE Orjinal"},
              new Car{Id=5,BrandId=3,ColorId=5,ModelYear="2012",DailyPrice=700,Description="Audi A4 Sedan 2.0 TDI Aracımız 2012 Model Olup Sanruf Hariç Herşey Fulldur"},
              new Car{Id=6,BrandId=3,ColorId=6,ModelYear="2018",DailyPrice=800,Description="BMW  3 Serisi Yarı Otomatik"}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);

            _cars.Remove(carToDelete);

        }

        public void Deleted(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c=>c.Id==id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            
        }
    }
}
