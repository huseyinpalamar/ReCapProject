﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    interface IColorServices
    {
        List<Color> GetAll();
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}
