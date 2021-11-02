using System.Collections.Generic;
using System.Threading.Tasks;
using Kanban.Features.Common.Features;

namespace Kanban.Features.TaskModule.GetTasksByFilter
{
    public class GetTaskByFeature : IQueryFeature<GetTaskByFilterQuery, IEnumerable<Task>>
    {
        private readonly ITaskRepository _repository;

        public GetTaskByFeature(ITaskRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Task>> ExecuteAsync(GetTaskByFilterQuery query)
        {
            return await _repository.GetAllAsync();
        }
    }
}