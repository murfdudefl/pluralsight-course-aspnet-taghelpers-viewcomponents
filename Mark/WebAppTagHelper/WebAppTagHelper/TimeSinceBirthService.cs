using Microsoft.AspNetCore.SignalR;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppTagHelper
{
    public class TimeSinceService : ITimeSinceService
    {
        private TimeSpan _timeDiff;
        public DateTime StartDate { get; set; }

        public TimeSinceService(DateTime startDate)
        {
            StartDate = startDate;
            _timeDiff = DateTime.Today.Subtract(StartDate);
        }

        public int DaysSince()
        {
            //return (DateTime.Today - StartDate).Days;
            return _timeDiff.Days;
        }

        public string FormattedTimeSince()
        {
            var today = DateTime.Today;
            return $"{today.Year - StartDate.Year} years, {today.Month - StartDate.Month} months and {today.Day - StartDate.Day} days";
        }

        public int MonthsSince()
        {
            return ((DateTime.Today.Year - StartDate.Year) * 12) + DateTime.Today.Month - StartDate.Month;
        }

        public int YearsSince()
        {
            return DateTime.Today.Year - StartDate.Year;
        }
    }
}
