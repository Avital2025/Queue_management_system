using Crowdshipping.Enteties;
using Crowdshipping.service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Crowdshipping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageOrdererController : ControllerBase
    {

        PackageOrdererService p=new PackageOrdererService();
        // GET: api/<PackageOrdererController>
        [HttpGet]
        public ActionResult<List<PackageOrderer>> Get()
        {
            List<PackageOrderer>result = new List<PackageOrderer>();
            if (result == null)
            {
                return null;
            }
            return result;
        }

        // GET api/<PackageOrdererController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PackageOrdererController>
        [HttpPost]
        public ActionResult<bool>Post([FromBody] PackageOrderer value)
        {
           return p.PostpackageOrdererList(value);
        }

        // PUT api/<PackageOrdererController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id,[FromBody] PackageOrderer value)
        {
          return p.PutpackageOrdererList(value,id);

        }

        // DELETE api/<PackageOrdererController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
          return p.DeletePackageOrderer(id);
        }
    }
}
