using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[2, 2, 4] { { { 1, 2, 3, 4}, { 4, 5, 6, 7} },
                                       { { 7, 8, 9, 10 }, { 10, 11, 12, 13 } } };

            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }

            /*
            int[,,] array = new int[2,3,4];
            foreach (int c in array)
            {
                
                
                
                Random r = new Random();
                int rr = r.Next(10);
                c = rr;
                Console.WriteLine(c + " ");
            }
            */


            
            


        }
    }
}
