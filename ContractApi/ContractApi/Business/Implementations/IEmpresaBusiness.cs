using ContractApi.Data.VO;
using System.Collections.Generic;

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
