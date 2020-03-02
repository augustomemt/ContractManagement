using ContractApi.Data.VO;
using ContractApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractApi.Business.Implementations
{
     public interface IEmpresaBusiness
    {
        EmpresasVO Create(EmpresasVO empresas);
        EmpresasVO FindById(int id);
        List<EmpresasVO> FindAll();
        EmpresasVO Update(EmpresasVO item);
        void Delete(int id);

        bool Exists(int? id);
    }
}
