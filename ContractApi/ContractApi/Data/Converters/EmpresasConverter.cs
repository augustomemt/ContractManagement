using ContractApi.Data.Converter;
using ContractApi.Data.VO;
using ContractApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractApi.Data.Converters
{
    public class EmpresasConverter : IParse<EmpresasVO, Empresas>, IParse<Empresas, EmpresasVO>
    {
        public Empresas Parse(EmpresasVO origin)
        {
            if (origin == null) return new Empresas();

            return new Empresas
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

        public EmpresasVO Parse(Empresas origin)
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

        public List<Empresas> ParseList(List<EmpresasVO> origin)
        {
            if (origin == null) return new List<Empresas>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<EmpresasVO> ParseList(List<Empresas> origin)
        {
            if (origin == null) return new List<EmpresasVO>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
