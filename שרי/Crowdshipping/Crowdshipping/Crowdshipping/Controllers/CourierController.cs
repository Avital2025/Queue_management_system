
using Crowdshipping.Enteties;
using Crowdshipping.service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Crowdshipping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourierController : ControllerBase
    {
        CourierService c=new CourierService();
        // GET: api/<CourierController>
        [HttpGet]
        public ActionResult<List<Courier>> Get()
        {
          List<Courier> result=new List<Courier>(); 
            if (result == null)
            {
                return null;
            }
            return result;
        }

        // GET api/<CourierController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CourierController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Courier value)
        {
            return c.PostCouriersList(value);

        }

        // PUT api/<CourierController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Courier value)
        {
            return c.PutCouriersList(value, id);
        }

        // DELETE api/<CourierController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return c.DeleteCouriersList(id);

        }
    }
}
