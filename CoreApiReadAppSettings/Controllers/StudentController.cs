using CoreApiReadAppSettings.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiReadAppSettings.Controllers
{
    [Produces("application/json")]
    [Route("api/Student")]
    public class StudentController : Controller
    {
        private readonly IOptions<MySettingsModel> appSettings;

        public StudentController(IOptions<MySettingsModel> app)
        {
            appSettings = app;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            var dbValue = appSettings.Value.DbConnection;

            var list = new List<string>();
            list.Add("Ercan");
            list.Add("Ergin");
            return Ok(list);
        }
    }
}
