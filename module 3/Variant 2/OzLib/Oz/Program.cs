using System;

namespace Oz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            string name = ((char)r.Next(97, 122)).ToString().ToUpper();
            Console.WriteLine(name);
        }
    }
}
