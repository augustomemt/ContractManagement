using ContractApi.Data.Converter;
using ContractApi.Data.VO;
using ContractApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractApi.Data.Converters
{
    public class CompaniesConverter : IParse<EmpresasVO, Companies>, IParse<Companies, EmpresasVO>
    {
        public Companies Parse(EmpresasVO origin)
        {
            if (origin == null) return new Companies();

            return new Companies
            {
                Id = origin.Id,
                CEP = origin.CEP,
                Nome = origin.Nome,
                Cidade = origin.Cidade,
                CNPJ = origin.CNPJ,
                CriadoEm = origin.CriadoEm,
                Endereco = origin.Endereco,
                Estado = origin.Estado,
                InscricaEestadual =  origin.InscricaEestadual,
                ModificadoEm = origin.ModificadoEm


            };
        }

        public EmpresasVO Parse(Companies origin)
        {
            if (origin == null) return new EmpresasVO();

            return new EmpresasVO
            {
                Id = origin.Id,
                CEP = origin.CEP,
                Nome = origin.Nome,
                Cidade = origin.Cidade,
                CNPJ = origin.CNPJ,
                CriadoEm = origin.CriadoEm,
                Endereco = origin.Endereco,
                Estado = origin.Estado,
                InscricaEestadual = origin.InscricaEestadual,
                ModificadoEm = origin.ModificadoEm


            };
        }

        public List<Companies> ParseList(List<EmpresasVO> origin)
        {
            if (origin == null) return new List<Companies>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<EmpresasVO> ParseList(List<Companies> origin)
        {
            if (origin == null) return new List<EmpresasVO>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
