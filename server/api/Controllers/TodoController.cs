namespace api;

[ApiController]
public class TodoController(MyDbContext dbContext) : ControllerBase
{
    [Route(nameof(GetAllTodos))]
    [HttpGet]
    public async Task<ActionResult<List<Todo>>> GetAllTodos()
    {
        var objects = dbContext.Todos.ToList();
        return objects;
    }

    [Route(nameof(CreateTodo))]
    [HttpPost]
    public async Task<ActionResult<Todo>> CreateTodo([FromBody]CreateTodoDto dto)
    {
        var myTodo = new Todo()
        {
            Description = "test",
            Title = "Title test",
            Id = Guid.NewGuid().ToString(),
            Isdone = false,
            Priority = 5
        };
        dbContext.Todos.Add(myTodo);
        dbContext.SaveChanges();
        return myTodo;
    }
}

public record CreateTodoDto(int priority, string title, string description);