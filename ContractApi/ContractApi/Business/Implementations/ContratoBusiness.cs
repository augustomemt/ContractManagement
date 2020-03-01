using ContractApi.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractApi.Business.Implementations
{
    public class ContratoBusiness : IContratoBusiness
    {

        private IRepository<Contratos> _repository;


        public ContratoBusiness(IRepository<Contratos> repository)
        {
            _repository = repository;
        }
        public Contratos Create(Contratos contratos)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(long? id)
        {
            throw new NotImplementedException();
        }

        public List<Contratos> FindAll()
        {
            throw new NotImplementedException();
        }

        public Contratos FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Contratos Update(Contratos item)
        {
            throw new NotImplementedException();
        }
    }
}
