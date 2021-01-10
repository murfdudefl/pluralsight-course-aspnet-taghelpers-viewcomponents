using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppTagHelper
{
    public interface ITimeSinceService
    {
        DateTime StartDate { get; set; }

        int DaysSince();

        int MonthsSince();

        int YearsSince();

        string FormattedTimeSince();
    }
}
