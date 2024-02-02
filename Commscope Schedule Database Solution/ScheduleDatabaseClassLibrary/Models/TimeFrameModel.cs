using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDatabaseClassLibrary.Models
{
    public class TimeFrameModel
    {
        public DateTime NewYearsDay  { get; set; }
        public DateTime MondaysDate { get; set; }
        public DateTime SundaysDate { get; set; }

        public TimeFrameModel()
        {
            int thisYear = DateTime.Now.Year;
            this.NewYearsDay = new DateTime(thisYear, 1, 1);
            DateTime today = DateTime.Now;
            int weekDay = (int)today.DayOfWeek;
            int daysToMonday = weekDay - 1;
            this.MondaysDate = today.AddDays(-daysToMonday);
            this.SundaysDate = MondaysDate.AddDays(6);
        }
    }
}
