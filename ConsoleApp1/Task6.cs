using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks1
{
    public class Task6
    {
        private static Object syncObject = new Object();
        private static void Write()
        {
            lock (syncObject)
            {
                Console.WriteLine("test");
                // Other();
            }
        }
        private static void Other()
        {
            lock (syncObject)
            {
                Console.WriteLine("other");
            }
        }

        static public void CheckIt()
        {
            lock (syncObject)
            {
                // var t = Task.Run(() => Other());
                Write();
                // t.Wait();
            }

            Console.ReadLine();
        }
    }
}
