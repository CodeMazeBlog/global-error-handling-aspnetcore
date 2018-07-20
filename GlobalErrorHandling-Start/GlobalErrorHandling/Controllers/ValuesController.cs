using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoggerService;
using Microsoft.AspNetCore.Mvc;

namespace GlobalErrorHandling.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private ILoggerManager _logger;

        public ValuesController(ILoggerManager logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
