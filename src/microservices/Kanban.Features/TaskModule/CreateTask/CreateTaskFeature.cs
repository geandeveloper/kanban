using Kanban.Features.Common.Features;

namespace Kanban.Features.TaskModule.CreateTask
{
    public class CreateTaskFeature : ICommandFeature<CreateTaskCommand>
    {
        private readonly ITaskRepository _repository;

        public CreateTaskFeature(ITaskRepository repository)
        {
            _repository = repository;
        }

        public async System.Threading.Tasks.Task ExecuteAsync(CreateTaskCommand command)
        {
            var (title, description) = command;
            var task = new Task(title, description);
            
            await _repository.AddAsync(task);
        }
    }
}