using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks1
{
    public class A
    {
        public virtual void Foo()
        {
            Console.Write("Class A");
        }
    }
    public class B : A
    {
        public override void Foo()
        {
            Console.Write("Class B");
        }
    }
    public class Task1
    {
        static public void CheckIt()
        {
            //            B obj1 = new A();
            //            obj1.Foo();

            B obj2 = new B();
            obj2.Foo();

            A obj3 = new B();
            obj3.Foo();

            Console.ReadLine();
        }
    }
}
