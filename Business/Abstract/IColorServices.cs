using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IColorServices
    {
        IDataResult<List<Color>> GetAll();
        IResult Add(Color color);
        IResult Updated(Color color);
        IResult Deleted(Color color);
    }
}
