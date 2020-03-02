using ContractApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractApi.Business.Implementations
{
     public interface IEmpresaBusiness
    {
        Empresas Create(Empresas empresas);
        Empresas FindById(int id);
        List<Empresas> FindAll();
        Empresas Update(Empresas item);
        void Delete(int id);

        bool Exists(int? id);
    }
}
