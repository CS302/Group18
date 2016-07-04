using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = XmlDeSer();
            p.Print();
        }

        static void XmlSer(Point p)
        {
            FileStream stream = new FileStream("data.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer serializer = new XmlSerializer(p.GetType());
            serializer.Serialize(stream, p);
            stream.Close();
        }

        static Point XmlDeSer()
        {
            FileStream stream = new FileStream("data.xml", FileMode.Open, FileAccess.Read);
            Point p = new Point();
            XmlSerializer serializer = new XmlSerializer(p.GetType());
            p = (Point)serializer.Deserialize(stream);
            stream.Close();
            return p;
        }

        static void BinarySerialization(Point p)
        {
            FileStream stream = new FileStream("data.bin", FileMode.Create, FileAccess.Write);

            BinaryFormatter format = new BinaryFormatter();
            format.Serialize(stream, p);

            stream.Close();
        }

        static Point BinaryDeserialization()
        {
            FileStream stream = new FileStream("data.bin", FileMode.Open, FileAccess.Read);

            BinaryFormatter format = new BinaryFormatter();
            Point p = (Point)format.Deserialize(stream);

            stream.Close();
            return p;
        }
    }

    [Serializable]
    public class Point
    {
        public int x;
        public int y;
        public string label;

        public Point()
        {   }

        public Point(int x, int y, string label)
        {
            this.x = x;
            this.y = y;
            this.label = label;
        }

        public void Print()
        {
            Console.WriteLine("X = {0}\nY = {1}\n{2}", x, y, label);
        }
    }
}
