using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingTemplateProject
{
    /// <summary>
    /// Runtime: 284 ms, faster than 92.63% of C# online submissions for Subdomain Visit Count.
    /// Memory Usage: 30.7 MB, less than 90.91% of C# online submissions for Subdomain Visit Count.
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            var count = SubdomainVisits(new string[] { "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org" }); 
            Console.ReadKey();
        }

        public static IList<string> SubdomainVisits(string[] cpdomains)
        {
            if (cpdomains.Length == 0) return new List<string>(); 
            var keyValuePair = new Dictionary<string, int>();
            var domainName = "";
            for(var i = 0; i < cpdomains.Length; i++)
            {
                domainName = "";
                var domainDetails = cpdomains[i].Split(' ');
                var domainsPerDot = domainDetails[1].Split('.');
                for (var j = domainsPerDot.Length - 1; j >= 0 ; j--)
                {
                    if (domainName != "") domainName = "." + domainName;
                    domainName = domainsPerDot[j] + domainName;
                    if (!keyValuePair.Keys.Contains(domainName)) keyValuePair.Add(domainName, int.Parse(domainDetails[0]));
                    else keyValuePair[domainName] = keyValuePair[domainName] + int.Parse(domainDetails[0]);
                }
            }
            var toReturn = new List<string>();
            for (var i = 0; i < keyValuePair.Keys.Count; i++)
            {
                toReturn.Add(keyValuePair.Values.ElementAt(i) + " " + keyValuePair.Keys.ElementAt(i));
            }
            return toReturn;
        }
    }
}
