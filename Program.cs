using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ListManupulation
{
    class Program
    {
        static void Main() 
        {
           List<double> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList(); // read an input and create List of ints

            for (int i = 1; i < nums.Count; i++)
            {                    // 3 3 6 1 // 8 16 16
                if ( nums[i-1] == nums[i] )
                {
                    nums[i - 1] += nums[i];
                    nums.RemoveAt(i);
                    i = 0;  // assign it to  0 , we want always to compare nums[0] to next !!                  
                }
            }

            Console.WriteLine(string.Join(' ', nums));

        }  
    }
}
