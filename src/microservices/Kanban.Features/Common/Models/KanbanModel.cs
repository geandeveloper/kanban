namespace Kanban.Features.Common.Models
{
    public class KanbanModel
    {
        public Identifier Id { get; }

        public KanbanModel()
        {
            Id = Identifier.New();
        }
    }
}