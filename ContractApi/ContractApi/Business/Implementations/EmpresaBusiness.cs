using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContractApi.Models;
using ContractApi.Repository.Generic;

namespace ContractApi.Business.Implementations
{
    public class EmpresaBusiness : IEmpresaBusiness
    {

        private IRepository<Empresas> _repository;
        public EmpresaBusiness(IRepository<Empresas> repository)
        {
            _repository = repository;
        }

        public Empresas Create(Empresas empresas)
        {
            try
            {
                _repository.Create(empresas);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return empresas;
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

        public List<Empresas> FindAll()
        {
            try
            {
                return _repository.FindAll();
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        public Empresas FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Empresas Update(Empresas empresa)
        {
            try
            {
                _repository.Update(empresa);


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return empresa;
        }
    }
}
