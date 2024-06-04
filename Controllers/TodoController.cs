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

        //POST
        [HttpPost]
        public ActionResult Create(Todo todo)
        {

            _context.Todos.Add(todo);
            _context.SaveChanges();

            return CreatedAtAction(nameof(ObterPorId), new { id = todo.Id }, todo);

        }

        //GET ObterCompleto
        [HttpGet("")]
        public ActionResult ObterCompleto()
        {

            var todos = _context.Todos.ToList();

            return Ok(todos);

        }

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

        //GET ObterPorConteudo
        [HttpGet("ObterPorConteudo")]
        public ActionResult ObterPorConteudo(string texto)
        {

            var todos = _context.Todos.Where(x => x.Conteudo.Contains(texto));

            return Ok(todos);

        }

        //GET ObterPorStatus
        [HttpGet("ObterPorStatus")]
        public ActionResult ObterPorStatus(bool status)
        {

            var todos = _context.Todos.Where(x => x.Status == status);

            return Ok(todos);

        }

        //PUT Id
        [HttpPut("{id}")]
        public ActionResult Update(int id, Todo todo)
        {

            if (id != todo.Id)
            {
                return BadRequest();
            }

            var todoAtual = _context.Todos.Find(id);

            if (todoAtual == null)
            {
                return NotFound();
            }

            todoAtual.Conteudo = todo.Conteudo;
            todoAtual.Status = todo.Status;

            _context.SaveChanges();

            return Ok(todoAtual);

        }

        //DELETE Id
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            var todo = _context.Todos.Find(id);

            if (todo == null)
            {
                return NotFound();
            }

            _context.Todos.Remove(todo);
            _context.SaveChanges();

            return NoContent();

        }

    }
}