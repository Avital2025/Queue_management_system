using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace lesson2._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly EventDirectory eventDirectory = new EventDirectory();

        // GET: api/<EventsController>
        [HttpGet]
        public List<Event> Get()
        {
            return eventDirectory.GetList();

        }

        // GET api/<EventsController>/5
        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return eventDirectory.GetEventById(id);
        }

        // POST api/<EventsController>
        [HttpPost]
        public Event Post([FromBody] Event value)
        {
            var item = eventDirectory.PostEvent(value);
            return item;
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public Event Put(int id, [FromBody] Event value)
        {
            var item = eventDirectory.PutEvent(id, value);
            return item;
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            eventDirectory.DeleteEvent(id);
        }
    }
}
