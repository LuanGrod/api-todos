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

        //GET ObterCompleto

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