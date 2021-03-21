using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandServices
    {
        List<Brand> GetAll();
        void Add(Brand brand);
        void Deleted(Brand brand);
        void Updated(Brand brand);
    }
}
