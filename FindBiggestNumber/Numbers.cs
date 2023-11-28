using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindBiggestNumber
{
    internal class Numbers
    {
        public static int BiggestNumber(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                if (numbers[i] > max)
                    max = numbers[i];
            return max;

        }

        public static int SecondBiggestNumber(int[] numbers)
        {
            int max = Math.Max(numbers[0], numbers[1]);
            int result = Math.Min(numbers[0], numbers[1]);
            for (int i = 2; i < numbers.Length; i++)
                if (numbers[i] >= max)
                    (result, max) = (max, numbers[i]);
                else if (numbers[i] > result) 
            result = numbers[i];

            return result; 


        }
    }  
}


