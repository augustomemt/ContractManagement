using ContractApi.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractApi.Business.Implementations
{
   public  interface IContratoBusiness
    {
        ContratosVO Create(ContratosVO contratos);
        ContratosVO FindById(int id);
        List<ContratosVO> FindAll();
        ContratosVO Update(ContratosVO item);
        void Delete(int id);

        bool Exists(int? id);
    }
}
