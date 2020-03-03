using System.Runtime.Serialization;

namespace ContractApi.Models.Base
{

    [DataContract]
    public class BaseEntity
    {

        public  int? Id { get; set; }
    }
}
