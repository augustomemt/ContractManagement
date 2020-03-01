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
        public ContratoBusiness(IRepository<Contratos> repository)
        {
            _repository = repository;
        }


        public Contratos Create(Contratos contratos)
        {
            try
            {
                _repository.Create(contratos);


            }
            catch(Exception ex)
            {
                throw ex;
            }

            return contratos;
           
        }

        public void Delete(long id)
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

        public bool Exists(long? id)
        {
            throw new NotImplementedException();
        }

        public List<Contratos> FindAll()
        {
            try
            {
                return  _repository.FindAll();
            }
            catch(Exception E)
            {
                throw E;
            }
              

        }

        public Contratos FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Contratos Update(Contratos contrato)
        {
            try
            {
                _repository.Create(contrato);


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return contrato;
        }
    }
}
