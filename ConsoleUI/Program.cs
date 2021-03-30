using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            // carManager.Add(new Car {BrandId=2,ColorId=3,ModelYear="1995",Description="2018 Model Volkswagen 1.5 aile için ideal model",DailyPrice=300 });
            carManager.Update(new Car {Id=6,Description="Günlük kullanım için ideal",ColorId=1,BrandId=4,DailyPrice=300,ModelYear="2000" });
            
            foreach (var car in carManager.GetProductDetails())
            {
                Console.WriteLine(car.BrandName+"-"+car.ColorName+"-"+car.DailyPrice+"-"+car.Description+"-"+car.Id);
            }
        }
    }
}
