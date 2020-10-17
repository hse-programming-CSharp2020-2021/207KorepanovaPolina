//[7:54 PM] Горденко Мария Константиновна
using System;
    // Для доступа к классу Consoleusing System.IO; 
    // Для работы с файлами и директориями
    namespace Directories 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Блок try-catch при работе с файлами обязателен!            
            try
            {
                DirectoryOverview(@"..\..\..\");

            }
            catch (Exception)
            {


            }
                Console.WriteLine("Нажмите любую клавишу, чтобы выйти");
            Console.ReadLine();
        }
    }
}

