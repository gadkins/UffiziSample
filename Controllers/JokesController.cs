using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokesController : ControllerBase
    {
        private ApplicationDbContext _context;

        public JokesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetJokes()
        {
            var jokes = await _context.joke.ToListAsync();
            return Ok(jokes);
        }
    }
}
