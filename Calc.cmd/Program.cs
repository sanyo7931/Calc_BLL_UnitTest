using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc.BLL;
namespace Calc.cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalc c = new Cal();
            int s = c.Add(2,3);
            Console.WriteLine($"2+3={s}");
            Console.ReadKey();
        }
    }
}
