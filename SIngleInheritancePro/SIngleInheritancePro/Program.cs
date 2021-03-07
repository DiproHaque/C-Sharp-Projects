using System;

namespace SIngleInheritancePro
{
    class Program
    {
        static void Main(string[] args)
        {
            Child1 c = new Child1();
            Child1 c1 = new Child1(10);
            Parent c3 = new Parent();
            Parent p = new Parent();
            Child1 c = new Child1();
            p.MethodA();
        }
    }
}
