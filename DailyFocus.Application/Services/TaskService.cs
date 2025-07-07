using DailyFocus.Application.Interfaces;
using DailyFocus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
