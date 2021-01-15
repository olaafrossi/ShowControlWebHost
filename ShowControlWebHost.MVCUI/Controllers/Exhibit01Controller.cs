using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowControlWebHost.MVCUI
{
    [ApiController]
    [Route("[controller]")]
    public class Exhibit01Controller : ControllerBase
    {
        private readonly ILogger<Exhibit01Controller> _logger;

        public Exhibit01Controller(ILogger<Exhibit01Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Exhibit01> Get()
        {
            string fmt = "000";
            int intValue = 0;
            var rng = new Random();
            intValue = rng.Next(1, 105);
            Console.WriteLine($"Hello from the Exhibit Controller {intValue.ToString(fmt)}");
            _logger.Log(LogLevel.Information,"hello");
            return Enumerable.Range(1, 1).Select(index => new Exhibit01
                {
                    Message = "hi",
                    PaddedNumber = intValue.ToString(fmt),
                    Number = intValue,
                })
                .ToArray();
            
        }
    }
}
