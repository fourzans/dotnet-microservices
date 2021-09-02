using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DeveloperApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeveloperController : ControllerBase
    {
        private readonly ILogger<DeveloperController> _logger;

        public DeveloperController(ILogger<DeveloperController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Action to see all existing developers.
        /// </summary>
        /// <returns>Returns a list of all developers</returns>
        /// <response code="200">Returned if the developers were loaded</response>
        /// <response code="400">Returned if the developers couldn't be loaded</response>
        public void Get()
        {

        }
    }
}
