using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByColorId(int id);
        List<Car> GetCarsByBrandId(int id);
        List<ProductDetailDto> GetProductDetails();
        void Add(Car car);
        void Update(Car car);
        void Deleted(Car car);
        

    }
}
