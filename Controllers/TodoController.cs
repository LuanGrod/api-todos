using api_todos.Context;
using api_todos.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api_todos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;
        }

        //TODOS

        //GET Id
        [HttpGet("{id}")]
        public ActionResult ObterPorId(int id)
        {

            var todo = _context.Todos.Find(id);

            if (todo == null)
            {
                return NotFound();
            }

            return Ok(todo);

        }

        //GET ObterCompleto
        [HttpGet("")]
        public ActionResult ObterCompleto()
        {

            var todos = _context.Todos.ToList();

            return Ok(todos);

        }

        //GET ObterPorNome

        //GET ObterPorStatus

        //POST
        [HttpPost]
        public ActionResult Create(Todo todo)
        {

            _context.Todos.Add(todo);
            _context.SaveChanges();

            return CreatedAtAction(nameof(ObterPorId), new { id = todo.Id }, todo);

        }

        //PUT Id

        //DELETE Id

    }
}