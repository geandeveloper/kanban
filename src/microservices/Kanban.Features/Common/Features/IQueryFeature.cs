using System.Threading.Tasks;

namespace Kanban.Features.Common.Features
{
    public interface IQueryFeature<in TQuery, TOut>
    {
        Task<TOut> ExecuteAsync(TQuery query);
    }
}