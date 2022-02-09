using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks1
{
    public class CA
    {
        public virtual void Print1()
        {
            Console.Write("A");
        }
        public void Print2()
        {
            Console.Write("A");
        }
    }
    public class CB : CA
    {
        public override void Print1()
        {
            Console.Write("B");
        }
    }
    public class CC : CB
    {
        new public void Print2()
        {
            Console.Write("C");
        }
    }

    public class Task7
    {
        static public void CheckIt()
        {
            var c = new CC();
            CA a = c;

            a.Print2();
            a.Print1();
            c.Print2();

            Console.ReadLine();
        }
    }
}
