using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1
{
    public class DateFormat
    {
        private short day;
        private short month;
        private short year;


        public short Day
        {
            get { return day; }
            set 
            {
                if (value > 0)
                { 
                    if(Month == 4 || Month == 6 || Month == 9 || Month == 11)
                    {
                        if (value <= 30)
                            day = value;
                        else
                            day = 1;
                    }
                    else if(Month == 2)
                    {
                        if(Year % 4 == 0)   // високосный год
                        {
                            if (value <= 29)
                                day = value;
                            else
                                day = 1;
                        }
                        else
                        {
                            if (value <= 28)
                                day = value;
                            else
                                day = 1;
                        }
                    }
                    else
                    {
                        if(value <= 31)
                            day = value; 
                        else
                            day = 1;
                    }
                }
                else
                {
                    day = 1;
                }
            }
        }

        public short Month
        {
            get { return month; }
            set
            {
                if (value >= 1 && value <= 12)
                    month = value;
                else
                    month = 1;
            }
        }

        public short Year
        {
            get { return year; }
            set
            {
                if (value >= 1990 && value <= 2025)
                    year = value;
                else
                    year = 1995;
            }
        }


        public DateFormat(short _day, short _month, short _year) 
        {
            Day = _day;
            Month = _month;
            Year = _year;
        }

        public DateFormat()
        {
            day = 1;
            month = 1;
            year = 1995;
        }


        public void print()
        {
            if (day < 10)
                Console.Write($"0{day}");
            else
                Console.Write(day);

            if (month < 10)
                Console.Write($".0{month}");
            else
                Console.Write($".{month}");

            if(year >= 2000 && year <= 2009)
                Console.Write($".0{year % 100}");
            else
                Console.Write($".{year % 100}");
        }
    }
}
