using Microsoft.EntityFrameworkCore;

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

        public DbSet<Contracts> Contratos { get; set; }
        public DbSet<Companies> Empresas { get; set; }

    }


}
