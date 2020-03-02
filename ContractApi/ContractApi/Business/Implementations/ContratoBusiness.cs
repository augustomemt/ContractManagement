using ContractApi.Data.Converters;
using ContractApi.Data.VO;
using ContractApi.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractApi.Business.Implementations
{
    public class ContratoBusiness : IContratoBusiness
    {
        //Injeção de dependencia
        private IRepository<Contratos> _repository;

        private readonly ContratosConverter _converter;
        public ContratoBusiness(IRepository<Contratos> repository)
        {

            _repository = repository;
            _converter = new ContratosConverter();
        }


        public ContratosVO Create(ContratosVO contratos)
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

        public List<ContratosVO> FindAll()
        {
           
                return _converter.ParseList( _repository.FindAll());           
           
              

        }

        public ContratosVO FindById(int id)
        {
             return _converter.Parse(_repository.FindById(id));
        }

        public ContratosVO Update(ContratosVO contrato)
        {
            var contratoEntity = _converter.Parse(contrato);
            contratoEntity = _repository.Update(_converter.Parse(contrato));

            return _converter.Parse(contratoEntity);
        }
    }
}
