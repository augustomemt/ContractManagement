using ContractApi.Models.Base;
using ContractApi.Models.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            catch(Exception e)
            {
                throw e;
            }
            return item;
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(long? id)
        {
            throw new NotImplementedException();
        }

        public List<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public T FindById(long id)
        {
            throw new NotImplementedException();
        }

        public T Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
