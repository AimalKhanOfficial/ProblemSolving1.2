using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    //Accepted
    //Runtime: 140 ms, faster than 46.15% of C# online submissions for Most Common Word.
    //Memory Usage: 11.1 MB, less than 66.67% of C# online submissions for Most Common Word.

    class Program
    {
        static void Main(string[] args)
        {
            var res = MostCommonWord("Bob hit a ball, the hit BALL flew far after it was hit.", new string[] { "hit" });
            Console.WriteLine(res);
            Console.ReadKey(); 
        }

        public static string MostCommonWord(string paragraph, string[] banned)
        {
            paragraph = paragraph.Replace('!', ' ').Replace('?', ' ').Replace('\'', ' ').Replace(',', ' ').Replace(';', ' ').Replace('.', ' ').Trim();
            if (paragraph.Length == 0 || banned.Length == 0) return paragraph.ToLower();
            var dict = new Dictionary<string, int>();
            var allWords = paragraph.Split(' ');
            for (var i = 0; i < allWords.Length; i++)
            {
                allWords[i] = allWords[i].ToLower();
                if (allWords[i] == "" || banned.Contains(allWords[i])) continue;
                if (!dict.ContainsKey(allWords[i])) dict.Add(allWords[i], 1);
                else dict[allWords[i]] = dict[allWords[i]] + 1;
            }
            return dict.Count > 0 ? dict.First(a => a.Value == dict.Values.Max()).Key : "";
        }
    }
}
