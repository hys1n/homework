using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Modules
{
    internal class Activity
    {
        public Activity(Date startDate, Date finishDate, string title, string venue)
        {
            this.StartDate = startDate; 
            this.FinishDate = finishDate;
            this.Title = title;
            this.Venue = venue;
        }
        public string Title { get; set; }
        public string Venue { get; set; }
        public Date StartDate { get; set; }
        public Date FinishDate { get; set; }
        public string DuractionTime()
        {
            Date result = new Date(); 
            result.Year = FinishDate.Year - StartDate.Year;
            result.Month = FinishDate.Month - StartDate.Month; 
            result.Day = FinishDate.Day - StartDate.Day;
            result.Hour = FinishDate.Hour - StartDate.Hour; 
            result.Minute = FinishDate.Minute - StartDate.Minute;
            result.Second = FinishDate.Second - StartDate.Second;

            return "Year: " + result.Year.ToString() + " Month: " + result.Month.ToString() + " Day: " +
                result.Day.ToString() + " Hour: " + result.Hour.ToString() + " Minute: " + result.Minute.ToString() +
                " Sec: " + result.Second.ToString() + " ";
        }
    }
}
