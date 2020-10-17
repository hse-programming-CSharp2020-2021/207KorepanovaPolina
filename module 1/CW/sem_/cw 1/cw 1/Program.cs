using System;
using System.IO;

namespace cw_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stri = "";
            string s = Console.ReadLine();
            int nm = int.Parse(s);
             while (nm != 0)
            {
                stri = (nm % 2).ToString() + stri;
                nm /= 2;
            }
         
            
            
            File.WriteAllText("IntNumber.txt", stri);

        }
    }
}
