using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractApi.Business.Implementations
{
    interface IContratoBusiness
    {
        Contratos Create(Contratos contratos);
        Contratos FindById(long id);
        List<Contratos> FindAll();
        Contratos Update(Contratos item);
        void Delete(long id);

        bool Exists(long? id);
    }
}
