using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 41;
            //int y = 181;
            //Console.SetWindowSize(y,x);
            //var path = "C:\\Users\\Dx777\\Desktop\\新建文本文档.txt";
            //StreamReader sr = new StreamReader(path, Encoding.Default);
            //String line;
            //while ((line = sr.ReadLine()) != null)
            //{
            //    Console.WriteLine(line.ToString());
            //}
            //Console.ReadKey();
            Read("C:\\Users\\Dx777\\Source\\Repos\\RPGConsoleGame\\RPGConsoleGame\\RPGConsoleGame\\Map.txt");
            //Console.Write(ViewData.ViewResource.GetLength(1));
            new GameController().Run();
            Console.ReadKey();
        }
        public static void Read(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            String line;
            int y = 0, x = 0;
            //int s = 1;
            var list = new char[500, 500];
            while ((line = sr.ReadLine()) != null)
            {

                var s = line.Split(',');
                //var lists = new List<char>();
                x = 0;
                //Console.WriteLine(s.Length);
                for (int i = 0; i < s.Length; i++)
                {
                    list[y, x] = Convert.ToChar(s[i]);
                    x += 1;
                }
                //Console.WriteLine(lists.Count);
                y += 1;
                //list.Add(lists);
                //lists.Clear();
                //Console.WriteLine();
                //Console.WriteLine(sr.ReadLine().Length);
                //Console.WriteLine(line.ToString());
            }
            ViewData.ViewResource = list;
            //Console.Write(ViewData.ViewResource.Count);
            //var chars = new int[b, s];
            //int x = 1, y = 1;
            //while ((line = sr.ReadLine()) != null)
            //{
            //    var ss = line.Split(',');
            //    foreach (var item in ss)
            //    {
            //        chars[y, x] = Convert.ToChar(item);
            //        x += 1;
            //    }
            //    y += 1;
            //}
            //ViewData.ViewResource = chars;
            //Console.WriteLine(ViewData.ViewResource.GetLength(1));
            //foreach (var item in ViewData.ViewResource)
            //{
            //    Console.Write(item);
            //}
        }
    }
}
