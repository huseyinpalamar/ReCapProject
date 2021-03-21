using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandServices
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length>2)
            {
                _brandDal.Add(brand);
            }
            else
            {
                Console.WriteLine("Name must be longer than 2 characters");
            }
        }

        public void Deleted(Brand brand)
        {
            _brandDal.Deleted(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public void Updated(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }
}
