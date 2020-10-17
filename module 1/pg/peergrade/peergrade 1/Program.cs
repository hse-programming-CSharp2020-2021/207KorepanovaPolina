using Microsoft.Win32.SafeHandles;
using System;
using System.Security.Cryptography;

namespace peergrade_1
{
    class Program
    {



        static void Main(string[] args)
        {
            
            Console.WriteLine("\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("                                               press any key to start ...                          "); 
            Console.WriteLine();
            var fin = Console.ReadKey();
            while (fin.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("                                                 ------------------                   ");
                Console.WriteLine("                                     -------------------------------------------   \n");
                Console.WriteLine("                           -------------   WELCOME TO THE \" BULLS & COWS \" !   ------------\n");
                Console.WriteLine("                                        ---------------------------------------          ");
                Console.WriteLine("                                               ------------------                    ");
                Console.WriteLine("\n\n\n\n");
            
                int d = 0;//User input (number of digits)
                int ui = 0; //User input
                int count = 0;
                // Asking if user wants to read the rules.
                Console.WriteLine("                                     Do you want to read the rules beforehand ? \n");
                Console.WriteLine("                                              (Enter Y or y for \"yes\".) \n\n\n\n\n\n");
                string rules = Console.ReadLine();
                if ((rules == "Y") || (rules == "y"))
                {
                    Console.WriteLine("                  \\('0')/               ......... THE RULES  .........           \\('0')/\n");
                    Console.WriteLine("The game of Bulls & Cows is played between 2 players. I'm going to choose a secret code, without repetition of digits. ");
                    Console.WriteLine(" Your job is to guess the secret code in the minimum number of tries.");
                    Console.WriteLine("You will be given the number of matches after each guess. If the matching digits are in their right positions,  ");
                    Console.WriteLine(" they are “bulls”, if in different positions, they are “cows”. \n\n\n\n\n\n");
                }
                
                Console.WriteLine("                               WHAT LENGTH DO YOU WANT YOUR SECRET NUMBER TO BE ?\n\n\n\n");

                Console.WriteLine("         (Choose your own number in range from 1 to 9 or enter 4 to choose the default version of the game)\n\n\n\n\n\n\n\n\n\n");
                
                JustChecking(ref d);
                int inp_number = d;

                //Creating a random number w/ different digits.
                int[] a = new int[inp_number]; 
                for (int i = 0; i < inp_number; i++) 
                {
                    Random r = new Random();
                    int f;
                    bool k = true;
                    while (k)
                    {
                        if (i == 0) f = r.Next(1, 10);
                        else f = r.Next(0, 10);

                        k = false;
                        for (int u = 0; u < inp_number; u++)
                        {
                            if (a[u] == f) k = true;
                        }
                        if (k == false) a[i] = f;
                    }
                }
                //Loop for unlimited guessing
                bool inprocess = true;
                while (inprocess)
                {
                    count++;
                    Console.WriteLine("\n\n\n Take a guess");
                    Console.WriteLine("\n Enter a " + inp_number+"-digit number. All digits must be different!");
                    //Checking user input.
                    Just_Checking_Your_Sanity(ref ui, inp_number); 
                    int yourguess = ui;

                    Console.WriteLine("so your guess is ... " + yourguess);
                    int copyn = yourguess;
                    int incount = 0, shm = 0, shnm = 0;
                    // Looking for equal digits.
                    while (copyn > 0) 
                    {
                        
                        for (int i = inp_number - 1; i >= 0; i--)
                        {
                            if (a[i] == copyn % 10) //Counting bulls and cows.
                            {
                                if (((inp_number - 1) - i) == incount) shm++;
                                else shnm++;
                            }
                        }
                        copyn = copyn / 10;
                        incount++;
                    }
                    Console.WriteLine("\n\nBULLS ... " + shm);
                    Console.WriteLine("(Quantity of elements that were guessed and placed correctly)\n" );
                    Console.WriteLine("COWS ... " + shnm);
                    Console.WriteLine("Quantity of elements that were guessed correctly but placed incorrectly)\n\n\n\n\n\n\n\n\n\n\n\n");

                    if (shm == inp_number) inprocess = false;
                    else Console.WriteLine("Try again!");
                }
                Console.WriteLine("                                                       Congrats!                                                    ");
                Console.WriteLine("\n\n Your score:" + count);
                Console.WriteLine("\n\n\n\n\n\n\n\n                                           Press esc to finish. Press any other key to play again.");
                fin = Console.ReadKey();
            }
            

        }

        public static void JustChecking(ref int d)
        {
            int z;
            bool t = true;
            while (t)
            {
                bool cr1 = false, cr2 = false;
                string s = Console.ReadLine();
                // Checking user input for possibility to convert into int.
                if (!int.TryParse(s, out d))
                {
                    Console.WriteLine("Incorrect input. Try again.\n\n\n\n");
                }
                else cr1 = true;
                // Checking user input for correct value.
                if ((d < 1) || (d > 9)) 
                {
                    if (cr1 == true) Console.WriteLine("digit in range [1...9] needed... \n\n\n\n");
                    
                }
                else cr2 = true;
               

                if (cr1 & cr2) t = false;
            }
            return;
        }

        public static void Just_Checking_Your_Sanity(ref int ui, int inp_n)
        {
            bool criterias = true;
            while (criterias)
            {
                bool criteria1 = false, criteria2 = false;

                string s = Console.ReadLine();
                if (!int.TryParse(s, out ui)) //checking for a correct input format
                {
                    Console.WriteLine("Incorrect input. Try again.");
                }
                else criteria1 = true;
             

                if ((Math.Floor((ui / (Math.Pow(10, inp_n - 1)))) > 0) & (Math.Floor(ui / (Math.Pow(10, inp_n))) == 0)) //checking for digit quantity, negative numbers, a non-zero first digit
                {
                    criteria2 = true;
                }
                else if (criteria1)
                {
                    Console.WriteLine("The number must meet the (folowing) criteria");
                    Console.WriteLine(" - The qantity og digits must match the quantity stated at the start of the game ({0}).", inp_n);
                    Console.WriteLine(" - The number can't start with a zero.");
                    Console.WriteLine(" - The number must be positive");

                }
                int addit = ui;
               

                if (criteria1 & criteria2) criterias = false;

            }

        }






    }
}
