using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    //Accepted
    //Runtime: 324 ms, faster than 17.81% of C# online submissions for Fizz Buzz.
    //Memory Usage: 18.5 MB, less than 89.66% of C# online submissions for Fizz Buzz.

    class Program
    {
        static void Main(string[] args)
        {
            var list = FizzBuzz(15);
            Console.ReadKey();
        }

        public static IList<string> FizzBuzz(int n)
        {
            var listToReturn = new List<string>();
            if (n == 0) return listToReturn;
            for (var i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) listToReturn.Add("FizzBuzz");
                else if (i % 3 == 0) listToReturn.Add("Fizz");
                else if (i % 5 == 0) listToReturn.Add("Buzz");
                else listToReturn.Add(i.ToString());
            }
            return listToReturn;
        }
    }
}
