﻿using BookStore.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Domain.Contracts
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity GetById(long id);
        void Add(TEntity entity);
        List<TEntity> GetList();
        void Save();

    }
}
