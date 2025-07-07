using DailyFocus.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DailyFocus.Web.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITaskService taskService;

        public TasksController(ITaskService taskService)
        {
            this.taskService = taskService;
        }

        public async Task<IActionResult> All()
        {
            var tasks = await taskService.GetAllAsync();
            return View(tasks);
        }
    }
}
