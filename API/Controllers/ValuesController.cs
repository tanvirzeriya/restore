
using API.TestDummy;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Processor _processor;
        public ValuesController(Processor processor)
        {
            _processor = processor;           
        }

        [HttpGet]
        public ActionResult GetProcessor()
        {            
            _processor.ProcessJob(string.Empty);
            return Ok();
        }
    }
}
