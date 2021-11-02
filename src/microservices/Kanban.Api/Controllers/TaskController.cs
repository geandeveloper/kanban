using System.Threading.Tasks;
using Kanban.Features.TaskModule.CreateTask;
using Microsoft.AspNetCore.Mvc;

namespace Kanban.Api.Controllers
{
    [Route("tasks")]
    public class TaskController : ControllerBase
    {
        private readonly CreateTaskFeature _createTask;

        public TaskController(CreateTaskFeature createTask)
        {
            _createTask = createTask;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTaskAsync([FromBody] CreateTaskCommand command)
        {
            try
            {
                await _createTask.ExecuteAsync(command);

                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}