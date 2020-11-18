using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        [HttpPost]
        [Route("user/add")]
        public IActionResult Index()
        {
            Events.Add(new Event(name));
            
            return View();
        }
    }
}
