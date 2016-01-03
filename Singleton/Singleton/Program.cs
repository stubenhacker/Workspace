using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo demo = Demo.Instance;
            demo.Value = 128;

            Demo demo1 = Demo.Instance;
            Console.WriteLine(demo1.Value);
        }
    }
}
