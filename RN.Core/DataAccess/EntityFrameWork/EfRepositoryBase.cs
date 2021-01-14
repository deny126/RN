﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using RN.Core.Entities;

namespace RN.Core.DataAccess.EntityFrameWork
{
    public class EfRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity:class,IEntityBase ,new()
    where TContext:DbContext,new()
    {

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context=new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter==null?context.Set<TEntity>().ToList(): context.Set<TEntity>().Where(filter).ToList();
            }
        }
        public void Add(TEntity entity)
        {
            using (var context=new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
