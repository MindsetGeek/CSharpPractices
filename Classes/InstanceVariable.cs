using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractices.Classes
{
    public class InstanceVariable
    {
        public int x = 12;
        public void ShowMessage()
        {
            Console.WriteLine("Show Messege method run from InstanceVariable");
        }
        public InstanceVariable(int value)
        {
            this.x = value;
        }
    }
}
