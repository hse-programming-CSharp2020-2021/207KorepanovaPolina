
using System;
using System.IO;
class Program 
{

    static void Main()

    {

        string text = "My text";
        string path = "MyFile.txt";
        File.WriteAllText(path, text);

        string readFromFile1 = File.ReadAllText(path);
        Console.WriteLine(readFromFile1); 
        string[] strings = { "1", "2", "3" };
        string path2 = "MyFile2.txt";
        File.WriteAllLines(path2, strings);

        string[] readFromFile2 = File.ReadAllLines(path2);
        Console.WriteLine(readFromFile2);
        Array.ForEach(readFromFile2, x => Console.WriteLine(x)); File.AppendAllText(path2, "from append method");
        Console.WriteLine("*******");

        readFromFile2 = File.ReadAllLines(path2);
        Console.WriteLine(readFromFile2);
        Array.ForEach(readFromFile2, x => Console.WriteLine(x)); File.AppendAllLines(path2, new string[] { Environment.NewLine + "from appendlines method", "4" });
        Console.WriteLine("*******");

        readFromFile2 = File.ReadAllLines(path2);
        Console.WriteLine(readFromFile2);

        Array.ForEach(readFromFile2, x => Console.WriteLine(x));

    }

}

