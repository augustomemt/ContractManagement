using System;
using System.Collections.Generic;
using ContractApi.Data.Converters;
using ContractApi.Data.VO;
using ContractApi.Models;
using ContractApi.Repository.Generic;

namespace ContractApi.Business.Implementations
{
    public class CompanyBusiness : ICompanyBusiness
    {

        private IRepository<Companies> _repository;

        private readonly CompaniesConverter _converter;


        public CompanyBusiness(IRepository<Companies> repository)
        {
            _repository = repository;

            _converter = new CompaniesConverter();

        }

        public EmpresasVO Create(EmpresasVO empresas)
        {
            var empresaEntity = _converter.Parse(empresas);
            empresaEntity = _repository.Create(_converter.Parse(empresas));
            return _converter.Parse(empresaEntity);
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

        public List<EmpresasVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public EmpresasVO FindById(int id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public EmpresasVO Update(EmpresasVO empresa)
        {
            var empresEntiry = _converter.Parse(empresa);
            empresEntiry = _repository.Update(_converter.Parse(empresa));

            return _converter.Parse(empresEntiry);
        }
    }
}
