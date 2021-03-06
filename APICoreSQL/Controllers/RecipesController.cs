using Microsoft.AspNetCore.Mvc;
using pjBusiness;
using pjDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APICoreSQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {

        Service serviceBO;
        public RecipesController(KitchenContext context)
        {
            serviceBO = new Service(context);
        }

        // GET: api/<RecipesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(serviceBO.GetAll());
        }

        // GET api/<RecipesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(serviceBO.GetByIdWT(id));
        }

        // POST api/<RecipesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RecipesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RecipesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
