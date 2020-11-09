using CSharpPractices.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticVariable.ShowMessage();
            Console.WriteLine(StaticVariable.x);

            Console.Read();
        }
    }
}
