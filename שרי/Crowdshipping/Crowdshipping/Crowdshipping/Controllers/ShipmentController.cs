using Crowdshipping.Enteties;
using Crowdshipping.service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Crowdshipping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        ShipmentService s = new ShipmentService();
        // GET: api/<ShipmentController>
        [HttpGet]
        public ActionResult<List<Shipment>> Get()
        {
            List<Shipment> result = s.GetShipmentList() ;
            if (result==null)
            {
                return null;
            }
            return result;
        }

        // GET api/<ShipmentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ShipmentController>
        [HttpPost]
        public void Post([FromBody] Shipment value)
        {
            s.PostShipmentList(value);
        }

        // PUT api/<ShipmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Shipment value)
        {
            s.PutShshipmentsLinst(value,id);
        }

        // DELETE api/<ShipmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            s.DeleteShipmentList(id);
        }
    }
}
