using FileBaseContext.Abstractions.Models.Entity;

namespace ToDoApp.Api.Common;

public interface IEntity : IFileSetEntity<Guid>
{
}
