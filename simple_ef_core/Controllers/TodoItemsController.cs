using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using simple_ef_core.Data;
using simple_ef_core.Models;

namespace simple_ef_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly TodoItemContext _context;

        public TodoItemsController(TodoItemContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet()]
        public ActionResult<IEnumerable<TodoItem>> Get()
        {
            System.Console.WriteLine("in get");
            return Ok(_context.TodoItems.ToList());
            // return Ok(await _context.TodoItems.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TodoItem value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                await _context.AddAsync(value);
                await _context.SaveChangesAsync();
                return NoContent();
            }
        }
    }
}
