using Kanban.Features.Infrastructure;
using Kanban.Features.Infrastructure.Repositories;
using Kanban.Features.TaskModule.CreateTask;
using Kanban.Features.TaskModule.GetTasksByFilter;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace Kanban.Features.TaskModule
{
    public static class TaskExtensionModule
    {
        public static IServiceCollection AddTaskModule(this IServiceCollection services)
        {
            services.AddSingleton(provider =>
            {
                var settings = provider.GetService<MongoSettings>();
                var client = new MongoClient(settings?.ConnectionString);
                return client.GetDatabase(settings?.DatabaseName);
            });

            services.AddSingleton<CreateTaskFeature>();
            services.AddSingleton<GetTaskByFilterQuery>();
            services.AddSingleton<ITaskRepository, TaskRepository>();
            
            return services;
        }

    }
}