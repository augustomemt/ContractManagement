using ContractApi.Models.Base;
using ContractApi.Models.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContractApi.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {

        private readonly BaseContext _context;

        private DbSet<T> dataset;

        public GenericRepository( BaseContext context)
        {
            _context = context;

            dataset = _context.Set<T>();
        }


        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return item;
        }

        public void Delete(int id)
        {
           
                T element = dataset.Find(id);
                dataset.Remove(element);
               _context.SaveChanges();
            
        }

        public bool Exists(int? id)
        {
            throw new NotImplementedException();
        }

        public List<T> FindAll()
        {
            return dataset.ToList();
        }

        public T FindById(int id)
        {
            return dataset.SingleOrDefault(p => p.Id.Equals(id));
        }

        public T Update(T item)
        {


           
            
            dataset.Update(item);

            _context.SaveChanges();

            return item;
        }
    }
}
