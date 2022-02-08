using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks1
{
    public class Task4
    {
        static public void CheckIt()
        {
            int i = 1;
            object obj = i;
            ++i;
            Console.WriteLine(i);
            Console.WriteLine(obj);
            // Console.WriteLine((short)obj);
            Console.WriteLine((short)(int)obj);

            Console.ReadLine();
        }
    }
}
