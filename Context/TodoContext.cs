using api_todos.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_todos.Context
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        public DbSet<Todo> Todos { get; set; }
    }
}