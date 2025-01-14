﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Modules
{
    public class Date
    {
        public Date(int year, int month, int day, int hour, int minute, int second)
        {
            this.Year = year; 
            this.Month = month;
            this.Day = day; 
            this.Hour = hour;
            this.Minute = minute; 
            this.Second = second;
        }
        public Date()
        {
            this.Year = 0;
            this.Month = 0; 
            this.Day = 0;
            this.Hour = 0; 
            this.Minute = 0;
            this.Second = 0;
        }


        public int Year {  get; set; }
        public int Month {  get; set; }
        public int Day {  get; set; }
        public int Hour {  get; set; }
        public int Minute {  get; set; }
        public int Second {  get; set; }
    }
}
