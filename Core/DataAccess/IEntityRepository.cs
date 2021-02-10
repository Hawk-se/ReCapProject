﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // ****** Core katmanı diğer katmanları referans almaz ******
    // Generic constraint
    // class: referans tip
    // IEntity: IEntity veya IEntity implemente eden bir nesne olabilir
    // new() : IEntity interface olduğu için new'lenemez. O nedenle filtrede kullandık
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
