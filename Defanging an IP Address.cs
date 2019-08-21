using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProblemSolvingTemplateProject
{
    /// <summary>
    /// Runtime: 120 ms, faster than 5.40% of C# online submissions for Defanging an IP Address.
    /// Memory Usage: 23 MB, less than 100.00% of C# online submissions for Defanging an IP Address. 
    /// </summary>

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DefangIPaddr("1.1.1.1"));
            Console.WriteLine(DefangIPaddr("255.100.50.0"));
            Console.WriteLine(DefangIPaddr("abc"));
            Console.ReadKey();
        }

        public static string DefangIPaddr(string address)
        {
            var expression = new Regex(@"\d{0,4}\.\d{0,4}\.\d{0,4}\.\d{0,4}");
            return expression.Match(address).Success ? address.Replace(".", "[.]") : address;
        }

        /// <summary>
        /// foreach (var item in Hey())
        ///    {
        ///        Console.WriteLine(item);
        ///    }
        /// </summary>
        /// <returns></returns>
        //public static IEnumerable<int> Hey()
        //{
        //    for (var i = 1; i < 6; i++)
        //    {
        //        yield return i;
        //    }
        //}
    }
}