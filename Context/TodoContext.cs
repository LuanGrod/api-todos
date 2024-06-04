using Microsoft.EntityFrameworkCore;

namespace api_todos.Context
{
    public class TodoContext : DbContext
    {
        protected TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

    }
}