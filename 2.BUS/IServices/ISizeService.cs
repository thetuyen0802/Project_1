﻿using _3.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ISizeService
    {
        string Add(Size size);
        string update(Size size);
        List<Size> GetSizes();
        Size GetById(int id);

    }
}
