using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandServices
    {
        IDataResult<List<Brand>> GetAll();
        IResult Add(Brand brand);
        IResult Deleted(Brand brand);
        IResult Updated(Brand brand);
    }
}
