using System.Collections.Generic;
using System.Threading.Tasks;
using Kanban.Features.Common.Models;

namespace Kanban.Features.Common.Repositories
{
    public interface IKanbanRepository<TModel>
        where TModel : KanbanModel
    {
        Task<IEnumerable<TModel>> GetAllAsync();
        Task AddAsync(TModel model);
    }
}