using System;

namespace _3
{
    
    class Telephone
    {
        //поля
        public string name;
        public string model;
        public int year; // ...


        //свойство
        public int Year
        {
            get
            {
                return year;
            }
            set //
            {
                if (value > 2020)
                {
                    throw new ArgumentException("Incorrect year");
                }
                year = value;
            }
        }

        //конструктор
        public Telephone(string name, int year)
        {
            

            this.name = "nokia";
            this.year = 2000;

        }

        public void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(year);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Telephone1 t1 = new  Telephone1();
            t1.name = "Samsung";
            t1.year = 1999;
            Console.WriteLine(t1.name);

            Telephone1 t2 = new Telephone1();
            
            t2.name = "Apple";
            t2.year = 2002;
            Console.WriteLine(t2.name);
            

            Telephone t4 = new Telephone("Nokia", 666);
            Telephone t3 = new Telephone("Xiaomi", 99999);


            t1.Print();
            t2.Print();
            t3.Print();
            t4.Print();
        }
    }
    /// <summary>
    /// тот же класс, но без конструктора
    /// </summary>
    class Telephone1
    {
        //поля
        public string name;
        public string model;
        public int year; // ...


        //свойство
        public int Year
        {
            get
            {
                return year;
            }
            set //
            {
                if (value > 2020)
                {
                    throw new ArgumentException("Incorrect year");
                }
                year = value;
            }
        }

        

        public void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(year);
        }
    }

    // no public fields
}
