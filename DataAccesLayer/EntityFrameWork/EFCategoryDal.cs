﻿using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFrameWork
{
    public class EFCategoryDal:GenericRepository<Category>,ICategoryDal
    {
    }
}
