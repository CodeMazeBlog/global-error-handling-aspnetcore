using System;
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
        public IActionResult Get()
        {

            _logger.LogInfo("Fetching all the Students from the storage");

            var students = DataManager.GetAllStudents(); //simulation for the data base access

            throw new Exception("Exception while fetching all the students from the storage.");

            _logger.LogInfo($"Returning {students.Count} students.");

            return Ok(students);
        }
    }
}
