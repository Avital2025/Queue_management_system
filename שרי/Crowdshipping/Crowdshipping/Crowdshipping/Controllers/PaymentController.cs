using Crowdshipping.Enteties;
using Crowdshipping.service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Crowdshipping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        PaymentService p=new PaymentService();
        // GET: api/<PaymentController>
        [HttpGet]
        public ActionResult<List<Payment>>Get()
        {
           List<Payment> result = new List<Payment>();
            if (result == null)
            {
                return null;
            }
            return result;
        }

        // GET api/<PaymentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PaymentController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Payment value)
        {
            return p.PostPaymentsList(value);
        }

        // PUT api/<PaymentController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Payment value)
        {
            return p.PutPaymentsList(value, id);
        }

        // DELETE api/<PaymentController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return p.DeleteCouriersList(id);
        }
    }
}
