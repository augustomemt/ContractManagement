using ContractApi.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractApi.Repository.Generic
{
   public  interface IContractRepository: IRepository<Contracts>
    {
        
        List<Contracts> FindByName(string name , string comprador);


    }
}
