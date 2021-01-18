using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3_sem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите первое чило для умножения");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите второе чило для умножения");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x * y;
            Console.WriteLine ("Умнежение рано "+z);
            Console.ReadLine();
        }
    }
}
