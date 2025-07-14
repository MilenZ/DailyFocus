using DailyFocus.Application.Interfaces;
using DailyFocus.Domain.Entities;

namespace DailyFocus.Application.Services
{
    public class TaskService : ITaskService
    {
        public TaskService()
        {
        }

        public Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
