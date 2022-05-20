using System;

namespace CourseCSharp

{ 

   class Program
    { 
       static void Main(string[] args)
       {

       int n = int.Parse(Console.ReadLine());
       int sum = 0;

            for (int i = 0; i < n; i++)

            {
                int m = 1 + (i * 2);
                Console.WriteLine(m);
                sum += m;
            }

            Console.WriteLine($"Sum: {sum}");
       }
   }
}




