using Kanban.Features.Common.Models;

namespace Kanban.Features.TaskModule
{
    public class Task: KanbanModel
    {
        public Identifier Id { get; }
        public string Title { get; }
        public string Description { get; }

        public Task(string title, string description)
        {
            Id = Identifier.New();
            Title = title;
            Description = description;
        }
    }
}