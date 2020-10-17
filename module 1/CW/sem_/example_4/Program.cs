using System;
using System.IO;


namespace example_4
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = @"Data.txt"; // Создаем файл с данными
            if (File.Exists(path))
            {
                string[] createText = new string[10];
                Random rand = new Random();
                for (int i = 0; i < createText.Length; i++)
                {
                    createText[i] = rand.Next(10, 100).ToString();
                }
                string text = String.Join(' ', createText);
                File.WriteAllText(path, text, Encoding.UTF8);
            } // Open the file to read from
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                string[] stringValues = readText.Split(' ');
                int[] arr = StringArrayToIntArray(stringValues);
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                int[] evenIndexes = new int[0];
                int[] oddIndexes = new int[0]; for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        Array.Resize(ref evenIndexes, evenIndexes.Length + 1);
                        evenIndexes[evenIndexes.Length - 1] = i;
                    }
                    else
                    {
                        Array.Resize(ref oddIndexes, oddIndexes.Length + 1);
                        oddIndexes[oddIndexes.Length - 1] = i;
                        arr[i] = 0;
                    }
                }
                Console.Write(Environment.NewLine);
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
            }
        } // end of Main()


    }
}
