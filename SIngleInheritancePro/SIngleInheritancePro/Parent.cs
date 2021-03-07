using System;
using System.Collections.Generic;
using System.Text;

namespace SIngleInheritancePro
{
    internal class Parent
    {
        internal Parent()
        {
            Console.WriteLine("Parent DC");
        }
        internal Parent(int w)
        {
            Console.WriteLine("Parent PC" + w);
        }

        internal virtual void MethodA()
        {
            Console.WriteLine("Parent MethodA");
        }
    }
}

