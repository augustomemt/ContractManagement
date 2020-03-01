using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContractApi.Business.Implementations;
using ContractApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContractApi.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class EmpresasController : Controller
    {

        //Injeção de dependencia 

        private IEmpresaBusiness _empresaBusiness;

        public EmpresasController( IEmpresaBusiness empresa)
        {
            _empresaBusiness = empresa;
        }



        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_empresaBusiness.FindAll());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var contract = _empresaBusiness.FindById(id);
            if (contract == null) return NotFound();
            return Ok(contract);
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody]Empresas empresas)
        {
            if (empresas == null) return BadRequest();

            return new ObjectResult(_empresaBusiness.Create(empresas));


        }
        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody]Empresas empresas)
        {


            if (empresas == null) return BadRequest();

            return new ObjectResult(_empresaBusiness.Update(empresas));
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _empresaBusiness.Delete(id);
            return NoContent();
        }
    }
}
