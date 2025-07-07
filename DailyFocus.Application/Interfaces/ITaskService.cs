using DailyFocus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyFocus.Application.Interfaces
{
    public interface ITaskService
    {
         Task<IEnumerable<TaskItem>> GetAllAsync();
    }
}
