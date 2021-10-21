using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstLength;
            int secondLength;
            int thirdLength;

            Console.WriteLine("Please input length of side:");
            firstLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input length of side:");
            secondLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input length of side:");
            thirdLength = Convert.ToInt32(Console.ReadLine());

            if (firstLength == secondLength && secondLength == thirdLength &&
                firstLength == thirdLength)
            {
                Console.WriteLine("The triangle is equilateral.");
            }

            else if (firstLength == secondLength || firstLength == thirdLength ||
                secondLength == thirdLength)
            {
                Console.WriteLine("This triangle is isosceles.");
            }

            else
            {
                Console.WriteLine("This triangle is scalene");
            }

            Console.ReadLine();
     
        }
    }
}
