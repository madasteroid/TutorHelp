using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutorHelpBackend.Models;

namespace TutorHelpBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly TutorHelpContext _context;

        public UserController(TutorHelpContext context)
        {
            _context = context;
        }

        [HttpGet]
        public  IActionResult GetResult()
        {
            var result = _context.User.ToList();
            return Ok(result);
        }
    }
}