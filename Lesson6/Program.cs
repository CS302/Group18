using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FileSystem
            /*string[] filePath = Directory.GetFiles(@"C:\Lesson6", "*.js", SearchOption.AllDirectories);

            for (int i = 0; i < filePath.Length; i++)
            {
                Console.WriteLine(filePath[i]);
            }*/

            /*DirectoryInfo dir = new DirectoryInfo(@"C:\Lesson6");
            if (dir.Exists)
            {
                FileInfo[] files = dir.GetFiles("*.exe", SearchOption.AllDirectories);
                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine(files[i].FullName);
                    Console.WriteLine(files[i].CreationTime);
                    Console.WriteLine(files[i].Length);
                    Console.WriteLine();
                }
            }*/

            /*FileInfo file1 = new FileInfo(@"C:\Lesson6\1.txt");
            FileInfo file2 = new FileInfo(@"C:\Lesson6\extjs\2.txt");

            file1.Create();
            file2.Create();

            FileInfo file3 = new FileInfo(@"C:\Lesson6\Test\1.txt");
            if (!file3.Directory.Exists)
            {
                file3.Directory.Create();
            }
            file3.Create();

            Directory.CreateDirectory(@"C:\Lesson6\1\2\3\4\5\6\7\8\9");*/

            /*string path = @"C:\Lesson6\Test\2\3\4\1.txt";
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.GetExtension(path));

            string dir = @"C:\Lesson6\Test\2\3\4";
            string temp = "temp_24";
            string fileName = "data.txt";

            path = dir + "\\" + temp + "\\" + fileName;


            path = Path.Combine(dir, temp, fileName);
            Console.WriteLine(path);


            Directory.CreateDirectory(@"Lesson6\1\2\3\4\5\6\7\8\9");*/

            #endregion

            Point p = LoadTxt();
            Console.WriteLine("X = {0}\nY = {1}\n{2}", p.x, p.y, p.label);

        }

        static void SaveTxt(Point p)
        {
            string path = @"C:\Lesson6\Point.txt";
            FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            
            StreamWriter writer = new StreamWriter(stream);
            
            writer.WriteLine(p.x);
            writer.WriteLine(p.y);
            writer.WriteLine(p.label);

            writer.Close();
        }

        static Point LoadTxt()
        {
            string path = @"C:\Lesson6\Point.txt";
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(stream);
            
            int x = int.Parse(reader.ReadLine());
            int y = int.Parse(reader.ReadLine());
            string label = reader.ReadLine();

            /*while (!reader.EndOfStream)
            {
                reader.ReadLine();
            }*/

            reader.Close();

            Point p = new Point(x, y, label);
            return p;
        }
    }

    class Point
    {
        public int x;
        public int y;
        public string label;

        public Point(int x, int y, string label)
        {
            this.x = x;
            this.y = y;
            this.label = label;
        }
    }
}
