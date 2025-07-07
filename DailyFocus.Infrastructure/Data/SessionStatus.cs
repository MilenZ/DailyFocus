using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyFocus.Infrastructure.Data
{
    public enum SessionStatus
    {
        Active = 0,
        Completed = 1,
        Paused = 2,
        Cancelled = 3
    }
}
