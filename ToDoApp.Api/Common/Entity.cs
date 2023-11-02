using ToDoApp.Api.Common;

namespace ToDoApp.Common;

public abstract class Entity : IEntity
{
    public Guid Id { get; set; }
}
