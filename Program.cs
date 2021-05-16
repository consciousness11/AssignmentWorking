using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStuffs
{
    class Program
    {
        static void Main(string[] args)
        {
            NumArray nmb = new NumArray();
            int[] array = { 25, 85, 95, 87, 25, 87, 96, 25, 45 };
            nmb.sumArray(array);
            nmb.productArray(array);
            Console.ReadKey();
        }
    }
}
