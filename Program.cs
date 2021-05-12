using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank_Day_25_Running_Time_And_Complexity
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());
            while(T-- > 0)      // Takes user input for T number of times (counting back from T)
            {
                int n = Int32.Parse(Console.ReadLine());

                if (n >= 2 && isPrime(n)) Console.WriteLine("Prime"); // 1 is not a Prime
                else Console.WriteLine("Not prime");
            }            
        }

        public static bool isPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)  // Use of Math.Sqrt determines if number is divisable by other numbers
            {
                if (n % i == 0)
                {
                    return false;      
                }
            }
            return true;
        }
    }
}
