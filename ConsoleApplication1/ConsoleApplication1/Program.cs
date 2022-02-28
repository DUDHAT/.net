using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("hello world");

            double b = Math.Sqrt(36);
            Console.WriteLine(b);
            //double a = Math.Abs(2);
          //Console.WriteLine(Math.Abs(-2));
           // Console.WriteLine("enter the string");
            //String a = Console.ReadLine();
            //Console.WriteLine("hello\t" + (Convert.ToInt32(a) + 4));
            //float var = Convert.ToInt32(3.55);         
            player tomy = new player();
            Console.WriteLine(tomy.helth);
            Console.WriteLine(tomy.name);
            //Console.WriteLine(tomy.helth());
            Console.Read();
        }
    }

}
