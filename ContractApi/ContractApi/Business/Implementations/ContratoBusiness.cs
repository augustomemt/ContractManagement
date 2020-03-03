using ContractApi.Data.Converters;
using ContractApi.Data.VO;
using ContractApi.Repository.Generic;
using System;
using System.Collections.Generic;

namespace ContractApi.Business.Implementations
{
    public class ContratoBusiness : IContratoBusiness
    {
        //Injeção de dependencia
        private IRepository<Contracts> _repository;

        private readonly ContractsConverter _converter;
        public ContratoBusiness(IRepository<Contracts> repository)
        {

            _repository = repository;
            _converter = new ContractsConverter();
        }


        public ContractsVO Create(ContractsVO contratos)
        {


            var contratoEntity = _converter.Parse(contratos);
            contratoEntity = _repository.Create(_converter.Parse(contratos));

            return  _converter.Parse(contratoEntity);
        }

        public void Delete(int id)
        {
            try
            {
                _repository.Delete(id);


            }
            catch (Exception ex)
            {
                throw ex;
            }

         
        }

        public bool Exists(int? id)
        {
            throw new NotImplementedException();
        }

        public List<ContractsVO> FindAll()
        {
           
                return _converter.ParseList( _repository.FindAll());           
           
              

        }

        public ContractsVO FindById(int id)
        {
             return _converter.Parse(_repository.FindById(id));
        }

        public ContractsVO Update(ContractsVO contrato)
        {
            var contratoEntity = _converter.Parse(contrato);
            contratoEntity = _repository.Update(_converter.Parse(contrato));

            return _converter.Parse(contratoEntity);
        }
    }
}
