using api_todos.Context;
using Microsoft.AspNetCore.Mvc;

namespace api_todos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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

        //PUT Id

        //DELETE Id

    }
}