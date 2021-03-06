﻿using ContractApi.Data.VO;
using System.Collections.Generic;

namespace ContractApi.Business.Implementations
{
    public  interface IContractBusiness
    {
        ContractsVO Create(ContractsVO contratos);
        ContractsVO FindById(int id);
        List<ContractsVO> FindAll();
        List<ContractsVO> FindByName(string name , string comprador);

        ContractsVO Update(ContractsVO item);
        void Delete(int id);

        bool Exists(int? id);
    }
}
