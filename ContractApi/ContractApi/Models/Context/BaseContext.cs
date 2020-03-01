using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractApi.Models.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext()
        {

        }

        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }

        public DbSet<Contratos> Contratos { get; set; }
        public DbSet<Empresas> Empresas { get; set; }

    }


}
