using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyFocus.Infrastructure.Data
{
    public enum SessionStatus
    {
        Created = 0,
        Active = 1,
        Completed = 2,
        Paused = 3,
        Cancelled = 4
    }
}
