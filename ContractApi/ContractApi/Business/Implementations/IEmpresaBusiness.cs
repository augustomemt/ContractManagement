using ContractApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractApi.Business.Implementations
{
    interface IEmpresaBusiness
    {
        Empresas Create(Empresas empresas);
        Empresas FindById(long id);
        List<Empresas> FindAll();
        Empresas Update(Empresas item);
        void Delete(long id);

        bool Exists(long? id);
    }
}
