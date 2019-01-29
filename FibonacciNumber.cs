using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    //Accepted
    //Runtime: 48 ms, faster than 61.29% of C# online submissions for Fibonacci Number.
    class Program
    {
        static void Main(string[] args)
        {
            var res = Fib(4);
            Console.WriteLine(res);
            Console.ReadKey(); 
        }

        public static int Fib(int N)
        {
            if (N <= 0) return 0;
            var result = 1;
            var prevResult = 0;
            var extraVar = 0;
            var count = 1;
            while (count <= N)
            {
                extraVar = prevResult;
                prevResult = result;
                result += extraVar;
                count++;
            }
            return prevResult;
        }
    }
}
