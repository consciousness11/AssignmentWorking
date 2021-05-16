using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStuffs
{
    class NumArray
    {
        public void sumArray(int[] array)
        {
            int total = array.Sum();
            Console.WriteLine("Sum of array is  " + total);

        }
         public void productArray(int[] array)
        {
            int result = 1;
            for (int i = 0; i < array.Length; i++)
                result = result * array[i];
            Console.WriteLine("Product of array is  " + result);
        }
        public void reverseArray(int[] array)
        {
            Array.Reverse(array);
            Console.Write("Reversed Array: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

        }
               
    }
}
