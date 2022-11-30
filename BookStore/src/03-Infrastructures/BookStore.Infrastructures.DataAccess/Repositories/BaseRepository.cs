﻿using BookStore.Core.Domain.Contracts;
using BookStore.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Infrastructures.DataAccess.Repositories
{
    public class BaseRepository<TEntity,TDbContext> : IRepository<TEntity>
        where TEntity:BaseEntity
        where TDbContext :DbContext
    {
        protected readonly TDbContext _dbContext;

        public BaseRepository(TDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public void Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public virtual TEntity GetById(long id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetList()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
