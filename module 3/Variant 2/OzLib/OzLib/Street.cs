
using System;

namespace OzLib
{
    public class Street
    {
        public string name;
        public int[] houses;

        public Street(string name, int[] houses)
        {
            this.name = name;
            this.houses = houses;
        }

        public static int operator ~(Street street) => street.houses.Length;
        public static bool operator -(Street street)
        {
            foreach(int h in street.houses)
            {
                if (h == 7) return true;
            }
            return false;
        }

        public override string ToString()
        {
            string info = name + " ";
            foreach (int h in houses) info += h + " ";
            return info;
        }


    }
}
