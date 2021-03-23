using System;
using System.IO;
using OzLib;
namespace SecondOne
{
    class Program
    {
        static void Main(string[] args)
        {
            char p = Path.DirectorySeparatorChar;

            Console.WriteLine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName + p + "FirstOne" + p + "bin" + p + "Debug" + p + "netcoreapp3.1" + p + "output.txt", System.Text.Encoding.UTF8); ;

            string[] lines = File.ReadAllLines(".." + p + ".." + p + ".." + p + ".." + p + "FirstOne" + p + "bin" + p + "Debug" + p + "netcoreapp3.1" + p + "output.txt", System.Text.Encoding.UTF8); ;


            int[] houses;
            int N = lines.Length;
            Street[] arr = new Street[N];


            for (int i = 0; i < N; i++)
            {
                string[] line = lines[i].Split(" ");
                houses = new int[line.Length - 1];

                for (int z = 1; z < line.Length; z++)
                {
                    if (!int.TryParse(line[z], out int num)) Console.Write("");
                    else houses[z - 1] = num;
                }
                arr[i] = new Street(line[0], houses);
            }
            Street[] result = new Street[N];
            int counter = -1;
            foreach(Street x in arr)
                if (-x & (~x % 2 != 0)) result[++counter] = x;
            Street[] r;
            

            if (counter != -1)
            {
                r = new Street[counter+1];
                for (int i = 0; i <= counter; i++)
                {
                    r[i] = result[i];
                    Console.WriteLine(r[i].ToString());
                }
            }

            
            
        }
    }
}
