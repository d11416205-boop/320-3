using System.Net.Http.Headers;

namespace _320_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test std= new Test();
            std.MyMid = 92;
            Console.WriteLine(std.MyMid);
            std.MyFinal = 78;
            Console.WriteLine(std.MyFinal);
            //std.Price = 100;
            //Console.WriteLine(std.Price);
        }
    }
    }

