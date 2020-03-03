using ContractApi.Business.Implementations;
using ContractApi.Data.VO;
using Microsoft.AspNetCore.Mvc;
using Tapioca.HATEOAS;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContractApi.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class CompaniesController : Controller
    {

        //Injeção de dependencia 

        private IEmpresaBusiness _empresaBusiness;

        public CompaniesController( IEmpresaBusiness empresa)
        {
            _empresaBusiness = empresa;
        }



        [HttpGet]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_empresaBusiness.FindAll());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(int id)
        {
            var contract = _empresaBusiness.FindById(id);
            if (contract == null) return NotFound();
            return Ok(contract);
        }

        // POST api/<controller>
        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody]EmpresasVO empresas)
        {
            if (empresas == null) return BadRequest();

            return new ObjectResult(_empresaBusiness.Create(empresas));


        }
        // PUT api/<controller>/5
        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody]EmpresasVO empresas)
        {


            if (empresas == null) return BadRequest();

            return new ObjectResult(_empresaBusiness.Update(empresas));
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Delete(int id)
        {
            _empresaBusiness.Delete(id);
            return NoContent();
        }
    }
}
