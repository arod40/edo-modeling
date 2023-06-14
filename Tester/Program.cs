using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDO;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(double[] point in EDO.EDO.EulerMethod(4, Math.PI / 4, 10, 20, EDO.Function.Read("(cosy)^2/(2*x^(1/2))")))          
            {
                Console.WriteLine("{0} ; {1}", point[0], point[1]);
            }
        }
    }
}
