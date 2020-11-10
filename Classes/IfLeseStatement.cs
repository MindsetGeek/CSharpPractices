using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractices.Classes
{
    public class IfLeseStatement
    {
        public void TestIfElse()
        {
            Console.WriteLine("Please Enter a Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 20)
            {
                Console.WriteLine("Twenty");
                int p = number + 2;
                if (p==22)
                {
                    Console.WriteLine("Twenty Two");
                }
                else
                {
                    Console.WriteLine("Not Twenty Two");
                }
            }



            if (number==2)
            {
                Console.WriteLine("User Entered Two");
            }else if (number==3)
            {
                Console.WriteLine("User Entered Three");
            }
            else if (number == 4)
            {
                Console.WriteLine("User Entered Four");
                Console.WriteLine("Twenty");
                int p = number + 2;
                if (p == 22)
                {
                    Console.WriteLine("Twenty Two");
                }
                else
                {
                    Console.WriteLine("Not Twenty Two");
                }
            }
            else
            {
                Console.WriteLine("User Entered "+ number);
                Console.WriteLine("Twenty");
                int p = number + 2;
                if (p == 22)
                {
                    Console.WriteLine("Twenty Two");
                }
                else
                {
                    Console.WriteLine("Not Twenty Two");
                }
            }
        }
    }
}
