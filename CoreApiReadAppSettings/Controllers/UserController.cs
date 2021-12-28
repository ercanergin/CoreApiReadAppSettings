using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiReadAppSettings.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private IConfiguration configuration;
        public UserController(IConfiguration iConfig)
        {
            configuration = iConfig;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            //Method 1
            string dbConn = configuration.GetSection("MySettings").GetSection("DbConnection").Value;

            //Method 2
            string dbConn2 = configuration.GetValue<string>("MySettings:DbConnection");

            var list = new List<string>();
            list.Add("Ercan");
            list.Add("Ergin");
            return Ok(list);
        }
    }
}
