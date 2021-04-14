using Business.Concrete;
using Business.Constants;
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
            // CarTest();
            // CarAdedTest();
            //CarDailyPriceTest();
            //CarUpdateTest();
            //BrandAddTest();
            //CarDetails();
            //UserTest();

        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());


            var result = userManager.Add(new User
            {
                FirstName = "Hüseyin",
                LastName = "Palamar",
                Email = "huseyinpalamar39@gmail.com"
                ,
                Password = "123456",



            });

            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName);
            }
        }

        private static void CarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            foreach (var car in result.Data)
            {
                Console.WriteLine("{0}--{1}--{2}--{3}", car.BrandName, car.ColorName, car.DailyPrice, car.Description);
            }
        }

        private static void BrandAddTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.Add(new Brand { BrandName = "Volvo" });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarUpdateTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.Updated(new Car { Id = 3, ModelYear = "2008", BrandId = 1, DailyPrice = 500, ColorId = 4, Description = "2008 model kiralık araba" });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarDailyPriceTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetByDailyPrice(500, 1000);
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.DailyPrice);
                }

            }
        }

        private static void CarAdedTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.Add(new Car
            {
                BrandId = 6,
                ColorId = 2,
                DailyPrice = 1000,
                ModelYear = "2021",
                Description = "Volvo"
            });

            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            var result2 = carManager.GetAll();
            if (result2.Success == true)
            {
                foreach (var car in result2.Data)
                {
                    Console.WriteLine(car.Description);
                }
            }
            else
            {
                Console.WriteLine(result2.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description + "-" + car.Id);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
