using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestWithAspNET.Model;
using RestWithAspNET.Business;

namespace RestWithAspNET.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private IPersonBusiness _personBusiness;

        public PersonsController(IPersonBusiness personBusiness)
        {
            _personBusiness = personBusiness;
        }

        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_personBusiness.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(long id)
        {
            var person = _personBusiness.FindById(id);
            if (person == null)            
                return NotFound();
            
            return Ok(person);
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Person person)
        {
            if (person == null)            
                return BadRequest();
            return new ObjectResult(_personBusiness.Create(person));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();
            return new ObjectResult(_personBusiness.Update(person));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            _personBusiness.Delete(id);
            return NoContent();
        }
    }
}
