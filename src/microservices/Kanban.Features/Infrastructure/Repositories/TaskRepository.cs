using Kanban.Features.TaskModule;
using MongoDB.Driver;

namespace Kanban.Features.Infrastructure.Repositories
{
    public class TaskRepository : MongoRepository<Task>, ITaskRepository
    {
        public TaskRepository(IMongoDatabase database) : base(database)
        {
        }
    }
}