using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContractApi.Business.Implementations;
using ContractApi.Data.VO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContractApi.Controllers
{
  
    [ApiVersion("1.0")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class ContratosController : Controller
    {
        //Injeção de dependencia 
        private IContratoBusiness _contratoBusiness;

        public ContratosController(IContratoBusiness contrato)
        {
            _contratoBusiness = contrato;
        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult  Get()
        {
            return Ok(_contratoBusiness.FindAll());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var contract = _contratoBusiness.FindById(id);
            if (contract == null) return NotFound();
            return Ok (contract);
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]ContratosVO contrado)
        {
            if (contrado == null) return BadRequest();

            return new ObjectResult(_contratoBusiness.Create(contrado));


        }
        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody]ContratosVO contrado)
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
