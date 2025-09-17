using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1
{
    public class TimeFormat
    {
        private short minute;
        private short hour;


        public short Minute
        {
            get { return minute; }
            set
            {
                if (value >= 0 && value < 60)
                    minute = value;
                else
                    minute = 0;
            }
        }

        public short Hour
        {
            get { return hour; }
            set
            {
                if(value >= 0 && value <= 23)
                    hour = value;
                else
                    hour = 0;
            }
        }


        public TimeFormat(short _hour, short _minute)
        {
            Minute = _minute;
            Hour = _hour;
        }

        public TimeFormat()
        {
            Minute = 0;
            Hour = 0;
        }

        public void print()
        {
            if (hour < 10)
                Console.Write($"0{hour}");
            else
                Console.Write(hour);

            if (minute < 10)
                Console.Write($":0{minute}");
            else
                Console.Write($":{minute}");
        }
    }
}
