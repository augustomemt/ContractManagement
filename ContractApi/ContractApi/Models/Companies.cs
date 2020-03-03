using ContractApi.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractApi.Models
{
    public  class  Companies : BaseEntity
    {
       
        public string  Nome  { get; set; }
        public string CNPJ { get; set; }

        public string InscricaEestadual { get; set; }
        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }
        public string CEP { get; set; }

        public DateTime CriadoEm { get; set; }
        public DateTime ModificadoEm { get; set; }


    }
}
