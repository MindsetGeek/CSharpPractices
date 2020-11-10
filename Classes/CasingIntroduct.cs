using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractices.Classes
{
    public class CasingIntroduct
    {
        public void Casting()
        {
            int age = 22;
            double weight = 71.50;
            string name = "123245";

            //weight = age; Implicit type casting
            age = (int)weight; // Explicit type casting.

            //name = Convert.ToString(age);

            age = Convert.ToInt32(name);



            Console.WriteLine(age);
        }
    }
}
