using ContractApi.Data.Converter;
using ContractApi.Data.VO;
using System.Collections.Generic;
using System.Linq;

namespace ContractApi.Data.Converters
{
    public class ContractsConverter : IParse<ContractsVO, Contracts>, IParse<Contracts, ContractsVO>
    {
        public ContractsVO Parse(Contracts origin)
        {
            if (origin == null) return new ContractsVO();
            return new ContractsVO
            {
                Id = origin.Id,
                NomeContrato = origin.NomeContrato,
                Modalidade = origin.Modalidade,
                Tipo = origin.Tipo,
                ConsumoPrevisto = origin.ConsumoPrevisto,
                ConsumoRealizado = origin.ConsumoRealizado,
                FaturamentoMax = origin.FaturamentoMax,
                FaturamentoMin = origin.FaturamentoMin,
                FaturamentoPrevisto = origin.FaturamentoPrevisto,
                FaturamentoRealizado = origin.FaturamentoRealizado,
                Tarifa = origin.Tarifa,
                Status = origin.Status,
                DataAssinatura = origin.DataAssinatura,
                DataFim = origin.DataFim,
                DataInicio = origin.DataInicio,
                Pld = origin.Pld,
                VolumeContrato = origin.VolumeContrato


            };
        }

        public Contracts Parse(ContractsVO origin)
        {
            if (origin == null) return new Contracts();
            return new Contracts
            {
                Id = origin.Id,
                NomeContrato = origin.NomeContrato,
                Modalidade = origin.Modalidade,
                Tipo = origin.Tipo,
                ConsumoPrevisto = origin.ConsumoPrevisto,
                ConsumoRealizado = origin.ConsumoRealizado,
                FaturamentoMax = origin.FaturamentoMax,
                FaturamentoMin = origin.FaturamentoMin,
                FaturamentoPrevisto = origin.FaturamentoPrevisto,
                FaturamentoRealizado = origin.FaturamentoRealizado,
                Tarifa = origin.Tarifa,
                Status = origin.Status,
                DataAssinatura = origin.DataAssinatura,
                DataFim = origin.DataFim,
                DataInicio = origin.DataInicio,
                Pld = origin.Pld,
                VolumeContrato = origin.VolumeContrato


            };
        }

        public List<ContractsVO> ParseList(List<Contracts> origin)
        {
            if (origin == null) return new List<ContractsVO>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<Contracts> ParseList(List<ContractsVO> origin)
        {
            if (origin == null) return new List<Contracts>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
