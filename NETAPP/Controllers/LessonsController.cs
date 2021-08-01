using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        
        /*
         * GET
         * POST
         * PUT
         * DELETE
         * PATCH
         */
        [HttpGet]
        public IActionResult GetNames()
        {
            return Ok("Welcome to .NET API");
        }
    }
}
