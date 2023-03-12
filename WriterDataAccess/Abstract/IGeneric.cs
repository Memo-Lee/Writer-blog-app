﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriterDataAccess.Abstract
{
    public interface IGeneric<T> where T : class
    {
        void Insert(T TItem);
        void Update(T TItem);
        void Delete(T TItem);
        List<T> GetAllList();
        T GetById(int id);
    }
}
