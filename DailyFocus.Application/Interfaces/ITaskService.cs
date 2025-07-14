using DailyFocus.Domain.Entities;

namespace DailyFocus.Application.Interfaces
{
    public interface ITaskService
    {
         Task<IEnumerable<TaskItem>> GetAllAsync();
    }
}
