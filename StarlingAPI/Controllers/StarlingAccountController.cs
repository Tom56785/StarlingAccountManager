using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StarlingAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StarlingAccountController : ControllerBase
    {

        private readonly ILogger<StarlingAccountController> _logger;

        public StarlingAccountController(ILogger<StarlingAccountController> logger)
        {
            _logger = logger;
        }
    }
}
