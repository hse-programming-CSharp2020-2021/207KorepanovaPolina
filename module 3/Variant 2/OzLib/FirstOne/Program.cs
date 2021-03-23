using OzLib;
using System;
using System.IO;

namespace FirstOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            if (!int.TryParse(Console.ReadLine(), out int N))
            {
                Console.WriteLine("Incorrect format : N");
                goto Start;
            }

            Street[] streetsArray = new Street[N];
            
            if (!CorrectInput(N, out streetsArray)) Generate(N, ref streetsArray);


            foreach (Street street in streetsArray)
                Console.WriteLine(street.ToString());

            using (StreamWriter str = new StreamWriter("output.txt"))
                foreach (var e in streetsArray)
                    str.WriteLine(e.ToString());
        }

        public static bool CorrectInput(int N, out Street[] arr)
        {
            arr = new Street[N];
            int[] houses;

            string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "data.txt", System.Text.Encoding.UTF8);

            if (lines.Length < N)
                N = lines.Length;

            for (int i = 0; i < N; i++)
            {
                string[] line = lines[i].Split(" ");
                houses = new int[line.Length - 1];

                for (int z = 1; z<line.Length; z++)
                {
                    if (!int.TryParse(line[z], out int num))
                        return false;
                    else houses[z - 1] = num;
                }
                arr[i] = new Street(line[0], houses);
            }
            return true;
        }

        public static void Generate(int N, ref Street[] array)
        {
            string name = "";
            int[] houses;

            Random r = new Random();
            for (int i = 0; i<N; i++)
            {
                name = GenerateName();
                houses = GenerateHouses();
                array[i] = new Street(name, houses);
            }
        }

        public static string GenerateName()
        {
            int stNameLength = 6;
            Random r = new Random();
            string name = ((char)r.Next(97, 122)).ToString().ToUpper();
            for (int i = 0; i < stNameLength-1; i++) 
                name += ((char)r.Next(97, 122)).ToString();
            return name;
        }

        public static int[] GenerateHouses()
        {
            
            Random r = new Random();
            int housesAmnt = r.Next(2,10);
            int[] houses = new int[housesAmnt];
            for (int i = 0; i < housesAmnt; i++)
                houses[i] = r.Next(101);
            return houses;
        }
    }
}
