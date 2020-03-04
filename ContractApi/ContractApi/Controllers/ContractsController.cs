using ContractApi.Business.Implementations;
using ContractApi.Data.VO;
using Microsoft.AspNetCore.Mvc;
using Tapioca.HATEOAS;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContractApi.Controllers
{

    [ApiVersion("1.0")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class ContractsController : Controller
    {
        //Injeção de dependencia 
        private IContractBusiness _contratoBusiness;

        public ContractsController(IContractBusiness contrato)
        {
            _contratoBusiness = contrato;
        }
        // GET: api/<controller>
        [HttpGet]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult  Get()
        {
            return Ok(_contratoBusiness.FindAll());
        }


        [HttpGet("find-by-name")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult GetByName([FromQuery] string name , [FromQuery] string comprador)
        {
            return Ok(_contratoBusiness.FindByName(name,comprador));
        }
        // GET api/<controller>/5
        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(int id)
        {
            var contract = _contratoBusiness.FindById(id);
            if (contract == null) return NotFound();
            return Ok (contract);
        }

        // POST api/<controller>
        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody]ContractsVO contrado)
        {
            if (contrado == null) return BadRequest();

            return new ObjectResult(_contratoBusiness.Create(contrado));


        }
        // PUT api/<controller>/5
        [HttpPut("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody]ContractsVO contrado)
        {


            if (contrado == null) return BadRequest();

            return new ObjectResult(_contratoBusiness.Update(contrado));
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            _contratoBusiness.Delete(id);
            return NoContent(); 
        }
    }
}
