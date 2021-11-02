using Kanban.Features.TaskModule;

namespace Kanban.Features.Common.Features
{
    public interface ICommandFeature<in T>
    {
        System.Threading.Tasks.Task ExecuteAsync(T command);
    }
}