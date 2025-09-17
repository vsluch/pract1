using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1
{
    public class File
    {
        private string name;        // имя файла
        private string extension;   // расширение файла
        private int size;           // размер
        private DateFormat date;    // дата изменения
        private TimeFormat time;    // время изменения



        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Extension
        {
            get { return extension; }
            set 
            {
                if (value.Length > 3)
                    extension = "txt";
                else
                    extension = value;
            }
        }
        public int Size
        {
            get { return size; }
            set 
            {
                if (value <= 0)
                    size = 256;
                else
                    size = value;
            }
        }
        public DateFormat Date
        {
            get { return date; }
            set { date = value; }
        }
        public TimeFormat Time
        {
            get { return time; }
            set { time = value; }
        }
        

        public File(string _name, string _extension, int _size, DateFormat _date, TimeFormat _time)
        {
            Name = _name;
            Extension = _extension;
            Size = _size;
            Date = _date;
            Time = _time;
        }

        public File()
        {
            name = "nd";
            extension = "txt";
            size = 256;
            date = new DateFormat();
            time = new TimeFormat();
        }



        public void printExtension()
        {
            Console.Write(extension);
        }

        public void printDate()
        {
            Date.print();
        }
        public void printTime()
        {
            Time.print();
        }


        public string getNameToPrint()
        {
            if (name.Length <= 7)
                return name;
            else
            {
                string sub = name.Substring(0, 7) + "~";
                return sub;
            }
        }
        
        public string getSizeToString()
        {
            string s = $"{size}";
            return s;
        }
    }
}
