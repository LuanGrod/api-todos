namespace api_todos.Entities
{
    public class Todo
    {
        public int Id { get; set; }
        public required string Conteudo { get; set; }
        public bool Status { get; set; }
    }
}