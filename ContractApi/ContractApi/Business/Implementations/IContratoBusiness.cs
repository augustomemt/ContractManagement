using ContractApi.Data.VO;
using System.Collections.Generic;

namespace ContractApi.Business.Implementations
{
    public  interface IContratoBusiness
    {
        ContractsVO Create(ContractsVO contratos);
        ContractsVO FindById(int id);
        List<ContractsVO> FindAll();
        ContractsVO Update(ContractsVO item);
        void Delete(int id);

        bool Exists(int? id);
    }
}
