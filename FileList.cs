using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1
{
    public static class FileList
    {
        // создание списка файлов
        public static List<File> CreateList()
        {
            List<File> files = new List<File>()
            {
                new File("nc", "cfg", 3060, new DateFormat(10, 3, 2006), new TimeFormat(20, 56)),
                new File("command", "com", 5120, new DateFormat(15, 5, 1995), new TimeFormat(14, 30)),
                new File("edit", "exe", 15600, new DateFormat(22, 8, 1998), new TimeFormat(9, 15)),
                new File("readme", "txt", 2048, new DateFormat(3, 12, 1999), new TimeFormat(16, 45)),
                new File("config", "sys", 1024, new DateFormat(18, 1, 1997), new TimeFormat(11, 20)),
                new File("game", "exe", 24576, new DateFormat(7, 7, 2000), new TimeFormat(13, 10)),
                new File("data", "dat", 8192, new DateFormat(25, 2, 2001), new TimeFormat(18, 35)),
                new File("autoexec", "bat", 512, new DateFormat(30, 4, 1996), new TimeFormat(8, 40)),
                new File("win", "com", 10240, new DateFormat(12, 9, 1994), new TimeFormat(15, 25)),
                new File("help", "txt", 3072, new DateFormat(5, 11, 2002), new TimeFormat(10, 50)),
                new File("player", "exe", 32768, new DateFormat(19, 6, 2003), new TimeFormat(17, 15)),
                new File("system", "ini", 2048, new DateFormat(8, 3, 1998), new TimeFormat(12, 5)),
                new File("virus", "exe", 40960, new DateFormat(14, 10, 2000), new TimeFormat(19, 30)),
                new File("notes", "txt", 1536, new DateFormat(21, 1, 2004), new TimeFormat(9, 55)),
                new File("driver", "sys", 12288, new DateFormat(27, 5, 1999), new TimeFormat(14, 20)),
                new File("music", "mid", 16384, new DateFormat(2, 8, 2001), new TimeFormat(16, 10)),
                new File("backup", "bak", 6144, new DateFormat(16, 12, 1997), new TimeFormat(11, 45)),
                new File("viewer", "exe", 20480, new DateFormat(9, 2, 2005), new TimeFormat(13, 35)),
                new File("setup", "exe", 28672, new DateFormat(23, 7, 2002), new TimeFormat(15, 0)),
                new File("temp", "tmp", 1024, new DateFormat(31, 3, 2003), new TimeFormat(18, 25)),
                new File("letter", "txt", 2560, new DateFormat(11, 9, 1996), new TimeFormat(10, 15)),
                new File("mouse", "drv", 8192, new DateFormat(28, 4, 1995), new TimeFormat(12, 50)),
                new File("paint", "exe", 18432, new DateFormat(6, 6, 2000), new TimeFormat(14, 5)),
                new File("config2", "cfg", 4096, new DateFormat(17, 10, 2004), new TimeFormat(17, 40)),
                new File("sound", "wav", 24576, new DateFormat(13, 1, 2001), new TimeFormat(9, 20)),
                new File("readme2", "txt", 3584, new DateFormat(24, 8, 1998), new TimeFormat(16, 55)),
                new File("game2", "exe", 36864, new DateFormat(4, 5, 2003), new TimeFormat(13, 25)),
                new File("backup2", "bak", 7168, new DateFormat(20, 11, 1999), new TimeFormat(11, 10)),
                new File("system2", "ini", 3072, new DateFormat(7, 2, 2002), new TimeFormat(15, 45)),
                new File("video", "avi", 49152, new DateFormat(29, 7, 2005), new TimeFormat(19, 15)),
                new File("document", "doc", 12288, new DateFormat(12, 4, 2000), new TimeFormat(10, 30)),
                new File("image", "bmp", 32768, new DateFormat(25, 9, 2001), new TimeFormat(14, 50)),
                new File("archive", "zip", 20480, new DateFormat(8, 12, 2003), new TimeFormat(17, 5)),
                new File("calculator", "exe", 10240, new DateFormat(19, 3, 1997), new TimeFormat(12, 35)),
                new File("notepad", "exe", 8192, new DateFormat(26, 6, 1998), new TimeFormat(16, 20)),
                new File("config3", "cfg", 5120, new DateFormat(14, 10, 2004), new TimeFormat(9, 45)),
                new File("readme3", "txt", 4096, new DateFormat(21, 1, 2005), new TimeFormat(18, 10)),
                new File("game3", "exe", 40960, new DateFormat(3, 8, 2002), new TimeFormat(13, 55)),
                new File("driver2", "sys", 14336, new DateFormat(17, 5, 1999), new TimeFormat(11, 25)),
                new File("music2", "mid", 20480, new DateFormat(30, 11, 2000), new TimeFormat(15, 40)),
                new File("backup3", "bak", 8192, new DateFormat(9, 2, 2001), new TimeFormat(10, 5)),
                new File("viewer2", "exe", 24576, new DateFormat(22, 7, 2003), new TimeFormat(17, 30)),
                new File("setup2", "exe", 32768, new DateFormat(5, 4, 2004), new TimeFormat(14, 15)),
                new File("temp2", "tmp", 2048, new DateFormat(28, 9, 2005), new TimeFormat(19, 50)),
                new File("letter2", "txt", 3072, new DateFormat(11, 12, 1996), new TimeFormat(8, 35)),
                new File("keyboard", "drv", 10240, new DateFormat(24, 3, 1995), new TimeFormat(12, 0)),
                new File("draw", "exe", 20480, new DateFormat(16, 6, 2000), new TimeFormat(16, 45)),
                new File("config4", "cfg", 6144, new DateFormat(27, 10, 2004), new TimeFormat(9, 10)),
                new File("sound2", "wav", 28672, new DateFormat(8, 1, 2001), new TimeFormat(13, 40)),
                new File("readme4", "txt", 4608, new DateFormat(19, 8, 1998), new TimeFormat(18, 25)),
                new File("game4", "exe", 45056, new DateFormat(2, 5, 2003), new TimeFormat(15, 15)),
                new File("backup4", "bak", 9216, new DateFormat(25, 11, 1999), new TimeFormat(11, 50)),
                new File("system3", "ini", 4096, new DateFormat(6, 2, 2002), new TimeFormat(17, 5)),
                new File("video2", "avi", 57344, new DateFormat(29, 7, 2005), new TimeFormat(20, 35)),
                new File("document2", "doc", 14336, new DateFormat(13, 4, 2000), new TimeFormat(10, 20)),
                new File("image2", "bmp", 40960, new DateFormat(26, 9, 2001), new TimeFormat(14, 30)),
                new File("archive2", "zip", 24576, new DateFormat(9, 12, 2003), new TimeFormat(16, 55)),
                new File("calc2", "exe", 12288, new DateFormat(20, 3, 1997), new TimeFormat(12, 45)),
                new File("note2", "exe", 10240, new DateFormat(27, 6, 1998), new TimeFormat(17, 10))
            };
            files.Sort((f1, f2) => f1.Name.CompareTo(f2.Name));     // сортировка по алфавиту

            return files;
        }
    }
}
