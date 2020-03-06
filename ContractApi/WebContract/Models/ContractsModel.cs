using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebContract.Util;

namespace WebContract.Models
{
    public class ContractsModel
    {
        public int Id { get; set; }
        public string NomeContrato { get; set; }
        public string Tipo { get; set; }
        public decimal Tarifa { get; set; }
        public decimal FaturamentoMax { get; set; }
        public decimal FaturamentoMin { get; set; }
        public decimal FaturamentoRealizado { get; set; }
        public decimal FaturamentoPrevisto { get; set; }
        public decimal Pld { get; set; }
        public decimal ConsumoPrevisto { get; set; }
        public decimal ConsumoRealizado { get; set; }
        public decimal VolumeContrato { get; set; }
        public string Modalidade { get; set; }
        public DateTime DataAssinatura { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime DataInicio { get; set; }
        public string Status { get; set; }

        public List<ContractsModel> ListAllContracts()
        {
            List<ContractsModel> retorno = new List<ContractsModel>();
            retorno = JsonConvert.DeserializeObject<List<ContractsModel>>(WebApi.RequestGET());
            return retorno;
        }
    }
}
