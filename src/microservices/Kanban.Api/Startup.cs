using Kanban.Features.Infrastructure;
using Kanban.Features.TaskModule;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Kanban.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(_ => new MongoSettings("mongodb://localhost:27017", "KanbanStorage"));
            services.AddTaskModule();
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}