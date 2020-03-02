using ContractApi.Data.Converter;
using ContractApi.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractApi.Data.Converters
{
    public class ContratosConverter : IParse<ContratosVO, Contratos>, IParse<Contratos, ContratosVO>
    {
        public ContratosVO Parse(Contratos origin)
        {
            if (origin == null) return new ContratosVO();
            return new ContratosVO
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

        public Contratos Parse(ContratosVO origin)
        {
            if (origin == null) return new Contratos();
            return new Contratos
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

        public List<ContratosVO> ParseList(List<Contratos> origin)
        {
            if (origin == null) return new List<ContratosVO>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<Contratos> ParseList(List<ContratosVO> origin)
        {
            if (origin == null) return new List<Contratos>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
