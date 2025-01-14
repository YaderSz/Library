﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface IRepository <TEntity> where TEntity : class
    {
        List<TEntity> GetAll ();
        TEntity GetById(int id);
        void Add(TEntity entity);   
        void Update (TEntity entity);   
        void Delete (int id);
    }
}
