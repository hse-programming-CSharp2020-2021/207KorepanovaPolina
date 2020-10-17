//[7:49 PM] Горденко Мария Константиновна
using System;

using System.IO; namespace Task06

{​​​​

    class Program

    {​​​​

        static void Main(string[] args)

        {​​​​

            try

            {​​​​

                int n = int.Parse(Console.ReadLine());

            }​​​​


      catch (FormatException ex)

            {​​​​

                Console.WriteLine("format!" + ex.Message);

            }​​​​


      catch (OverflowException ex)

            {​​​​

                Console.WriteLine("over!" + ex.Message);

            }​​​​


      catch (Exception ex)

            {​​​​

                Console.WriteLine("ex!" + ex.Message);

            }​​​​


      finally

            {​​​​

                Console.WriteLine("fin!");

            }​​​​

        }​​​​

    }​​​​

}​​​​

