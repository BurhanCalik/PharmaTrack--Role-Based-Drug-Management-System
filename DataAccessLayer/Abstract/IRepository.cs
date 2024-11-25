﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> List();
        int Insert(T p);
        int Update(T p);
        int Delete(T p);
        T GetById(int id);

    }
}
