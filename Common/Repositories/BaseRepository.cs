using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Common.Data;
using Common.Entities;

namespace Common.Repositories
{
    public class BaseRepository<T> where T : BaseEntity
    {
        private DbContext Context { get; set; }
        private DbSet<T> Items { get; set; }

        public BaseRepository(UnitOfWork uow)
        {
            Context = uow.Context;
            Items = Context.Set<T>();
        }
        public BaseRepository()
        {
            Context = new MyDbContext();
            Items = Context.Set<T>();
        }

        public List<T> GetAll<TResult>(Expression<Func<T,bool>>filter = null,
                                       Expression<Func<T,TResult>> order = null,
                                                                   int page = 1,
                                                          int itemsPerPage = 10)
        {
            page = page <= 0 ? 1 : page;
            itemsPerPage = itemsPerPage <= 0 ? 10 : itemsPerPage;

            IQueryable<T> query = Items;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (order != null)
            {
                query = query.OrderBy(filter);
            }
            return query.Skip(itemsPerPage * (page - 1))
                        .Take(itemsPerPage)
                        .ToList();
        }
        public T GetFirstOrDefault(Expression<Func<T,bool>> filter)
        {
            IQueryable<T> query = Items;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return query.FirstOrDefault();
        }

        public void Save(T item)
        {
            IQueryable<T> query = Items;

            if(item.Id <= 0)
            {
                Items.Add(item);
            }
            else
            {
                Items.Update(item);
            }
            Context.SaveChanges();
        }

        public int Count(Expression<Func<T,bool>> filter = null)
        {
            IQueryable<T> query = Items;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            return query.Count();
        }
        public void Delete(T item)
        {
            Items.Remove(item);
            Context.SaveChanges();
        }   
    }
}

