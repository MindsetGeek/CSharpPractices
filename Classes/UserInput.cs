using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractices.Classes
{
    public class UserInput
    {
        public static void Addition()
        {
            Console.Write("Enter first Value : ");
            int firstValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second Value : ");
            int secondValue = Convert.ToInt32(Console.ReadLine());

            int sum = firstValue + secondValue;

            Console.WriteLine("Sum of "+ firstValue + " "+ secondValue + " = "+ sum);
        }
    }
}
