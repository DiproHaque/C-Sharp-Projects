using System;
using System.Collections.Generic;
using System.Text;

namespace SIngleInheritancePro
{
   internal class Child1:Parent 
    {
        internal Child1() : base()
        {
            Console.WriteLine("Child DC");
        }
        internal Child1(int w) : base(w)
        {
            Console.WriteLine("Child PC" + w);
        }

        internal override void MethodA()
        {
            Console.WriteLine("Parent MethodA");
        }
    }
}
