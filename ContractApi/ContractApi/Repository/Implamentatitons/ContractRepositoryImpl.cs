using ContractApi.Models.Context;
using ContractApi.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractApi.Repository.Implamentatitons
{
    public class ContractRepositoryImpl : GenericRepository<Contracts>, IContractRepository
    {

       

        public ContractRepositoryImpl(BaseContext context) : base(context) { }
      

    

        public List<Contracts> FindByName(string name, string comprador)
        {
            if( !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(comprador))
            {
                return _context.Contratos.Where(p => p.NomeContrato.Equals(name) && p.Status.Equals(comprador)).ToList();
            }
            else if(!string.IsNullOrEmpty(name) && string.IsNullOrEmpty(comprador))
            {
                return _context.Contratos.Where(p => p.NomeContrato.Equals(name)).ToList();
            }
            else if (string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(comprador))
            {
                return _context.Contratos.Where(p => p.NomeContrato.Equals(name)).ToList();
            }
            else
            {
               return  _context.Contratos.ToList();
            }
           ;
        }

      
    }
}
